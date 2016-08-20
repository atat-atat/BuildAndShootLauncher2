namespace BuildAndShootLauncher2
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.playButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.communityButton = new System.Windows.Forms.Button();
            this.setupButton = new System.Windows.Forms.Button();
            this.buildAndShootLink = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.usingBnSLLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BuildAndShootLauncher2.Properties.Resources.bns_launcher_icon;
            this.pictureBox1.Location = new System.Drawing.Point(296, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 237);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(12, 28);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(214, 36);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(12, 70);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(214, 36);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Direct Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(12, 196);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(214, 36);
            this.quitButton.TabIndex = 3;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // communityButton
            // 
            this.communityButton.Enabled = false;
            this.communityButton.Location = new System.Drawing.Point(12, 112);
            this.communityButton.Name = "communityButton";
            this.communityButton.Size = new System.Drawing.Size(214, 36);
            this.communityButton.TabIndex = 4;
            this.communityButton.Text = "Community";
            this.communityButton.UseVisualStyleBackColor = true;
            this.communityButton.Click += new System.EventHandler(this.communityButton_Click);
            // 
            // setupButton
            // 
            this.setupButton.Location = new System.Drawing.Point(12, 154);
            this.setupButton.Name = "setupButton";
            this.setupButton.Size = new System.Drawing.Size(214, 36);
            this.setupButton.TabIndex = 5;
            this.setupButton.Text = "Setup";
            this.setupButton.UseVisualStyleBackColor = true;
            this.setupButton.Click += new System.EventHandler(this.setupButton_Click);
            // 
            // buildAndShootLink
            // 
            this.buildAndShootLink.AutoSize = true;
            this.buildAndShootLink.Location = new System.Drawing.Point(331, 236);
            this.buildAndShootLink.Name = "buildAndShootLink";
            this.buildAndShootLink.Size = new System.Drawing.Size(100, 13);
            this.buildAndShootLink.TabIndex = 6;
            this.buildAndShootLink.TabStop = true;
            this.buildAndShootLink.Text = "BuildAndShoot.com";
            this.buildAndShootLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.buildAndShootLink_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = ", Buld Then Snip, LLC";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(12, 12);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(82, 13);
            this.welcomeLabel.TabIndex = 8;
            this.welcomeLabel.Text = "Welcome back,";
            // 
            // usingBnSLLabel
            // 
            this.usingBnSLLabel.AutoSize = true;
            this.usingBnSLLabel.Location = new System.Drawing.Point(12, 239);
            this.usingBnSLLabel.Name = "usingBnSLLabel";
            this.usingBnSLLabel.Size = new System.Drawing.Size(111, 13);
            this.usingBnSLLabel.TabIndex = 9;
            this.usingBnSLLabel.Text = "(Using BnS Launcher)";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.usingBnSLLabel);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buildAndShootLink);
            this.Controls.Add(this.setupButton);
            this.Controls.Add(this.communityButton);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Build & Shoot Launcher";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button communityButton;
        private System.Windows.Forms.Button setupButton;
        private System.Windows.Forms.LinkLabel buildAndShootLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label usingBnSLLabel;
    }
}

