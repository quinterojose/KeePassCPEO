﻿using KeePass.Forms;
using KeePass.Plugins;
using KeePass.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace KeePassCPEO
{
    /// <summary>
    /// Plugin implementation for KeePassCPEO
    /// </summary>
    public class KeePassCPEOExt : Plugin
    {
        private IPluginHost _host;

        private ToolStripSeparator _configSeparator;

        private ToolStripMenuItem _configMenuItem;

        /// <summary>
        /// Gets the list of available custom date options.
        /// </summary>
        /// <value>The list of available custom date options.</value>
        public List<CustomDateOption> CustomDateOptions { get; private set; }

        /// <summary>
        /// Gets the plugin update URL.
        /// </summary>
        /// <value>The plugin update URL.</value>
        public override string UpdateUrl
        {
            get
            {
                return Properties.Resources.UpdateUrl;
            }
        }

        /// <summary>
        /// Gets the icon to be displayed on the KeePass plugin list.
        /// </summary>
        /// <value>The icon to be displayed on the KeePass plugin list.</value>
        public override Image SmallIcon
        {
            get
            {
                return Properties.Resources.Date_16x16;
            }
        }

        /// <summary>
        /// Gets the path to the config file.
        /// </summary>
        /// <returns>The path to the config file.</returns>
        public static string GetConfigFilePath()
        {
            string configFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            configFolderPath = Path.Combine(configFolderPath, "KeePassCPEO");
            if (!Directory.Exists(configFolderPath))
                Directory.CreateDirectory(configFolderPath);
            return Path.Combine(configFolderPath, "KeePassCPEO.Config.xml");
        }

        /// <summary>
        /// Initializes the plugin.
        /// </summary>
        /// <param name="host">Reference to the <see cref="IPluginHost"/> object.</param>
        /// <returns>True if the plugin is initialized properly, false otherwise.</returns>
        public override bool Initialize(IPluginHost host)
        {
            _host = host;

            // Add handler to detect when a new window has been opened.
            GlobalWindowManager.WindowAdded += GlobalWindowManager_WindowAdded;

            string configFilePath = GetConfigFilePath();

            if (!File.Exists(configFilePath))
            {
                // Create sample dates.
                CustomDateOptions = new List<CustomDateOption>
                {
                    new CustomDateOption { Days = 31 },
                    new CustomDateOption { Days = 45 },
                    new CustomDateOption { Days = 180 }
                };
            }
            else
            {
                // Read config file.
                using (FileStream fileStream = new FileStream(configFilePath, FileMode.OpenOrCreate))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<CustomDateOption>), new XmlRootAttribute("CustomDateOptions"));
                    CustomDateOptions = serializer.Deserialize(fileStream) as List<CustomDateOption>;
                }
            }

            // Sort custom options
            CustomDateOptions.Sort((x, y) => string.Compare(x.ToString(), y.ToString()));

            // Add configuration menu option
            _configMenuItem = new ToolStripMenuItem("KeePassCPEO Options...");
            _configMenuItem.Click += PluginMenuItem_Click;
            _configMenuItem.Image = Properties.Resources.B16x16_Misc;

            _configSeparator = new ToolStripSeparator();
            _host.MainWindow.ToolsMenu.DropDownItems.Add(_configSeparator);
            _host.MainWindow.ToolsMenu.DropDownItems.Add(_configMenuItem);

            return true;
        }

        /// <summary>
        /// Terminates the plugin.
        /// </summary>
        public override void Terminate()
        {
            string configFilePath = GetConfigFilePath();

            // Save settings.
            using (FileStream fileStream = new FileStream(configFilePath, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<CustomDateOption>), new XmlRootAttribute("CustomDateOptions"));
                serializer.Serialize(fileStream, CustomDateOptions);
            }
        }

        private void GlobalWindowManager_WindowAdded(object sender, GwmWindowEventArgs e)
        {
            // Get the password entry form
            PwEntryForm entryForm = e.Form as PwEntryForm;

            if (entryForm != null && CustomDateOptions.Count > 0)
            {
                ToolStripSeparator separator = new ToolStripSeparator();
                entryForm.DefaultTimesContextMenu.Items.Add(new ToolStripSeparator());

                // Add custom date options menu items.                
                CustomDateOptions.ForEach(o =>
                {
                    ToolStripMenuItem customOptionMenuItem = new ToolStripMenuItem(o.ToString())
                    {
                        Tag = o
                    };
                    customOptionMenuItem.Click += CustomOptionMenuItem_Click;
                    entryForm.DefaultTimesContextMenu.Items.Add(customOptionMenuItem);
                });
            }
        }

        private void CustomOptionMenuItem_Click(object sender, EventArgs e)
        {
            // Getting a reference to the password entry form
            ToolStripMenuItem customOptionMenuItem = sender as ToolStripMenuItem;
            CustomDateOption option = customOptionMenuItem.Tag as CustomDateOption;
            PwEntryForm entryForm = ((ContextMenuStrip)(((ToolStripMenuItem)sender).Owner)).SourceControl.TopLevelControl as PwEntryForm;

            // Using reflection here because there is a very convenient method in PwEntryForm to use but it's set to private.
            MethodInfo setExpireIn = entryForm.GetType().GetMethod("SetExpireIn", BindingFlags.NonPublic | BindingFlags.Instance);

            // Set the date in the expiration date control
            setExpireIn.Invoke(entryForm, new object[] { option.Years, option.Months, option.Days }); // Years, Months, Days
        }

        private void PluginMenuItem_Click(object sender, EventArgs e)
        {
            CustomDateOptionsDialog optionsDialog = new CustomDateOptionsDialog(CustomDateOptions);
            UIUtil.ShowDialogAndDestroy(optionsDialog);
        }
    }
}