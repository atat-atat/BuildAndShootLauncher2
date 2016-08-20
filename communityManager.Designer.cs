namespace BuildAndShootLauncher2
{
    partial class communityManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(communityManager));
            this.downloadOffAssets = new System.Windows.Forms.Button();
            this.exploreMods = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // downloadOffAssets
            // 
            this.downloadOffAssets.Location = new System.Drawing.Point(13, 13);
            this.downloadOffAssets.Name = "downloadOffAssets";
            this.downloadOffAssets.Size = new System.Drawing.Size(488, 53);
            this.downloadOffAssets.TabIndex = 0;
            this.downloadOffAssets.Text = "Download Official Assets";
            this.downloadOffAssets.UseVisualStyleBackColor = true;
            this.downloadOffAssets.Click += new System.EventHandler(this.downloadOffAssets_Click);
            // 
            // exploreMods
            // 
            this.exploreMods.Location = new System.Drawing.Point(13, 72);
            this.exploreMods.Name = "exploreMods";
            this.exploreMods.Size = new System.Drawing.Size(488, 53);
            this.exploreMods.TabIndex = 1;
            this.exploreMods.Text = "Explore Community Mods";
            this.exploreMods.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(12, 226);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // communityManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 261);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.exploreMods);
            this.Controls.Add(this.downloadOffAssets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "communityManager";
            this.Text = "Community";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button downloadOffAssets;
        private System.Windows.Forms.Button exploreMods;
        private System.Windows.Forms.Button closeButton;
    }
}