using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;


namespace TextEimer.Windows
{
    class ForegroundWindow
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool SetForegroundWindow(IntPtr hwnd);
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool SetForegroundWindow(HandleRef hWnd);
        
        private IntPtr foregroundWindow;

        /// <summary>
        /// A class handling the focus between the system windows and TextEimer
        /// </summary>
        public ForegroundWindow()
        {
            this.foregroundWindow = GetForegroundWindow();
        }

        /// <summary>
        /// gets the handle with the actual focus 
        /// </summary>
        /// <returns>The Handle with the actual focus</returns>
        public IntPtr GetFocusedWindow()
        {
            this.foregroundWindow = GetForegroundWindow();
            return this.foregroundWindow;
        }

        /// <summary>
        /// sets the focus to the handle of a control
        /// </summary>
        public void SetFocusedWindow()
        {
            SetForegroundWindow(this.foregroundWindow);
        }
        /// <summary>
        /// sets the focus to the handle of a control
        /// </summary>
        /// <param name="handle">a HandleRef Object which should get the focus</param>
        public void SetFocusedWindow(HandleRef handle)
        {
            SetForegroundWindow(handle);
        }
    }
}
