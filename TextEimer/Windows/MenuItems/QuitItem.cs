using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace TextEimer.Windows.MenuItems
{
    public class QuitItem : MenuItem
    {
        public QuitItem(string name, string text)
        {
            this.toolStripItem = new ToolStripMenuItem(
                text,
                null,
                new EventHandler(Quit_Click),
                name
            );
        }
        
        /// <summary>
        /// Click Event which exits TextEimer
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">Event Arguments</param>
        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
