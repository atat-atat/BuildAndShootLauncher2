namespace BuildAndShootLauncher2
{
    partial class versionsInstaller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(versionsInstaller));
            this.versionSetupLabel = new System.Windows.Forms.Label();
            this.installButton = new System.Windows.Forms.Button();
            this.versionSelectGrid = new System.Windows.Forms.DataGridView();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.versionSelectGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // versionSetupLabel
            // 
            this.versionSetupLabel.AutoSize = true;
            this.versionSetupLabel.Location = new System.Drawing.Point(12, 9);
            this.versionSetupLabel.Name = "versionSetupLabel";
            this.versionSetupLabel.Size = new System.Drawing.Size(35, 13);
            this.versionSetupLabel.TabIndex = 0;
            this.versionSetupLabel.Text = "TEXT";
            // 
            // installButton
            // 
            this.installButton.Location = new System.Drawing.Point(12, 196);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(460, 45);
            this.installButton.TabIndex = 1;
            this.installButton.Text = "Download and Install";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // versionSelectGrid
            // 
            this.versionSelectGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.versionSelectGrid.Location = new System.Drawing.Point(13, 26);
            this.versionSelectGrid.MultiSelect = false;
            this.versionSelectGrid.Name = "versionSelectGrid";
            this.versionSelectGrid.ReadOnly = true;
            this.versionSelectGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.versionSelectGrid.Size = new System.Drawing.Size(594, 164);
            this.versionSelectGrid.TabIndex = 2;
            this.versionSelectGrid.SelectionChanged += new System.EventHandler(this.versionSelectGrid_SelectionChanged);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(478, 196);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(129, 45);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // versionsInstaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 254);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.versionSelectGrid);
            this.Controls.Add(this.installButton);
            this.Controls.Add(this.versionSetupLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "versionsInstaller";
            this.Text = "Version Setup";
            ((System.ComponentModel.ISupportInitialize)(this.versionSelectGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label versionSetupLabel;
        private System.Windows.Forms.Button installButton;
        private System.Windows.Forms.DataGridView versionSelectGrid;
        private System.Windows.Forms.Button closeButton;
    }
}