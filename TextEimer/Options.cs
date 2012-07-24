using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using TextEimer.Config;

namespace TextEimer
{
    public partial class Options : Form
    {
        private Settings settings;

        public Options(Settings settings)
        {
            InitializeComponent();
            this.settings = settings;
            this.init();
        }

        // TODO add validation of config values
        private void init()
        {
            if (this.settings.LoggingOn)
            {
                this.checkBoxLoggingOn.Checked = true;
            }
            else
            {
                this.checkBoxLoggingOn.Checked = false;
            }

            if (!this.settings.OrderDesc)
            {
                this.radioOrderDesc1.Checked = true;
            }
            if (this.settings.OrderDesc)
            {
                this.radioOrderDesc2.Checked = true;
            }

            this.trackBarMenuItemAmount.Value = this.settings.MenuItemAmount;

        }

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
                this.settings.LoggingOn = true;
            }
            else
            {
                this.settings.LoggingOn = false;
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
                this.settings.OrderDesc = false;
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
                this.settings.OrderDesc = true;
            }
        }

        /// <summary>
        /// sets the MenuItemAmount setting to its selected value
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">EventArgs object</param>
        private void trackBarMenuItemAmount_Scroll(object sender, EventArgs e)
        {
            this.settings.MenuItemAmount = this.trackBarMenuItemAmount.Value;
        }
    }
}
