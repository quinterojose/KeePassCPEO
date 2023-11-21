namespace KeePassCPEO
{
    partial class CustomDateOptionDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomDateOptionDialog));
            this.label1 = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.AcceptBtn = new System.Windows.Forms.Button();
            this.daysNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BannerImage = new System.Windows.Forms.PictureBox();
            this.monthsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.yearsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.daysNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BannerImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 270);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(567, 3);
            this.label1.TabIndex = 15;
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(398, 292);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(150, 44);
            this.CancelBtn.TabIndex = 17;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // AcceptBtn
            // 
            this.AcceptBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AcceptBtn.Location = new System.Drawing.Point(236, 292);
            this.AcceptBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.AcceptBtn.Name = "AcceptBtn";
            this.AcceptBtn.Size = new System.Drawing.Size(150, 44);
            this.AcceptBtn.TabIndex = 16;
            this.AcceptBtn.Text = "Accept";
            this.AcceptBtn.UseVisualStyleBackColor = true;
            this.AcceptBtn.Click += new System.EventHandler(this.AcceptBtn_Click);
            // 
            // daysNumericUpDown
            // 
            this.daysNumericUpDown.Location = new System.Drawing.Point(18, 127);
            this.daysNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.daysNumericUpDown.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.daysNumericUpDown.Name = "daysNumericUpDown";
            this.daysNumericUpDown.Size = new System.Drawing.Size(86, 31);
            this.daysNumericUpDown.TabIndex = 18;
            // 
            // BannerImage
            // 
            this.BannerImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.BannerImage.Location = new System.Drawing.Point(0, 0);
            this.BannerImage.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BannerImage.Name = "BannerImage";
            this.BannerImage.Size = new System.Drawing.Size(567, 116);
            this.BannerImage.TabIndex = 14;
            this.BannerImage.TabStop = false;
            // 
            // monthsNumericUpDown
            // 
            this.monthsNumericUpDown.Location = new System.Drawing.Point(18, 170);
            this.monthsNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.monthsNumericUpDown.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.monthsNumericUpDown.Name = "monthsNumericUpDown";
            this.monthsNumericUpDown.Size = new System.Drawing.Size(86, 31);
            this.monthsNumericUpDown.TabIndex = 19;
            // 
            // yearsNumericUpDown
            // 
            this.yearsNumericUpDown.Location = new System.Drawing.Point(18, 214);
            this.yearsNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.yearsNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.yearsNumericUpDown.Name = "yearsNumericUpDown";
            this.yearsNumericUpDown.Size = new System.Drawing.Size(86, 31);
            this.yearsNumericUpDown.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Days";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Months";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Years";
            // 
            // CustomDateOptionDialog
            // 
            this.AcceptButton = this.AcceptBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(567, 355);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yearsNumericUpDown);
            this.Controls.Add(this.monthsNumericUpDown);
            this.Controls.Add(this.daysNumericUpDown);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.AcceptBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BannerImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomDateOptionDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Custom Date Option";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomDateOptionDialog_FormClosed);
            this.Load += new System.EventHandler(this.CustomDateOptionDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.daysNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BannerImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BannerImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button AcceptBtn;
        private System.Windows.Forms.NumericUpDown daysNumericUpDown;
        private System.Windows.Forms.NumericUpDown monthsNumericUpDown;
        private System.Windows.Forms.NumericUpDown yearsNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}