using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using TextEimer.Clipboard.Container.Type;
using TextEimer.Log;
using TextEimer.Config;
using Menu = TextEimer.Windows.MenuItems;
using Clip = System.Windows.Forms.Clipboard;

namespace TextEimer.Windows
{
    class NotifyIconMenu
    {
        private ForegroundWindow foregroundWindow = null;
        private ContextMenuStrip notifyIconMenu;
        private Settings settings;
        private List<IType> items;
        private List<Menu.MenuItem> menuItem;
        private Writer logWriter = null;

        /// <summary>
        /// Contructor of NotifyIconMenu class.
        /// This class handles the ContextMenuStrip functionality for the
        /// NotifyIcon in NotifyIconSymbol.
        /// </summary>
        /// <param name="contextMenuStrip">A ContextMenuStrip object for the clipboard history</param>
        public NotifyIconMenu(ContextMenuStrip contextMenuStrip, Settings settings)
        {
            this.notifyIconMenu = contextMenuStrip;
            this.settings = settings;

            this.items = new List<IType>();
            this.menuItem = new List<Menu.MenuItem>();
            this.notifyIconMenu.KeyUp += SelectedToolStripItem_KeyUp;

        }

        /// <summary>
        /// Click event for ContextMenuStrip items to load and paste new clipboard value from list
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">Event Arguments</param>
        private void Paste_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem) sender;
            this.AddToClipboard(clickedItem, true);
        }

        /// <summary>
        /// handles special keys on a selected ToolStripItem
        /// </summary>
        /// <param name="sender">sender object of eventhandler</param>
        /// <param name="e">event aruments of eventhandler</param>
        private void SelectedToolStripItem_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.Enter)
            {
                foreach (ToolStripItem item in this.notifyIconMenu.Items)
                {
                    if (item.Selected)
                    {
                        if (this.Contains(item.Name))
                        {
                            this.AddToClipboard(item, false);
                            this.notifyIconMenu.Close(ToolStripDropDownCloseReason.Keyboard);
                        }
                        break;
                    }
                }
            }
            else if (e.KeyCode == Keys.Delete)
            {
                foreach (ToolStripItem item in this.notifyIconMenu.Items)
                {
                    if (item.Selected)
                    {
                        // check if the item exists in items list
                        if (this.Contains(item.Name))
                        {
                            this.RemoveByKey(item.Name);

                            // if ToolStripItem is not in Control element then delete ToolStripItem
                            if (this.notifyIconMenu.Items.ContainsKey(item.Name))
                            {
                                this.notifyIconMenu.Items.RemoveByKey(item.Name);
                            }
                        }
                        break;
                    }
                }
            }
        }

        private void AddToClipboard(ToolStripItem clickedItem, bool isPasteActive)
        {
            string key = clickedItem.Name;

            if (this.Contains(key))
            {
                IType typeContainer = this.FindByKey(key);
                typeContainer.AddValueToClipboard();
                if (null != this.foregroundWindow)
                {
                    this.foregroundWindow.SetFocusedWindow();
                }

                if (isPasteActive)
                {
                    this.PasteValue();
                }
            }
        }

        /// <summary>
        /// search and returns a Type Container from the List by its key name
        /// </summary>
        /// <param name="key">IType key name of the list element</param>
        /// <returns>A Type Container of the interface IType</returns>
        private IType FindByKey(string key)
        {
            IType typeContainer = null;
            try
            {
                IEnumerable<IType> resultList = this.items.Where<IType>(type => type.Key == key);
                if (resultList.Count() > 0)
                {
                    typeContainer = resultList.Single<IType>();
                }
            }
            catch (Exception e)
            {
                this.WriteLog(e.Message, e);
            }

            return typeContainer;
        }

        /// <summary>
        /// removes an element from the list by its IType key name
        /// </summary>
        /// <param name="key">IType key name of the list element</param>
        private void RemoveByKey(string key)
        {
            try
            {
                int index = this.items.FindIndex(type => type.Key == key);
                this.items.RemoveAt(index);
            }
            catch (Exception e)
            {
                this.WriteLog(e.Message, e);
            }
        }

        /// <summary>
        /// checks if a IType key name is in the list
        /// </summary>
        /// <param name="key">IType key name of the list element</param>
        /// <returns>returns true id key exists. Else it returns false. 
        /// In case of an error it also returns false</returns>
        private bool Contains(string key)
        {
            bool containsKey = false;
            try
            {
                IType typeContainer = this.FindByKey(key);
                if (null != typeContainer && typeContainer.Key == key)
                {
                    containsKey = true;
                }
            }
            catch (Exception e)
            {
                this.WriteLog(e.Message, e);
            }

            return containsKey;
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
        /// The foreground window class used for getting the last focused IntPtr.
        /// </summary>
        public ForegroundWindow FocusHandler
        {
            set
            {
                this.foregroundWindow = value;
            }
            get
            {
                return this.foregroundWindow;
            }
        }

        public Writer LogWriter
        {
            get
            {
                return this.logWriter;
            }
            set
            {
                this.logWriter = value;
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
                //remove item if same typeContainer exists in list
                if (this.Contains(typeContainer.Key))
                {
                    this.RemoveByKey(typeContainer.Key);
                }

                this.items.Add(typeContainer);

                // remove oldest entry if count of items is bigger than the defined limit
                if (this.items.Count > this.settings.MenuItemAmount)
                {
                    this.items.Remove(this.items.First());
                }
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
            foreach (Menu.MenuItem item in this.menuItem)
            {
                this.notifyIconMenu.Items.Add(item.GetToolStripItem());
            }
        }

        public void AddMenuItem(Menu.MenuItem menuItem)
        {
            try
            {
                this.menuItem.Add(menuItem);
            }
            catch (Exception e)
            {
                this.WriteLog(e.Message, e);
            }
        }

        /// <summary>
        /// builds the ContextMenuStrip with the clipboard value history and the Control Items
        /// </summary>
        public void BuildContextMenuStrip()
        {
            try
            {
                this.notifyIconMenu.Items.Clear();

                ToolStripMenuItem currentItem = null;
                List<IType> items = this.items;
                string latestItemKey = "";

                if (items.Count > 0)
                {
                    latestItemKey = items.Last().Key;
                }

                if (this.settings.OrderDesc)
                {
                    items.Reverse();
                }

                foreach (IType item in items)
                {
                    currentItem = new ToolStripMenuItem(
                        item.MenuValue,
                        null,
                        new EventHandler(Paste_Click),
                        item.Key
                    );

                    this.notifyIconMenu.Items.Add(currentItem);

                    if (latestItemKey == item.Key)
                    {
                        currentItem.Select();
                    }
                }

                this.AddControlMenuItems();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WriteLog(string message, Exception e)
        {
            if (null != this.logWriter)
            {
                this.logWriter.Write(e.Message, e);
            }
        }
    }
}
