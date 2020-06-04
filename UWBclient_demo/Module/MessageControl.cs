using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace UWBclient_demo
{
    class MessageControl
    {
        [DllImport("user32.dll")]
        public static extern int MessageBoxTimeoutA(IntPtr hwnd, string txt, string caption, int wtype, int wlange, int dwtimeout);//定时对话框

        [DllImport("user32.dll", EntryPoint = "FindWindow", CharSet = CharSet.Auto)]
        public extern static IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int PostMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        public const int WM_CLOSE = 0x10;
    }
}
