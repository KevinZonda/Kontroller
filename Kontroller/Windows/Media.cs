using System;
using System.Runtime.InteropServices;

namespace Kontroller.Windows
{
    public class Media
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern void keybd_event(byte virtualKey, byte scanCode, uint flags, IntPtr extraInfo);

        public static void Previous()
        {
            keybd_event(0xB1, 0, 0x0001, IntPtr.Zero);
            keybd_event(0xB1, 0, 0x0002, IntPtr.Zero);
        }

        public static void Next()
        {
            keybd_event(0xB0, 0, 0x0001, IntPtr.Zero);
            keybd_event(0xB0, 0, 0x0002, IntPtr.Zero);
        }

        public static void Stop()
        {
            keybd_event(0xB3, 0, 0x0001, IntPtr.Zero);
            keybd_event(0xB3, 0, 0x0002, IntPtr.Zero);
        }

        public static void Play() => Stop();
    }
}