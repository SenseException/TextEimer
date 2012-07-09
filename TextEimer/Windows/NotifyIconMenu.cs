using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using TextEimer.Clipboard.Container.Type;
using Clip = System.Windows.Forms.Clipboard;

namespace TextEimer.Windows
{
    class NotifyIconMenu
    {
        private ForegroundWindow foregroundWindow;
        private ContextMenuStrip notifyIconMenu;
        private ToolStripSeparator toolStripSeparator;
        private Dictionary<string, IType> items;
        private int limit = 4; // TODO: max. items for ContextMenuStrip/Dictionary<string, IType>. Will be later replaced by config value

        /// <summary>
        /// Contructor of NotifyIconMenu class.
        /// This class handles the ContextMenuStrip functionality for the
        /// NotifyIcon in NotifyIconSymbol.
        /// </summary>
        /// <param name="contextMenuStrip">A ContextMenuStrip object for the clipboard history</param>
        public NotifyIconMenu(ContextMenuStrip contextMenuStrip, ForegroundWindow foregroundWindow)
        {
            this.notifyIconMenu = contextMenuStrip;
            this.foregroundWindow = foregroundWindow;
            this.items = new Dictionary<string, IType>();
            this.notifyIconMenu.KeyUp += DeleteItem_KeyUp;
            this.BuildContextMenuStrip();
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

        private void Paste_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem) sender;
            string key = clickedItem.Name;

            if (this.items.ContainsKey(key))
            {
                this.items[key].AddValueToClipboard();
                this.foregroundWindow.SetFocusedWindow();
                this.PasteValue();
            }
        }

        /// <summary>
        /// deletes an item from the TextEimer item list with the "del" resp "entf" keyboard key
        /// </summary>
        /// <param name="sender">sender object of eventhandler</param>
        /// <param name="e">event aruments of eventhandler</param>
        private void DeleteItem_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                foreach (ToolStripItem item in this.notifyIconMenu.Items)
                {
                    if (item.Selected)
                    {
                        bool itemExists = false;
                        // check if the item exists in items list
                        if (this.items.ContainsKey(item.Name))
                        {
                            itemExists = this.items.Remove(item.Name);
                        }

                        // if ToolStripItem is not a Control element then delete ToolStripItem
                        if (itemExists)
                        {
                            this.notifyIconMenu.Items.RemoveByKey(item.Name);
                        }
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Paste the clipboard value
        /// </summary>
        private void PasteValue()
        {
            SendKeys.Send("^v");
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
        /// <param name="typeContainer">a type container with clipboard value</param>
        public void Add(IType typeContainer)
        {
            try
            {
                // remove item if same typeContainer exists in list
                if (this.items.ContainsKey(typeContainer.Key))
                {
                    this.items.Remove(typeContainer.Key);
                }

                this.items.Add(typeContainer.Key, typeContainer);

                // remove oldest entry if count of items is bigger than the defined limit
                if (this.items.Count > this.limit)
                {
                    KeyValuePair<string, IType> firstItem = this.items.First();
                    if (this.items.ContainsKey(firstItem.Key))
                    {
                        this.items.Remove(firstItem.Key);
                    }
                }

                // TODO: check if the ContextMenuStrip can be build when the menu is called by ContextMenuStrip.Show
                this.BuildContextMenuStrip();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        /// <summary>
        /// builds the ContextMenuStrip with the clipboard value history and the Control Items
        /// </summary>
        private void BuildContextMenuStrip()
        {
            try
            {
                this.notifyIconMenu.Items.Clear();

                int limitCounter = 1;
                ToolStripMenuItem currentItem = null;

                foreach (KeyValuePair<string, IType> item in this.items)
                {
                    currentItem = new ToolStripMenuItem(
                        item.Value.MenuValue,
                        null,
                        new EventHandler(Paste_Click),
                        item.Key
                    );

                    this.notifyIconMenu.Items.Add(currentItem);

                    limitCounter++;
                    if (limitCounter >= this.limit)
                    {
                        break;
                    }
                }

                this.AddControlMenuItems();
                if (null != currentItem)
                {
                    currentItem.Select();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
