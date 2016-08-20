namespace BuildAndShootLauncher2
{
    partial class setupPopup
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
            this.versionDataGrid = new System.Windows.Forms.DataGridView();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.cancelChangesButton = new System.Windows.Forms.Button();
            this.setupTabControl = new System.Windows.Forms.TabControl();
            this.generalTab = new System.Windows.Forms.TabPage();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.windowedCheckBox = new System.Windows.Forms.CheckBox();
            this.mouseSensValueLabel = new System.Windows.Forms.Label();
            this.volumeValueLabel = new System.Windows.Forms.Label();
            this.invertCheckBox = new System.Windows.Forms.CheckBox();
            this.mouseSensTrackBar = new System.Windows.Forms.TrackBar();
            this.mouseSensLabel = new System.Windows.Forms.Label();
            this.resComboBox = new System.Windows.Forms.ComboBox();
            this.resLabel = new System.Windows.Forms.Label();
            this.volumeTrackBar = new System.Windows.Forms.TrackBar();
            this.volLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.controlsTab = new System.Windows.Forms.TabPage();
            this.injectionsTab = new System.Windows.Forms.TabPage();
            this.injectionLabel = new System.Windows.Forms.Label();
            this.injectDataGrid = new System.Windows.Forms.DataGridView();
            this.removeDLLButton = new System.Windows.Forms.Button();
            this.addDLLButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.addInstallButton = new System.Windows.Forms.Button();
            this.rmInstallButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.versionDataGrid)).BeginInit();
            this.setupTabControl.SuspendLayout();
            this.generalTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mouseSensTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar)).BeginInit();
            this.injectionsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.injectDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // versionDataGrid
            // 
            this.versionDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.versionDataGrid.Location = new System.Drawing.Point(13, 29);
            this.versionDataGrid.Name = "versionDataGrid";
            this.versionDataGrid.Size = new System.Drawing.Size(110, 191);
            this.versionDataGrid.TabIndex = 0;
            this.versionDataGrid.SelectionChanged += new System.EventHandler(this.versionDataGrid_SelectionChanged);
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Location = new System.Drawing.Point(437, 252);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(75, 23);
            this.saveChangesButton.TabIndex = 2;
            this.saveChangesButton.Text = "OK";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // cancelChangesButton
            // 
            this.cancelChangesButton.Location = new System.Drawing.Point(518, 252);
            this.cancelChangesButton.Name = "cancelChangesButton";
            this.cancelChangesButton.Size = new System.Drawing.Size(75, 23);
            this.cancelChangesButton.TabIndex = 3;
            this.cancelChangesButton.Text = "Cancel";
            this.cancelChangesButton.UseVisualStyleBackColor = true;
            this.cancelChangesButton.Click += new System.EventHandler(this.cancelChangesButton_Click);
            // 
            // setupTabControl
            // 
            this.setupTabControl.Controls.Add(this.generalTab);
            this.setupTabControl.Controls.Add(this.controlsTab);
            this.setupTabControl.Controls.Add(this.injectionsTab);
            this.setupTabControl.Location = new System.Drawing.Point(133, 13);
            this.setupTabControl.Name = "setupTabControl";
            this.setupTabControl.SelectedIndex = 0;
            this.setupTabControl.Size = new System.Drawing.Size(460, 233);
            this.setupTabControl.TabIndex = 4;
            // 
            // generalTab
            // 
            this.generalTab.BackColor = System.Drawing.Color.White;
            this.generalTab.Controls.Add(this.heightTextBox);
            this.generalTab.Controls.Add(this.heightLabel);
            this.generalTab.Controls.Add(this.widthLabel);
            this.generalTab.Controls.Add(this.widthTextBox);
            this.generalTab.Controls.Add(this.windowedCheckBox);
            this.generalTab.Controls.Add(this.mouseSensValueLabel);
            this.generalTab.Controls.Add(this.volumeValueLabel);
            this.generalTab.Controls.Add(this.invertCheckBox);
            this.generalTab.Controls.Add(this.mouseSensTrackBar);
            this.generalTab.Controls.Add(this.mouseSensLabel);
            this.generalTab.Controls.Add(this.resComboBox);
            this.generalTab.Controls.Add(this.resLabel);
            this.generalTab.Controls.Add(this.volumeTrackBar);
            this.generalTab.Controls.Add(this.volLabel);
            this.generalTab.Controls.Add(this.nameTextBox);
            this.generalTab.Controls.Add(this.nameLabel);
            this.generalTab.Location = new System.Drawing.Point(4, 22);
            this.generalTab.Name = "generalTab";
            this.generalTab.Padding = new System.Windows.Forms.Padding(3);
            this.generalTab.Size = new System.Drawing.Size(452, 207);
            this.generalTab.TabIndex = 0;
            this.generalTab.Text = "General";
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(381, 83);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(47, 20);
            this.heightTextBox.TabIndex = 17;
            this.heightTextBox.Visible = false;
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(334, 82);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(41, 13);
            this.heightLabel.TabIndex = 16;
            this.heightLabel.Text = "Height:";
            this.heightLabel.Visible = false;
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(237, 82);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(38, 13);
            this.widthLabel.TabIndex = 15;
            this.widthLabel.Text = "Width:";
            this.widthLabel.Visible = false;
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(281, 83);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(47, 20);
            this.widthTextBox.TabIndex = 14;
            this.widthTextBox.Visible = false;
            // 
            // windowedCheckBox
            // 
            this.windowedCheckBox.AutoSize = true;
            this.windowedCheckBox.Location = new System.Drawing.Point(13, 172);
            this.windowedCheckBox.Name = "windowedCheckBox";
            this.windowedCheckBox.Size = new System.Drawing.Size(77, 17);
            this.windowedCheckBox.TabIndex = 13;
            this.windowedCheckBox.Text = "Windowed";
            this.windowedCheckBox.UseVisualStyleBackColor = true;
            // 
            // mouseSensValueLabel
            // 
            this.mouseSensValueLabel.AutoSize = true;
            this.mouseSensValueLabel.Location = new System.Drawing.Point(278, 132);
            this.mouseSensValueLabel.Name = "mouseSensValueLabel";
            this.mouseSensValueLabel.Size = new System.Drawing.Size(98, 13);
            this.mouseSensValueLabel.TabIndex = 12;
            this.mouseSensValueLabel.Text = "mouse_sens_value";
            // 
            // volumeValueLabel
            // 
            this.volumeValueLabel.AutoSize = true;
            this.volumeValueLabel.Location = new System.Drawing.Point(219, 39);
            this.volumeValueLabel.Name = "volumeValueLabel";
            this.volumeValueLabel.Size = new System.Drawing.Size(73, 13);
            this.volumeValueLabel.TabIndex = 11;
            this.volumeValueLabel.Text = "volume_value";
            // 
            // invertCheckBox
            // 
            this.invertCheckBox.AutoSize = true;
            this.invertCheckBox.Location = new System.Drawing.Point(13, 149);
            this.invertCheckBox.Name = "invertCheckBox";
            this.invertCheckBox.Size = new System.Drawing.Size(98, 17);
            this.invertCheckBox.TabIndex = 10;
            this.invertCheckBox.Text = "Invert Mouse Y";
            this.invertCheckBox.UseVisualStyleBackColor = true;
            // 
            // mouseSensTrackBar
            // 
            this.mouseSensTrackBar.Location = new System.Drawing.Point(109, 122);
            this.mouseSensTrackBar.Name = "mouseSensTrackBar";
            this.mouseSensTrackBar.Size = new System.Drawing.Size(163, 45);
            this.mouseSensTrackBar.TabIndex = 9;
            this.mouseSensTrackBar.ValueChanged += new System.EventHandler(this.mouseSensTrackBar_ValueChanged);
            // 
            // mouseSensLabel
            // 
            this.mouseSensLabel.AutoSize = true;
            this.mouseSensLabel.Location = new System.Drawing.Point(10, 122);
            this.mouseSensLabel.Name = "mouseSensLabel";
            this.mouseSensLabel.Size = new System.Drawing.Size(92, 13);
            this.mouseSensLabel.TabIndex = 8;
            this.mouseSensLabel.Text = "Mouse Sensitivity:";
            // 
            // resComboBox
            // 
            this.resComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resComboBox.FormattingEnabled = true;
            this.resComboBox.Items.AddRange(new object[] {
            "640x480",
            "800x600",
            "1024x768",
            "1152x864",
            "1280x600",
            "1280x720",
            "1280x768",
            "1280x800",
            "1280x960",
            "Custom..."});
            this.resComboBox.Location = new System.Drawing.Point(109, 82);
            this.resComboBox.Name = "resComboBox";
            this.resComboBox.Size = new System.Drawing.Size(121, 21);
            this.resComboBox.TabIndex = 5;
            this.resComboBox.SelectedIndexChanged += new System.EventHandler(this.resComboBox_SelectedIndexChanged);
            // 
            // resLabel
            // 
            this.resLabel.AutoSize = true;
            this.resLabel.Location = new System.Drawing.Point(7, 82);
            this.resLabel.Name = "resLabel";
            this.resLabel.Size = new System.Drawing.Size(60, 13);
            this.resLabel.TabIndex = 4;
            this.resLabel.Text = "Resolution:";
            // 
            // volumeTrackBar
            // 
            this.volumeTrackBar.Location = new System.Drawing.Point(109, 30);
            this.volumeTrackBar.Name = "volumeTrackBar";
            this.volumeTrackBar.Size = new System.Drawing.Size(104, 45);
            this.volumeTrackBar.TabIndex = 3;
            this.volumeTrackBar.ValueChanged += new System.EventHandler(this.volumeTrackBar_ValueChanged);
            // 
            // volLabel
            // 
            this.volLabel.AutoSize = true;
            this.volLabel.Location = new System.Drawing.Point(7, 30);
            this.volLabel.Name = "volLabel";
            this.volLabel.Size = new System.Drawing.Size(45, 13);
            this.volLabel.TabIndex = 2;
            this.volLabel.Text = "Volume:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(109, 7);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(7, 7);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // controlsTab
            // 
            this.controlsTab.BackColor = System.Drawing.Color.White;
            this.controlsTab.Location = new System.Drawing.Point(4, 22);
            this.controlsTab.Name = "controlsTab";
            this.controlsTab.Padding = new System.Windows.Forms.Padding(3);
            this.controlsTab.Size = new System.Drawing.Size(452, 207);
            this.controlsTab.TabIndex = 1;
            this.controlsTab.Text = "Controls";
            // 
            // injectionsTab
            // 
            this.injectionsTab.Controls.Add(this.injectionLabel);
            this.injectionsTab.Controls.Add(this.injectDataGrid);
            this.injectionsTab.Controls.Add(this.removeDLLButton);
            this.injectionsTab.Controls.Add(this.addDLLButton);
            this.injectionsTab.Location = new System.Drawing.Point(4, 22);
            this.injectionsTab.Name = "injectionsTab";
            this.injectionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.injectionsTab.Size = new System.Drawing.Size(452, 207);
            this.injectionsTab.TabIndex = 2;
            this.injectionsTab.Text = "Injections";
            this.injectionsTab.UseVisualStyleBackColor = true;
            // 
            // injectionLabel
            // 
            this.injectionLabel.AutoSize = true;
            this.injectionLabel.Location = new System.Drawing.Point(6, 3);
            this.injectionLabel.Name = "injectionLabel";
            this.injectionLabel.Size = new System.Drawing.Size(159, 13);
            this.injectionLabel.TabIndex = 3;
            this.injectionLabel.Text = "Manage Auto-Injector injections.";
            // 
            // injectDataGrid
            // 
            this.injectDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.injectDataGrid.Location = new System.Drawing.Point(7, 19);
            this.injectDataGrid.MultiSelect = false;
            this.injectDataGrid.Name = "injectDataGrid";
            this.injectDataGrid.ReadOnly = true;
            this.injectDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.injectDataGrid.Size = new System.Drawing.Size(439, 153);
            this.injectDataGrid.TabIndex = 2;
            this.injectDataGrid.SelectionChanged += new System.EventHandler(this.injectDataGrid_SelectionChanged);
            // 
            // removeDLLButton
            // 
            this.removeDLLButton.Location = new System.Drawing.Point(89, 178);
            this.removeDLLButton.Name = "removeDLLButton";
            this.removeDLLButton.Size = new System.Drawing.Size(75, 23);
            this.removeDLLButton.TabIndex = 1;
            this.removeDLLButton.Text = "Remove";
            this.removeDLLButton.UseVisualStyleBackColor = true;
            this.removeDLLButton.Click += new System.EventHandler(this.removeDLLButton_Click);
            // 
            // addDLLButton
            // 
            this.addDLLButton.Location = new System.Drawing.Point(7, 178);
            this.addDLLButton.Name = "addDLLButton";
            this.addDLLButton.Size = new System.Drawing.Size(75, 23);
            this.addDLLButton.TabIndex = 0;
            this.addDLLButton.Text = "Add DLL";
            this.addDLLButton.UseVisualStyleBackColor = true;
            this.addDLLButton.Click += new System.EventHandler(this.addDLLButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Version Select";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(137, 253);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(159, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Use BnS Launcher directory";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // addInstallButton
            // 
            this.addInstallButton.Location = new System.Drawing.Point(13, 226);
            this.addInstallButton.Name = "addInstallButton";
            this.addInstallButton.Size = new System.Drawing.Size(110, 21);
            this.addInstallButton.TabIndex = 7;
            this.addInstallButton.Text = "Add Installation";
            this.addInstallButton.UseVisualStyleBackColor = true;
            this.addInstallButton.Click += new System.EventHandler(this.addInstallButton_Click);
            // 
            // rmInstallButton
            // 
            this.rmInstallButton.Location = new System.Drawing.Point(13, 253);
            this.rmInstallButton.Name = "rmInstallButton";
            this.rmInstallButton.Size = new System.Drawing.Size(110, 23);
            this.rmInstallButton.TabIndex = 8;
            this.rmInstallButton.Text = "Remove Installation";
            this.rmInstallButton.UseVisualStyleBackColor = true;
            // 
            // setupPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 287);
            this.Controls.Add(this.rmInstallButton);
            this.Controls.Add(this.addInstallButton);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setupTabControl);
            this.Controls.Add(this.cancelChangesButton);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.versionDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "setupPopup";
            this.ShowIcon = false;
            this.Text = "Setup";
            ((System.ComponentModel.ISupportInitialize)(this.versionDataGrid)).EndInit();
            this.setupTabControl.ResumeLayout(false);
            this.generalTab.ResumeLayout(false);
            this.generalTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mouseSensTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar)).EndInit();
            this.injectionsTab.ResumeLayout(false);
            this.injectionsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.injectDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView versionDataGrid;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.Button cancelChangesButton;
        private System.Windows.Forms.TabControl setupTabControl;
        private System.Windows.Forms.TabPage generalTab;
        private System.Windows.Forms.TabPage controlsTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox invertCheckBox;
        private System.Windows.Forms.TrackBar mouseSensTrackBar;
        private System.Windows.Forms.Label mouseSensLabel;
        private System.Windows.Forms.ComboBox resComboBox;
        private System.Windows.Forms.Label resLabel;
        private System.Windows.Forms.TrackBar volumeTrackBar;
        private System.Windows.Forms.Label volLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label mouseSensValueLabel;
        private System.Windows.Forms.Label volumeValueLabel;
        private System.Windows.Forms.CheckBox windowedCheckBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.TabPage injectionsTab;
        private System.Windows.Forms.Label injectionLabel;
        private System.Windows.Forms.DataGridView injectDataGrid;
        private System.Windows.Forms.Button removeDLLButton;
        private System.Windows.Forms.Button addDLLButton;
        private System.Windows.Forms.Button addInstallButton;
        private System.Windows.Forms.Button rmInstallButton;
    }
}