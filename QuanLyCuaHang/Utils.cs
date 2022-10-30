using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;


namespace QuanLyCuaHang
{
    internal class Kernel32 
    {
        /// <summary>
        /// Enable console
        /// </summary>
        /// <returns></returns>
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool AllocConsole();
    }

    internal class User32
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hwnd, int wmsg, int wpara, int lpara);

        /// <summary>
        /// Drag form<br/>
        /// Example: DragDrop(this.Handle)
        /// </summary>
        public static void DragDrop(IntPtr Handle)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }

    internal class Dwmapi
    {
        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        private static string ToBgr(Color c) => $"{c.B:X2}{c.G:X2}{c.R:X2}";

        /// <summary>
        /// dwmAttr border = 34 <br/>
        /// dwmAttr caption = 35<br/>
        /// dwmAttr text = 36 <br/>
        /// Example: ChangeColor(this.Handle, 35, Color.FromArgb(30, 0, 50))
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="dwmAttr"></param>
        /// <param name="color"></param>
        public static void ChangeColor(IntPtr handle, int dwmAttr, Color color)
        {
            int[] bgrColor = new int[] { int.Parse(ToBgr(color), NumberStyles.HexNumber) };
            DwmSetWindowAttribute(handle, dwmAttr, bgrColor, 4);
        }

        /// <summary>
        /// Dark Title Bar<br/>
        /// Example: DarkTitle(this.Handle)
        /// </summary>
        public static void DarkTitle(IntPtr handle)
        {
            if (DwmSetWindowAttribute(handle, 19, new[] { 1 }, 4) != 0)
                DwmSetWindowAttribute(handle, 20, new[] { 1 }, 4);
        }
    }
}