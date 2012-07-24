using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TextEimer.Windows.MenuItems
{
    abstract class MenuItem
    {
        protected ToolStripItem toolStripItem;

        public ToolStripItem getToolStripItem()
        {
            return this.toolStripItem;
        }
    }
}
