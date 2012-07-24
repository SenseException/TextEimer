using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TextEimer.Windows.MenuItems
{
    public class Separator : MenuItem
    {
        public Separator()
        {
            this.toolStripItem = new ToolStripSeparator();
        }
    }
}
