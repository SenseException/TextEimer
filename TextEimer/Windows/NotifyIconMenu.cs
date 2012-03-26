using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TextEimer.Windows
{
    class NotifyIconMenu
    {
        private ContextMenuStrip notifyIconMenu;

        public NotifyIconMenu(ContextMenuStrip contextMenuStrip)
        {
            this.notifyIconMenu = contextMenuStrip;
            this.AddControlMenuItems();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public ContextMenuStrip contextMenuStrip
        {
            get
            {
                return this.notifyIconMenu;
            }
        }

        private void AddControlMenuItems()
        {
            ToolStripSeparator toolStripSeparator = new ToolStripSeparator();
            this.notifyIconMenu.Items.Add(toolStripSeparator);

            this.notifyIconMenu.Items.Add(new ToolStripMenuItem(
                "Beenden",
                null,
                new EventHandler(Quit_Click),
                "Exit"
            ));
        }
    }
}
