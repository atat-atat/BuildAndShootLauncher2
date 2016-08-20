namespace BuildAndShootLauncher2
{
    partial class changeModsPopup
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
            this.modsDataGrid = new System.Windows.Forms.DataGridView();
            this.mmDone = new System.Windows.Forms.Button();
            this.mmCancel = new System.Windows.Forms.Button();
            this.modAuthor = new System.Windows.Forms.Label();
            this.modVersion = new System.Windows.Forms.Label();
            this.modDescription = new System.Windows.Forms.Label();
            this.modWebsite = new System.Windows.Forms.LinkLabel();
            this.addModButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.modCover = new System.Windows.Forms.PictureBox();
            this.deleteModButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.modsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modCover)).BeginInit();
            this.SuspendLayout();
            // 
            // modsDataGrid
            // 
            this.modsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.modsDataGrid.Location = new System.Drawing.Point(13, 13);
            this.modsDataGrid.MultiSelect = false;
            this.modsDataGrid.Name = "modsDataGrid";
            this.modsDataGrid.ReadOnly = true;
            this.modsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.modsDataGrid.Size = new System.Drawing.Size(361, 330);
            this.modsDataGrid.TabIndex = 0;
            this.modsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.modsDataGrid_CellContentClick);
            this.modsDataGrid.SelectionChanged += new System.EventHandler(this.modsDataGrid_SelectionChanged);
            // 
            // mmDone
            // 
            this.mmDone.Location = new System.Drawing.Point(381, 251);
            this.mmDone.Name = "mmDone";
            this.mmDone.Size = new System.Drawing.Size(156, 33);
            this.mmDone.TabIndex = 1;
            this.mmDone.Text = "OK";
            this.mmDone.UseVisualStyleBackColor = true;
            this.mmDone.Click += new System.EventHandler(this.mmDone_Click);
            // 
            // mmCancel
            // 
            this.mmCancel.Location = new System.Drawing.Point(381, 290);
            this.mmCancel.Name = "mmCancel";
            this.mmCancel.Size = new System.Drawing.Size(156, 33);
            this.mmCancel.TabIndex = 2;
            this.mmCancel.Text = "Cancel";
            this.mmCancel.UseVisualStyleBackColor = true;
            this.mmCancel.Click += new System.EventHandler(this.mmCancel_Click);
            // 
            // modAuthor
            // 
            this.modAuthor.AutoSize = true;
            this.modAuthor.Location = new System.Drawing.Point(381, 120);
            this.modAuthor.Name = "modAuthor";
            this.modAuthor.Size = new System.Drawing.Size(44, 13);
            this.modAuthor.TabIndex = 4;
            this.modAuthor.Text = "Author: ";
            // 
            // modVersion
            // 
            this.modVersion.AutoSize = true;
            this.modVersion.Location = new System.Drawing.Point(381, 133);
            this.modVersion.Name = "modVersion";
            this.modVersion.Size = new System.Drawing.Size(48, 13);
            this.modVersion.TabIndex = 5;
            this.modVersion.Text = "Version: ";
            // 
            // modDescription
            // 
            this.modDescription.AutoSize = true;
            this.modDescription.Location = new System.Drawing.Point(380, 146);
            this.modDescription.Name = "modDescription";
            this.modDescription.Size = new System.Drawing.Size(66, 13);
            this.modDescription.TabIndex = 6;
            this.modDescription.Text = "Description: ";
            // 
            // modWebsite
            // 
            this.modWebsite.AutoSize = true;
            this.modWebsite.Location = new System.Drawing.Point(381, 206);
            this.modWebsite.Name = "modWebsite";
            this.modWebsite.Size = new System.Drawing.Size(46, 13);
            this.modWebsite.TabIndex = 7;
            this.modWebsite.TabStop = true;
            this.modWebsite.Tag = "";
            this.modWebsite.Text = "Website";
            // 
            // addModButton
            // 
            this.addModButton.Enabled = false;
            this.addModButton.Location = new System.Drawing.Point(381, 329);
            this.addModButton.Name = "addModButton";
            this.addModButton.Size = new System.Drawing.Size(156, 33);
            this.addModButton.TabIndex = 8;
            this.addModButton.Text = "Add Mod from File";
            this.addModButton.UseVisualStyleBackColor = true;
            this.addModButton.Click += new System.EventHandler(this.addModButton_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(13, 349);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(44, 13);
            this.searchLabel.TabIndex = 9;
            this.searchLabel.Text = "Search:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 349);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 20);
            this.textBox1.TabIndex = 10;
            // 
            // modCover
            // 
            this.modCover.Location = new System.Drawing.Point(381, 13);
            this.modCover.Name = "modCover";
            this.modCover.Size = new System.Drawing.Size(156, 104);
            this.modCover.TabIndex = 3;
            this.modCover.TabStop = false;
            // 
            // deleteModButton
            // 
            this.deleteModButton.Location = new System.Drawing.Point(381, 222);
            this.deleteModButton.Name = "deleteModButton";
            this.deleteModButton.Size = new System.Drawing.Size(156, 23);
            this.deleteModButton.TabIndex = 11;
            this.deleteModButton.Text = "Delete Mod";
            this.deleteModButton.UseVisualStyleBackColor = true;
            this.deleteModButton.Click += new System.EventHandler(this.deleteModButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(299, 347);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 12;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // changeModsPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 374);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.deleteModButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.addModButton);
            this.Controls.Add(this.modWebsite);
            this.Controls.Add(this.modDescription);
            this.Controls.Add(this.modVersion);
            this.Controls.Add(this.modAuthor);
            this.Controls.Add(this.modCover);
            this.Controls.Add(this.mmCancel);
            this.Controls.Add(this.mmDone);
            this.Controls.Add(this.modsDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "changeModsPopup";
            this.ShowIcon = false;
            this.Text = "Mod Manager";
            this.Load += new System.EventHandler(this.changeModsPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView modsDataGrid;
        private System.Windows.Forms.Button mmDone;
        private System.Windows.Forms.Button mmCancel;
        private System.Windows.Forms.PictureBox modCover;
        private System.Windows.Forms.Label modAuthor;
        private System.Windows.Forms.Label modVersion;
        private System.Windows.Forms.Label modDescription;
        private System.Windows.Forms.LinkLabel modWebsite;
        private System.Windows.Forms.Button addModButton;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button deleteModButton;
        private System.Windows.Forms.Button refreshButton;
    }
}