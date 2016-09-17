using KeePass.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace KeePassCPEO
{
    /// <summary>
    /// Implement a form to display the list of custom options and allow the user to edit the list.
    /// </summary>
    public partial class CustomDateOptionsDialog : Form
    {
        /// <summary>
        /// Gets the new list of custom date options.
        /// </summary>
        public List<CustomDateOption> CustomDateOptions { get; private set; }

        /// <summary>
        /// Initializes a new instance of CustomDateOptionsDialog
        /// </summary>
        /// <param name="customDateOptions">The list of custom date options.</param>
        public CustomDateOptionsDialog(List<CustomDateOption> customDateOptions)
        {
            CustomDateOptions = customDateOptions;

            InitializeComponent();
        }

        /// <summary>
        /// Execute when dialog is loaded.
        /// </summary>
        private void CustomOptionsDialog_Load(object sender, EventArgs e)
        {
            GlobalWindowManager.AddWindow(this);
            BannerImage.Image = BannerFactory.CreateBanner(BannerImage.Width, BannerImage.Height, BannerStyle.Default, Properties.Resources.Date_48x48, Text, "Custom password expiration options");
            CustomDateOptions.ForEach(o => CustomOptionsListBox.Items.Add(o));
        }

        /// <summary>
        /// Execute when dialog is closed.
        /// </summary>
        private void CustomOptionsDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalWindowManager.RemoveWindow(this);
        }

        /// <summary>
        /// Execute when the add button is clicked.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            CustomDateOptionDialog customDateOptionDialog = new CustomDateOptionDialog();
            UIUtil.ShowDialogAndDestroy(customDateOptionDialog);
            if (customDateOptionDialog.DialogResult == DialogResult.OK)
            {
                CustomDateOptions.Add(customDateOptionDialog.CustomDateOption);
                CustomDateOptions.Sort((x, y) => string.Compare(x.ToString(), y.ToString()));
            }
            CustomOptionsListBox.Items.Clear();
            CustomDateOptions.ForEach(o => CustomOptionsListBox.Items.Add(o));
        }

        /// <summary>
        /// Executes when the delete button is clicked.
        /// </summary>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            CustomDateOption option = CustomOptionsListBox.SelectedItem as CustomDateOption;
            if (option != null)
            {
                CustomDateOptions.Remove(option);
                CustomDateOptions.Sort((x, y) => string.Compare(x.ToString(), y.ToString()));
            }
            CustomOptionsListBox.Items.Clear();
            CustomDateOptions.ForEach(o => CustomOptionsListBox.Items.Add(o));
        }

        /// <summary>
        /// Close the dialog when the button is clicked.
        /// </summary>
        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
