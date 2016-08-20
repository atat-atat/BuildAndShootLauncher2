namespace BuildAndShootLauncher2
{
    partial class directConnectPopup
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
            this.serverBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.connectConfirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter server URL or server IP/Port:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // serverBox
            // 
            this.serverBox.Location = new System.Drawing.Point(16, 30);
            this.serverBox.Name = "serverBox";
            this.serverBox.Size = new System.Drawing.Size(283, 20);
            this.serverBox.TabIndex = 1;
            this.serverBox.TextChanged += new System.EventHandler(this.serverBox_TextChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(97, 56);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // connectConfirmButton
            // 
            this.connectConfirmButton.Location = new System.Drawing.Point(16, 56);
            this.connectConfirmButton.Name = "connectConfirmButton";
            this.connectConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.connectConfirmButton.TabIndex = 3;
            this.connectConfirmButton.Text = "Connect";
            this.connectConfirmButton.UseVisualStyleBackColor = true;
            this.connectConfirmButton.Click += new System.EventHandler(this.connectConfirmButton_Click);
            // 
            // directConnectPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 88);
            this.Controls.Add(this.connectConfirmButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.serverBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "directConnectPopup";
            this.ShowIcon = false;
            this.Text = "Direct Connect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox serverBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button connectConfirmButton;
    }
}