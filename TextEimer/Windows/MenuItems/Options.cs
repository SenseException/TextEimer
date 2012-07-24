using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using TextEimer.Config;

namespace TextEimer.Windows.MenuItems
{
    public class Options : MenuItem
    {
        private Settings settings;
        
        public Options(string text, Settings settings)
        {
            this.settings = settings;
            
            this.toolStripItem = new ToolStripMenuItem(
                text,
                null,
                new EventHandler(OpenOptions_Click),
                "options"
            );
        }
        
        /// <summary>
        /// Opens the Options Window
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">Event Arguments</param>
        private void OpenOptions_Click(object sender, EventArgs e)
        {
            TextEimer.Options options = new TextEimer.Options(this.settings);
            options.Show();
        }
    }
}
