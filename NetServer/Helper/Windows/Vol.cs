using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Kontroller.Helper.Windows
{
    public static class Vol
    {
        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0x0a0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x090000;
        private const int WM_APPCOMMAND = 0x319;

        private static Process _p = Process.GetCurrentProcess();

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessageW(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

        public static void Up()
        {
            SendMessageW(_p.Handle, WM_APPCOMMAND, _p.Handle, (IntPtr)APPCOMMAND_VOLUME_UP);
        }

        public static void Down()
        {
            SendMessageW(_p.Handle, WM_APPCOMMAND, _p.Handle, (IntPtr)APPCOMMAND_VOLUME_DOWN);
        }

        public static void Mute()
        {
            SendMessageW(_p.Handle, WM_APPCOMMAND, _p.Handle, (IntPtr)APPCOMMAND_VOLUME_MUTE);
        }
    }
}