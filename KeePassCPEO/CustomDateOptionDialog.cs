using KeePass.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KeePassCPEO
{
    /// <summary>
    /// Dialog to allow adding a custom date option.
    /// </summary>
    public partial class CustomDateOptionDialog : Form
    {
        /// <summary>
        /// Gets or sets the custom date option.
        /// </summary>
        public CustomDateOption CustomDateOption { get; set; }

        /// <summary>
        /// Iniailizes a new instance of CustomDateOptionDialog.
        /// </summary>
        public CustomDateOptionDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Executes when the dialog is loaded.
        /// </summary>
        private void CustomOptionDialog_Load(object sender, EventArgs e)
        {
            GlobalWindowManager.AddWindow(this);
            BannerImage.Image = BannerFactory.CreateBanner(BannerImage.Width, BannerImage.Height, BannerStyle.Default, Properties.Resources.Date_48x48, Text, string.Empty);
        }

        /// <summary>
        /// Executes when the dialog is closed.
        /// </summary>
        private void CustomOptionDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalWindowManager.RemoveWindow(this);
        }

        /// <summary>
        /// Executes when the accept button is clicked.
        /// </summary>
        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            if (CustomDateOption == null)
                CustomDateOption = new CustomDateOption
                {
                    Days = (int)daysNumericUpDown.Value,
                    Months = (int)monthsNumericUpDown.Value,
                    Years = (int)yearsNumericUpDown.Value
                };
            Close();
        }
    }
}
