namespace KeePassCPEO
{
    partial class CustomDateOptionsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomDateOptionsDialog));
            this.BannerImage = new System.Windows.Forms.PictureBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.AcceptBtn = new System.Windows.Forms.Button();
            this.CustomOptionsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BannerImage)).BeginInit();
            this.SuspendLayout();
            // 
            // BannerImage
            // 
            this.BannerImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.BannerImage.Location = new System.Drawing.Point(0, 0);
            this.BannerImage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BannerImage.Name = "BannerImage";
            this.BannerImage.Size = new System.Drawing.Size(723, 116);
            this.BannerImage.TabIndex = 13;
            this.BannerImage.TabStop = false;
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(554, 520);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(150, 44);
            this.CancelBtn.TabIndex = 15;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // AcceptBtn
            // 
            this.AcceptBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AcceptBtn.Location = new System.Drawing.Point(392, 520);
            this.AcceptBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.AcceptBtn.Name = "AcceptBtn";
            this.AcceptBtn.Size = new System.Drawing.Size(150, 44);
            this.AcceptBtn.TabIndex = 14;
            this.AcceptBtn.Text = "Accept";
            this.AcceptBtn.UseVisualStyleBackColor = true;
            this.AcceptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
            // 
            // CustomOptionsListBox
            // 
            this.CustomOptionsListBox.FormattingEnabled = true;
            this.CustomOptionsListBox.ItemHeight = 25;
            this.CustomOptionsListBox.Location = new System.Drawing.Point(18, 152);
            this.CustomOptionsListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CustomOptionsListBox.Name = "CustomOptionsListBox";
            this.CustomOptionsListBox.Size = new System.Drawing.Size(522, 329);
            this.CustomOptionsListBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 498);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(723, 3);
            this.label1.TabIndex = 17;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(554, 152);
            this.AddButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(150, 44);
            this.AddButton.TabIndex = 18;
            this.AddButton.Text = "Add...";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(554, 208);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(150, 44);
            this.DeleteButton.TabIndex = 19;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Add or delete custom entries:";
            // 
            // CustomDateOptionsDialog
            // 
            this.AcceptButton = this.AcceptBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(723, 584);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomOptionsListBox);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AcceptBtn);
            this.Controls.Add(this.BannerImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomDateOptionsDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KeePassCPEO Options";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomDateOptionsDialog_FormClosed);
            this.Load += new System.EventHandler(this.CustomDateOptionsDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BannerImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BannerImage;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button AcceptBtn;
        private System.Windows.Forms.ListBox CustomOptionsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label label2;
    }
}