using KeePass.UI;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KeePassCPEO
{
    internal partial class CustomDateOptionsDialog : Form
    {
        internal List<CustomDateOption> CustomDateOptions { get; private set; }

        internal CustomDateOptionsDialog()
        {
            InitializeComponent();
        }

        internal CustomDateOptionsDialog(List<CustomDateOption> customDateOptions) : this()
        {
            CustomDateOptions = customDateOptions;
        }

        private void CustomDateOptionsDialog_Load(object sender, EventArgs e)
        {
            GlobalWindowManager.AddWindow(this);
            BannerImage.Image = BannerFactory.CreateBanner(BannerImage.Width, BannerImage.Height, BannerStyle.Default, Properties.Resources.Date_48x48, Text, "Custom password expiration options");
            CustomDateOptions.ForEach(o => CustomOptionsListBox.Items.Add(o));
        }

        private void CustomDateOptionsDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalWindowManager.RemoveWindow(this);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            CustomDateOptionDialog customDateOptionDialog = new CustomDateOptionDialog();
            UIUtil.ShowDialogAndDestroy(customDateOptionDialog);
            if (customDateOptionDialog.DialogResult == DialogResult.OK)
            {
                CustomDateOptions.Add(customDateOptionDialog.CustomDateOption);
                CustomDateOptions.Sort((x, y) => DateTime.Compare(x.ToDate(), y.ToDate()));
            }
            CustomOptionsListBox.Items.Clear();
            CustomDateOptions.ForEach(o => CustomOptionsListBox.Items.Add(o));
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            CustomDateOption option = CustomOptionsListBox.SelectedItem as CustomDateOption;
            if (option != null)
            {
                CustomDateOptions.Remove(option);
                CustomDateOptions.Sort((x, y) => DateTime.Compare(x.ToDate(), y.ToDate()));
            }
            CustomOptionsListBox.Items.Clear();
            CustomDateOptions.ForEach(o => CustomOptionsListBox.Items.Add(o));
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
