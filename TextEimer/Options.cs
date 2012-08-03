using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

using TextEimer.Config;

namespace TextEimer
{
    public partial class Options : Form
    {
        private Settings settings;
        
        private bool loggingOn;
        private bool orderDesc;
        private int menuItemAmount;
        private string autostartFile;

        public Options(Settings settings)
        {
            InitializeComponent();
            this.settings = settings;
            this.autostartFile = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\textEimer.url";
            this.init();
            this.initAbout();
        }

        // TODO add validation of config values
        private void init()
        {
            if (this.settings.LoggingOn)
            {
                this.checkBoxLoggingOn.Checked = true;
                this.loggingOn = true;
            }
            else
            {
                this.checkBoxLoggingOn.Checked = false;
                this.loggingOn = false;
            }

            if (!this.settings.OrderDesc)
            {
                this.radioOrderDesc1.Checked = true;
                this.orderDesc = false;
            }
            if (this.settings.OrderDesc)
            {
                this.radioOrderDesc2.Checked = true;
                this.orderDesc = true;
            }

            int value = this.settings.MenuItemAmount;
            this.trackBarMenuItemAmount.Value = value;
            this.menuItemAmount = value;
            this.labelTrackBarValue.Text = value.ToString();

            this.ChangeAutostartText();
        }

        private void initAbout()
        {
            Assembly entryAssembly = Assembly.GetExecutingAssembly();

            this.labelProgramName.Text += Environment.NewLine + Application.ProductName;
            this.textBoxDescription.Text = this.AssemblyDescription;
            this.labelVersion.Text += Environment.NewLine + Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.labelAuthor.Text += Environment.NewLine + this.AssemblyCopyright;
        }

        #region tab1
        /// <summary>
        /// closes the form without saving settings
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">EventArgs object</param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// saves the settings and closes the form
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">EventArgs object</param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.settings.MenuItemAmount = this.menuItemAmount;
            this.settings.OrderDesc = this.orderDesc;
            this.settings.LoggingOn = this.loggingOn;
        	this.settings.Save();
            this.Close();
        }

        /// <summary>
        /// sets the LoggingOn Setting on change
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">EventArgs object</param>
        private void checkBoxLoggingOn_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxLoggingOn.Checked)
            {
                this.loggingOn = true;
            }
            else
            {
                this.loggingOn = false;
            }
        }

        /// <summary>
        /// sets the OrderDesc setting to false
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">EventArgs object</param>
        private void radioOrderDesc1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioOrderDesc1.Checked)
            {
                this.orderDesc = false;
            }
        }

        /// <summary>
        /// sets the OrderDesc setting to true
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">EventArgs object</param>
        private void radioOrderDesc2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioOrderDesc2.Checked)
            {
                this.orderDesc = true;
            }
        }

        /// <summary>
        /// sets the MenuItemAmount setting to its selected value
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">EventArgs object</param>
        private void trackBarMenuItemAmount_Scroll(object sender, EventArgs e)
        {
            int value = this.trackBarMenuItemAmount.Value;
            this.menuItemAmount = value;
            this.labelTrackBarValue.Text = value.ToString();
        }

        /// <summary>
        /// create Autostart Shortcut
        /// </summary>
        private void AddToAutostart()
        {
            using (StreamWriter writer = new StreamWriter(this.autostartFile))
            {
                string app = System.Reflection.Assembly.GetExecutingAssembly().Location;
                writer.WriteLine("[InternetShortcut]");
                writer.WriteLine("URL=file:///" + app);
                writer.WriteLine("IconIndex=0");
                string icon = app.Replace('\\', '/');
                writer.WriteLine("IconFile=" + icon);
                writer.Flush();
            }
        }

        private void ChangeAutostartText()
        {
            if (File.Exists(this.autostartFile))
            {
                this.buttonAutostart.Text = "Automatischer Start entfernen";
            }
            else
            {
                this.buttonAutostart.Text = "Automatischer Start hinzufügen";
            }
        }

        private void buttonAutostart_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(this.autostartFile))
                {
                    DialogResult dialog = MessageBox.Show("Soll " + Application.ProductName + " aus dem Autostart entfernt werden?",
                        "Autostart", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (DialogResult.Yes == dialog)
                    {
                        File.Delete(this.autostartFile);
                        MessageBox.Show(Application.ProductName + " wurde aus dem Autostart entfernt.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("Soll " + Application.ProductName + " beim Systemstart mitgestartet werden?",
                        "Autostart", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (DialogResult.Yes == dialog)
                    {
                        this.AddToAutostart();
                        MessageBox.Show(Application.ProductName + " wurde unter Autostart eingetragen.", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                this.ChangeAutostartText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region About
        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }
        #endregion

    }
}
