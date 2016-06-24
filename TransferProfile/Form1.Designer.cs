namespace TransferProfile
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreButton = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.backupLocationText = new System.Windows.Forms.TextBox();
            this.backupButton = new System.Windows.Forms.Button();
            this.UserList = new System.Windows.Forms.CheckedListBox();
            this.startWindowsUpgrade_button = new System.Windows.Forms.Button();
            this.startRestoreButton = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.restoreText = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(542, 24);
            this.MenuStrip1.TabIndex = 18;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "Help";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.AboutToolStripMenuItem.Text = "About";
            // 
            // restoreButton
            // 
            this.restoreButton.Location = new System.Drawing.Point(330, 135);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(75, 23);
            this.restoreButton.TabIndex = 17;
            this.restoreButton.Text = "Restore";
            this.restoreButton.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(314, 322);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(135, 23);
            this.Button2.TabIndex = 16;
            this.Button2.Text = "Malware Scan Selected";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(314, 84);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(116, 13);
            this.Label1.TabIndex = 15;
            this.Label1.Text = "Backup folder location:";
            // 
            // backupLocationText
            // 
            this.backupLocationText.Location = new System.Drawing.Point(314, 100);
            this.backupLocationText.Name = "backupLocationText";
            this.backupLocationText.Size = new System.Drawing.Size(191, 20);
            this.backupLocationText.TabIndex = 14;
            // 
            // backupButton
            // 
            this.backupButton.Location = new System.Drawing.Point(330, 43);
            this.backupButton.Name = "backupButton";
            this.backupButton.Size = new System.Drawing.Size(75, 23);
            this.backupButton.TabIndex = 13;
            this.backupButton.Text = "Backup";
            this.backupButton.UseVisualStyleBackColor = true;
            this.backupButton.Click += new System.EventHandler(this.backupButton_Click);
            // 
            // UserList
            // 
            this.UserList.CheckOnClick = true;
            this.UserList.FormattingEnabled = true;
            this.UserList.Location = new System.Drawing.Point(12, 43);
            this.UserList.Name = "UserList";
            this.UserList.Size = new System.Drawing.Size(296, 334);
            this.UserList.TabIndex = 12;
            // 
            // startWindowsUpgrade_button
            // 
            this.startWindowsUpgrade_button.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.startWindowsUpgrade_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startWindowsUpgrade_button.Location = new System.Drawing.Point(314, 277);
            this.startWindowsUpgrade_button.Name = "startWindowsUpgrade_button";
            this.startWindowsUpgrade_button.Size = new System.Drawing.Size(135, 23);
            this.startWindowsUpgrade_button.TabIndex = 22;
            this.startWindowsUpgrade_button.Text = "Start Windows Upgrade";
            this.startWindowsUpgrade_button.UseVisualStyleBackColor = false;
            // 
            // startRestoreButton
            // 
            this.startRestoreButton.Location = new System.Drawing.Point(330, 214);
            this.startRestoreButton.Name = "startRestoreButton";
            this.startRestoreButton.Size = new System.Drawing.Size(91, 23);
            this.startRestoreButton.TabIndex = 21;
            this.startRestoreButton.Text = "Start Restore";
            this.startRestoreButton.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(314, 172);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(119, 13);
            this.Label2.TabIndex = 20;
            this.Label2.Text = "Restore Folder location:";
            // 
            // restoreText
            // 
            this.restoreText.Location = new System.Drawing.Point(314, 188);
            this.restoreText.Name = "restoreText";
            this.restoreText.Size = new System.Drawing.Size(191, 20);
            this.restoreText.TabIndex = 19;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(306, 383);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(236, 23);
            this.progressBar1.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 406);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.MenuStrip1);
            this.Controls.Add(this.restoreButton);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.backupLocationText);
            this.Controls.Add(this.backupButton);
            this.Controls.Add(this.UserList);
            this.Controls.Add(this.startWindowsUpgrade_button);
            this.Controls.Add(this.startRestoreButton);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.restoreText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer Profile";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        internal System.Windows.Forms.Button restoreButton;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox backupLocationText;
        internal System.Windows.Forms.Button backupButton;
        internal System.Windows.Forms.CheckedListBox UserList;
        internal System.Windows.Forms.Button startWindowsUpgrade_button;
        internal System.Windows.Forms.Button startRestoreButton;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox restoreText;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

