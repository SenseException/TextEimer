using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using TextEimer.Clipboard.Container.Type;

namespace TextEimer.Windows
{
    class NotifyIconMenu
    {
        private ContextMenuStrip notifyIconMenu;
        private ToolStripSeparator toolStripSeparator;
        private Dictionary<string, IType> items;

        /// <summary>
        /// Contructor of NotifyIconMenu class.
        /// This class handles the ContextMenuStrip functionality for the
        /// NotifyIcon in NotifyIconSymbol.
        /// </summary>
        /// <param name="contextMenuStrip">A ContextMenuStrip object for the clipboard history</param>
        public NotifyIconMenu(ContextMenuStrip contextMenuStrip)
        {
            this.notifyIconMenu = contextMenuStrip;
            this.AddControlMenuItems();
        }

        /// <summary>
        /// Click Event which exits TextEimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Getter for the containing ContextMenuStrip object
        /// </summary>
        public ContextMenuStrip contextMenuStrip
        {
            get
            {
                return this.notifyIconMenu;
            }
        }

        /// <summary>
        /// adds a new clipboard value to the items
        /// </summary>
        /// <param name="typeContainer">a type container</param>
        public void Add(IType typeContainer)
        {
            this.items.Add(typeContainer.Key, typeContainer);

            // TODO: check if the ContextMenuStrip can be build when the menu is called by ContextMenuStrip.Show
            this.notifyIconMenu.Items.Clear();
            this.BuildContextMenuStrip();
        }

        /// <summary>
        /// Adding additional options like exit button to the ContextMenuStrip
        /// </summary>
        private void AddControlMenuItems()
        {
            this.toolStripSeparator = new ToolStripSeparator();
            this.notifyIconMenu.Items.Add(this.toolStripSeparator);

            this.notifyIconMenu.Items.Add(new ToolStripMenuItem(
                "Beenden",
                null,
                new EventHandler(Quit_Click),
                "exit"
            ));
        }

        private void BuildContextMenuStrip()
        {
            int limitCounter = 1;
            int limit = 20;
            foreach (KeyValuePair<string, IType> item in this.items)
            {
                this.notifyIconMenu.Items.Add(new ToolStripMenuItem(
                    item.Value.MenuValue,
                    null,
                    new EventHandler(Quit_Click),
                    item.Key
                ));

                limitCounter++;
                if (limitCounter >= limit)
                {
                    break;
                }
            }

            this.AddControlMenuItems();
        }
    }
}
