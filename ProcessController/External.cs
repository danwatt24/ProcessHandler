using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProcessController
{
    public static class External
    {
        #region constants
        public const int WM_LBUTTONDOWN = 0x0201;
        public const int WM_LBUTTONUP = 0x0202;

        public const int MAPVK_VK_TO_VSC = 0x0;
        public const int WM_KEYDOWN = 0x0100;
        public const int WM_KEYUP = 0x0101;
        #endregion

        #region calls
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindowEx(IntPtr hWndParent, IntPtr hWndChildAfter, string lpctClass, string lpszWindow);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PostMessage(IntPtr hWnd, uint wMsg, UIntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern short VkKeyScan(char c);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern uint MapVirtualKey(uint uCode, uint uMapType);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool PrintWindow(IntPtr hWnd, IntPtr hdcBlt, int nFlags);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowRect(IntPtr hWnd, out Rect lpRect);
        #endregion
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Rect
    {
        public int Left { get; set; }
        public int Top { get; set; }
        public int Right { get; set; }
        public int Bottom { get; set; }

        public int Width { get { return Right - Left; } }
        public int Height { get { return Bottom - Top; } }

        public string ToString(string format = null)
        {
            if (format == "dims")
                return string.Format("{{ Width={0}, Height={1} }}", Width, Height);

            return string.Format("{{ Left={0}, Top={1}, Right={2}, Bottom={3} }}", Left, Top, Right, Bottom);
        }
    }
}
