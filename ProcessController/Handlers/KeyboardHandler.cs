using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProcessController.Handlers
{
    public class KeyboardHandler
    {
        private readonly IntPtr _hWnd;

        public KeyboardHandler(IntPtr hWnd) => _hWnd = hWnd;

        public bool SendKey(char ch) => SendKey(_hWnd, ch);
        public bool SendKey(IntPtr hWnd, char ch)
        {
            var lParamDown = keyToLParam(ch, false);
            var lParamUp = keyToLParam(ch, true);
            var wParam = (UIntPtr)External.VkKeyScan(ch);

            if(External.PostMessage(hWnd, External.WM_KEYDOWN, wParam, lParamDown))
                return External.PostMessage(hWnd, External.WM_KEYUP, wParam, lParamUp);
            return false;
        }

        // TODO: send string

        private static IntPtr keyToLParam(char c, bool keyUp)
        {
            var state = Convert.ToUInt32(keyUp);
            var helper = new Helper { Value = External.VkKeyScan(c) };
            var vkc = helper.Low;
            var shift = helper.High;

            uint repeatCount = 1;
            uint scanCode = External.MapVirtualKey(vkc, External.MAPVK_VK_TO_VSC);
            uint extended = 0;
            uint context = 0;
            uint previousState = state;
            uint transition = state;

            uint lParam = repeatCount
                | (scanCode << 16)
                | (extended << 24)
                | (context << 29)
                | (previousState << 30)
                | (transition << 31);
            return unchecked((IntPtr)lParam);
        }

        [StructLayout(LayoutKind.Explicit)]
        private struct Helper
        {
            [FieldOffset(0)] public short Value;
            [FieldOffset(0)] public byte Low;
            [FieldOffset(1)] public byte High;
        }
    }
}
