namespace BuildAndShootLauncher2
{
    partial class downloadOfficialAssets
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
            this.label1 = new System.Windows.Forms.Label();
            this.offAssetDataGrid = new System.Windows.Forms.DataGridView();
            this.downloadInstallButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.authorLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.offAssetDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Download official mods, and patches.";
            // 
            // offAssetDataGrid
            // 
            this.offAssetDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.offAssetDataGrid.Location = new System.Drawing.Point(13, 30);
            this.offAssetDataGrid.MultiSelect = false;
            this.offAssetDataGrid.Name = "offAssetDataGrid";
            this.offAssetDataGrid.ReadOnly = true;
            this.offAssetDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.offAssetDataGrid.Size = new System.Drawing.Size(337, 251);
            this.offAssetDataGrid.TabIndex = 1;
            this.offAssetDataGrid.SelectionChanged += new System.EventHandler(this.offAssetDataGrid_SelectionChanged);
            // 
            // downloadInstallButton
            // 
            this.downloadInstallButton.Location = new System.Drawing.Point(356, 202);
            this.downloadInstallButton.Name = "downloadInstallButton";
            this.downloadInstallButton.Size = new System.Drawing.Size(193, 49);
            this.downloadInstallButton.TabIndex = 2;
            this.downloadInstallButton.Text = "Download and Install";
            this.downloadInstallButton.UseVisualStyleBackColor = true;
            this.downloadInstallButton.Click += new System.EventHandler(this.downloadInstallButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(356, 257);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(193, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(357, 30);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(62, 13);
            this.infoLabel.TabIndex = 4;
            this.infoLabel.Text = "Information:";
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Location = new System.Drawing.Point(357, 173);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(41, 13);
            this.authorLabel.TabIndex = 5;
            this.authorLabel.Text = "Author:";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(357, 186);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(45, 13);
            this.versionLabel.TabIndex = 6;
            this.versionLabel.Text = "Version:";
            // 
            // downloadOfficialAssets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 293);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.downloadInstallButton);
            this.Controls.Add(this.offAssetDataGrid);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "downloadOfficialAssets";
            this.ShowIcon = false;
            this.Text = "Official Asset Manager";
            ((System.ComponentModel.ISupportInitialize)(this.offAssetDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView offAssetDataGrid;
        private System.Windows.Forms.Button downloadInstallButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label versionLabel;
    }
}