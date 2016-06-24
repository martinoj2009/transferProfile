namespace TransferProfile
{
    partial class loadingScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loadingScreen));
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::TransferProfile.Properties.Resources.Kaseta_magnetofonowa_ubt;
            this.PictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("PictureBox1.InitialImage")));
            this.PictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(484, 244);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 3;
            this.PictureBox1.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(202, 247);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(79, 13);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "PLEASE WAIT";
            // 
            // loadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 266);
            this.ControlBox = false;
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "loadingScreen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Label1;
    }
}