namespace BuildAndShootLauncher2
{
    partial class serverList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(serverList));
            this.serverListDataGrid = new System.Windows.Forms.DataGridView();
            this.connectToServerButton = new System.Windows.Forms.Button();
            this.addFavoritesButton = new System.Windows.Forms.Button();
            this.viewFavoritesButton = new System.Windows.Forms.Button();
            this.viewAllButton = new System.Windows.Forms.Button();
            this.playersOnline = new System.Windows.Forms.Label();
            this.serverCount = new System.Windows.Forms.Label();
            this.changeModsButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.serverSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectedModLabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.localHostButton = new System.Windows.Forms.Button();
            this.changeGameSettButton = new System.Windows.Forms.Button();
            this.injectPubovlButton = new System.Windows.Forms.Button();
            this.injectAllButton = new System.Windows.Forms.Button();
            this.injectCustomsButton = new System.Windows.Forms.Button();
            this.lastRefreshLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.serverListDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // serverListDataGrid
            // 
            this.serverListDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serverListDataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.serverListDataGrid.Location = new System.Drawing.Point(12, 12);
            this.serverListDataGrid.MultiSelect = false;
            this.serverListDataGrid.Name = "serverListDataGrid";
            this.serverListDataGrid.ReadOnly = true;
            this.serverListDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.serverListDataGrid.Size = new System.Drawing.Size(571, 305);
            this.serverListDataGrid.TabIndex = 0;
            this.serverListDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.serverListDataGrid_CellContentClick);
            this.serverListDataGrid.SelectionChanged += new System.EventHandler(this.serverListDataGrid_SelectionChanged);
            this.serverListDataGrid.Click += new System.EventHandler(this.serverListDataGrid_Click);
            this.serverListDataGrid.DoubleClick += new System.EventHandler(this.serverListDataGrid_DoubleClick);
            // 
            // connectToServerButton
            // 
            this.connectToServerButton.Location = new System.Drawing.Point(589, 287);
            this.connectToServerButton.Name = "connectToServerButton";
            this.connectToServerButton.Size = new System.Drawing.Size(243, 57);
            this.connectToServerButton.TabIndex = 1;
            this.connectToServerButton.Text = "Connect";
            this.connectToServerButton.UseVisualStyleBackColor = true;
            this.connectToServerButton.Click += new System.EventHandler(this.connectToServerButton_Click);
            // 
            // addFavoritesButton
            // 
            this.addFavoritesButton.Location = new System.Drawing.Point(589, 200);
            this.addFavoritesButton.Name = "addFavoritesButton";
            this.addFavoritesButton.Size = new System.Drawing.Size(243, 23);
            this.addFavoritesButton.TabIndex = 2;
            this.addFavoritesButton.Text = "Add to Favorites";
            this.addFavoritesButton.UseVisualStyleBackColor = true;
            this.addFavoritesButton.Click += new System.EventHandler(this.addFavoritesButton_Click);
            // 
            // viewFavoritesButton
            // 
            this.viewFavoritesButton.Location = new System.Drawing.Point(589, 41);
            this.viewFavoritesButton.Name = "viewFavoritesButton";
            this.viewFavoritesButton.Size = new System.Drawing.Size(75, 23);
            this.viewFavoritesButton.TabIndex = 4;
            this.viewFavoritesButton.Text = "Favorites";
            this.viewFavoritesButton.UseVisualStyleBackColor = true;
            this.viewFavoritesButton.Click += new System.EventHandler(this.viewFavoritesButton_Click);
            // 
            // viewAllButton
            // 
            this.viewAllButton.Location = new System.Drawing.Point(589, 12);
            this.viewAllButton.Name = "viewAllButton";
            this.viewAllButton.Size = new System.Drawing.Size(75, 23);
            this.viewAllButton.TabIndex = 5;
            this.viewAllButton.Text = "All";
            this.viewAllButton.UseVisualStyleBackColor = true;
            this.viewAllButton.Click += new System.EventHandler(this.viewAllButton_Click);
            // 
            // playersOnline
            // 
            this.playersOnline.AutoSize = true;
            this.playersOnline.Location = new System.Drawing.Point(589, 96);
            this.playersOnline.Name = "playersOnline";
            this.playersOnline.Size = new System.Drawing.Size(77, 13);
            this.playersOnline.TabIndex = 6;
            this.playersOnline.Text = "Players Online:";
            // 
            // serverCount
            // 
            this.serverCount.AutoSize = true;
            this.serverCount.Location = new System.Drawing.Point(589, 109);
            this.serverCount.Name = "serverCount";
            this.serverCount.Size = new System.Drawing.Size(49, 13);
            this.serverCount.TabIndex = 7;
            this.serverCount.Text = "Servers: ";
            // 
            // changeModsButton
            // 
            this.changeModsButton.Location = new System.Drawing.Point(589, 229);
            this.changeModsButton.Name = "changeModsButton";
            this.changeModsButton.Size = new System.Drawing.Size(243, 23);
            this.changeModsButton.TabIndex = 8;
            this.changeModsButton.Text = "Manage Mods";
            this.changeModsButton.UseVisualStyleBackColor = true;
            this.changeModsButton.Click += new System.EventHandler(this.changeModsButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(589, 70);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 9;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // serverSearch
            // 
            this.serverSearch.Location = new System.Drawing.Point(59, 327);
            this.serverSearch.Name = "serverSearch";
            this.serverSearch.Size = new System.Drawing.Size(443, 20);
            this.serverSearch.TabIndex = 10;
            this.serverSearch.TextChanged += new System.EventHandler(this.serverSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Search:";
            // 
            // selectedModLabel
            // 
            this.selectedModLabel.AutoSize = true;
            this.selectedModLabel.Location = new System.Drawing.Point(589, 122);
            this.selectedModLabel.Name = "selectedModLabel";
            this.selectedModLabel.Size = new System.Drawing.Size(76, 13);
            this.selectedModLabel.TabIndex = 12;
            this.selectedModLabel.Text = "Selected Mod:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(592, 138);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Active servers";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // localHostButton
            // 
            this.localHostButton.Location = new System.Drawing.Point(508, 327);
            this.localHostButton.Name = "localHostButton";
            this.localHostButton.Size = new System.Drawing.Size(75, 20);
            this.localHostButton.TabIndex = 14;
            this.localHostButton.Text = "LocalHost";
            this.localHostButton.UseVisualStyleBackColor = true;
            this.localHostButton.Click += new System.EventHandler(this.localHostButton_Click);
            // 
            // changeGameSettButton
            // 
            this.changeGameSettButton.Location = new System.Drawing.Point(589, 258);
            this.changeGameSettButton.Name = "changeGameSettButton";
            this.changeGameSettButton.Size = new System.Drawing.Size(243, 23);
            this.changeGameSettButton.TabIndex = 15;
            this.changeGameSettButton.Text = "Change Game Settings";
            this.changeGameSettButton.UseVisualStyleBackColor = true;
            this.changeGameSettButton.Click += new System.EventHandler(this.changeGameSett_Click);
            // 
            // injectPubovlButton
            // 
            this.injectPubovlButton.Location = new System.Drawing.Point(739, 41);
            this.injectPubovlButton.Name = "injectPubovlButton";
            this.injectPubovlButton.Size = new System.Drawing.Size(93, 23);
            this.injectPubovlButton.TabIndex = 16;
            this.injectPubovlButton.Text = "Inject pubovl";
            this.injectPubovlButton.UseVisualStyleBackColor = true;
            this.injectPubovlButton.Click += new System.EventHandler(this.injectPubovlButton_Click);
            // 
            // injectAllButton
            // 
            this.injectAllButton.Location = new System.Drawing.Point(739, 12);
            this.injectAllButton.Name = "injectAllButton";
            this.injectAllButton.Size = new System.Drawing.Size(93, 23);
            this.injectAllButton.TabIndex = 17;
            this.injectAllButton.Text = "Inject All";
            this.injectAllButton.UseVisualStyleBackColor = true;
            this.injectAllButton.Click += new System.EventHandler(this.injectAllButton_Click);
            // 
            // injectCustomsButton
            // 
            this.injectCustomsButton.Location = new System.Drawing.Point(739, 70);
            this.injectCustomsButton.Name = "injectCustomsButton";
            this.injectCustomsButton.Size = new System.Drawing.Size(93, 23);
            this.injectCustomsButton.TabIndex = 18;
            this.injectCustomsButton.Text = "Inject Customs";
            this.injectCustomsButton.UseVisualStyleBackColor = true;
            this.injectCustomsButton.Click += new System.EventHandler(this.injectCustomsButton_Click);
            // 
            // lastRefreshLabel
            // 
            this.lastRefreshLabel.AutoSize = true;
            this.lastRefreshLabel.Location = new System.Drawing.Point(670, 75);
            this.lastRefreshLabel.Name = "lastRefreshLabel";
            this.lastRefreshLabel.Size = new System.Drawing.Size(61, 13);
            this.lastRefreshLabel.TabIndex = 19;
            this.lastRefreshLabel.Text = "last_refresh";
            // 
            // serverList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 356);
            this.Controls.Add(this.lastRefreshLabel);
            this.Controls.Add(this.injectCustomsButton);
            this.Controls.Add(this.injectAllButton);
            this.Controls.Add(this.injectPubovlButton);
            this.Controls.Add(this.changeGameSettButton);
            this.Controls.Add(this.localHostButton);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.selectedModLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serverSearch);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.changeModsButton);
            this.Controls.Add(this.serverCount);
            this.Controls.Add(this.playersOnline);
            this.Controls.Add(this.viewAllButton);
            this.Controls.Add(this.viewFavoritesButton);
            this.Controls.Add(this.addFavoritesButton);
            this.Controls.Add(this.connectToServerButton);
            this.Controls.Add(this.serverListDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "serverList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server List";
            this.Load += new System.EventHandler(this.serverList_Load);
            this.Click += new System.EventHandler(this.serverList_Click);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.serverList_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.serverListDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView serverListDataGrid;
        private System.Windows.Forms.Button connectToServerButton;
        private System.Windows.Forms.Button addFavoritesButton;
        private System.Windows.Forms.Button viewFavoritesButton;
        private System.Windows.Forms.Button viewAllButton;
        private System.Windows.Forms.Label playersOnline;
        private System.Windows.Forms.Label serverCount;
        private System.Windows.Forms.Button changeModsButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TextBox serverSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label selectedModLabel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button localHostButton;
        private System.Windows.Forms.Button changeGameSettButton;
        private System.Windows.Forms.Button injectPubovlButton;
        private System.Windows.Forms.Button injectAllButton;
        private System.Windows.Forms.Button injectCustomsButton;
        private System.Windows.Forms.Label lastRefreshLabel;
    }
}