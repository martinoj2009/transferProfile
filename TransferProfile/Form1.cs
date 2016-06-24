using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TransferProfile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            startRestoreButton.Enabled = false;

            RegistryKey ProfileList = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\\Microsoft\Windows NT\\CurrentVersion\\ProfileList\\");
            foreach (string ProfileKey in ProfileList.GetSubKeyNames())
            {
                string account = new System.Security.Principal.SecurityIdentifier(ProfileKey).Translate(typeof(System.Security.Principal.NTAccount)).ToString();
                if(account.Contains("NT AUTHORITY\\") == false)
                {
                    UserList.Items.Add(account);
                }
                
            }



        }


        //This is tested to see if the user scanned the user(s) profiles before backing them up
        bool virusScanned = false;


        private void backupButton_Click(object sender, EventArgs e) 
        {

            //Check if Transwiz exists
            if(File.Exists("Transwiz.exe") == false)
            {

            }


            //Check to see if the profiles have been scanned
            if (virusScanned == false)
            {
                //Loop to make sure the scan is completed without error
                string results = MessageBox.Show("You didn't scan the profile(s) before backing them up. Do you want to scan them first?", "Malware Scan", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
                //If they said YES then scan and continue.
                if (results == "Yes")
                {
                    bool stopLoop = false;
                    do
                    {

                        int returnconde = malwareScan();
                        if (returnconde == 0)
                        {
                            stopLoop = true;
                        }
                        else
                        {
                            string forceStop = MessageBox.Show("There was an error running the scan, would you like to try again?", "Error Scanning", MessageBoxButtons.YesNo, MessageBoxIcon.Error).ToString();
                            
                            if (forceStop == "No")
                            {
                                stopLoop = true;
                            }
                            
                        }
                        
                } while (stopLoop == false);
            }
                

            }


            string users;
            string backupLocation = backupLocationText.Text;

            //If no users are selected then stop
            if(UserList.SelectedItems.Count == 0)
            {
                MessageBox.Show("You need to select at least one user in the list.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //make sure location isn't null or white space, if it is then change to root of system
            if (String.IsNullOrWhiteSpace(backupLocation)) 
            {
                backupLocationText.Text = Directory.GetDirectoryRoot(Environment.GetEnvironmentVariable("WINDIR"));
                backupLocation = backupLocationText.Text;
            }
            

            //Make sure the path provided exists
            if(Directory.Exists(backupLocation) != true)
            {
                MessageBox.Show("The path provided wasn't found.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Go through the list of accounts and build the command
            //This needs to be a for loop, foreach is slower when dealing with a long list as it has to make a new variable and reassign it each time.
            int current = 0;
            foreach (string itemChecked in UserList.CheckedItems)
            {
                //MessageBox.Show("Current: " + current);
                //MessageBox.Show("Checked: " + UserList.CheckedItems.Count.ToString());
                //MessageBox.Show("Percentage: " + (Convert.ToDouble(current) / Convert.ToDouble(UserList.CheckedItems.Count) * 100));
                
                progressBar1.Value = Convert.ToInt32((Convert.ToDouble(current) / Convert.ToDouble(UserList.CheckedItems.Count) * 100)); 
                //statusStrip.Text = current + " of " + UserList.CheckedItems.Count + " completed.";
                string launchString = " /BACKUP /SOURCEACCOUNT " + itemChecked + " /TRANSFERFILE " + backupLocation + itemChecked.Split('\\')[1] + ".tras.zip";
                int launchReturn = launchApplication("Transwiz.exe", launchString);
                if(launchReturn == 1)
                {
                    MessageBox.Show("Transwiz.exe wasn't found. Please make sure the application is in the same directory as the Profile Transfer application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if(launchReturn != 0)
                {
                    MessageBox.Show("There was an error and we cannot continue", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                current++;
                progressBar1.Value = Convert.ToInt32((Convert.ToDouble(current) / Convert.ToDouble(UserList.CheckedItems.Count) * 100));
                //MessageBox.Show("Current: " + current);
                //MessageBox.Show("Checked: " + UserList.CheckedItems.Count.ToString());
                //MessageBox.Show(("Percentage: " + (Convert.ToDouble(current) / Convert.ToDouble(UserList.CheckedItems.Count) * 100)));
                
            }
            if(progressBar1.Value == 100)
            {
                MessageBox.Show("Completed with no errors.", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }

        private int launchApplication(string location, string arguments)
        {
            //MessageBox.Show(location + " " + arguments);
            loadingScreen loading = new loadingScreen();
            loading.Show();
            if(File.Exists(location) == false)
            {
                loading.Close();
                return 1;
            }
            try
            {
                System.Diagnostics.Process p = new System.Diagnostics.Process();
                p.StartInfo.FileName = location;
                p.StartInfo.Arguments = arguments;
                p.Start();
                p.WaitForExit();
            }
            catch(Exception)
            {
                loading.Close();
                return -1;
            }

            loading.Close();
            return 0;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            malwareScan();
        } //Virus scan button
        private int malwareScan()
        {
            //This button will kick off a Malwarebytes or Security Essentials scan
            bool malwarebytes = false;
            virusScanned = true;
            //First check to make sure Malwarebytes is installed
            string programX86Path = Environment.GetEnvironmentVariable("ProgramFiles(x86)");
            if (File.Exists(programX86Path + "\\Malwarebytes' Anti-Malware\\mbam.exe"))
            {
                malwarebytes = true;
            }
            else
            {
                MessageBox.Show("Malwarebytes not found in ProgramFiles(x86).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -2;
            }

            //the real work begins :-D
            if (malwarebytes == true)
            {
                string toScan = "";
                try
                {
                    //open registry
                    RegistryKey ProfilePath = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\\Microsoft\Windows NT\\CurrentVersion\\ProfileList\\");
                    foreach (string ProfileKey in ProfilePath.GetSubKeyNames())
                    {
                        //if the SID that's converted to DOMAIN/USERNAME is in the list of checked items then add the ProfileImagePath of the subkey to the toScan string
                        if (UserList.CheckedItems.Contains(new System.Security.Principal.SecurityIdentifier(ProfileKey).Translate(typeof(System.Security.Principal.NTAccount)).ToString()))
                        {
                            //Open a registry to that user's SID
                            RegistryKey usersSID = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\\Microsoft\Windows NT\\CurrentVersion\\ProfileList\\" + ProfileKey);
                            toScan = toScan + usersSID.GetValue("ProfileImagePath") + " ";
                        }


                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Encountered an error building list of users to scan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }

                int returncode = launchApplication(programX86Path + "\\Malwarebytes' Anti-Malware\\mbam.exe", toScan);
                if(returncode == 0)
                {
                    return 0;
                }

                
            }
            return -3;
            
        }

        private int getForensit()
        {
            try
            {
                File.Copy(@"\\altirisns\\swd\\ForensiT\\Transwiz Professional Edition\\Deployment Files\\Transwiz.exe", "Transwiz.exe");
                File.Copy(@"\\altirisns\\swd\\ForensiT\\Transwiz Professional Edition\\Deployment Files\\Transwiz.xml", "Transwiz.xml");
            }
            catch(Exception)
            {
                return -1;
            }

            return 0;
        }
    }
}
