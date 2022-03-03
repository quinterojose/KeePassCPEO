using KeePass.UI;
using System;
using System.Windows.Forms;

namespace KeePassCPEO
{
    internal partial class CustomDateOptionDialog : Form
    {
        internal CustomDateOption CustomDateOption { get; set; }

        internal CustomDateOptionDialog()
        {
            InitializeComponent();
        }

        private void CustomDateOptionDialog_Load(object sender, EventArgs e)
        {
            GlobalWindowManager.AddWindow(this);
            BannerImage.Image = BannerFactory.CreateBanner(BannerImage.Width, BannerImage.Height, BannerStyle.Default, Properties.Resources.Date_48x48, Text, string.Empty);
        }

        private void CustomDateOptionDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalWindowManager.RemoveWindow(this);
        }

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
