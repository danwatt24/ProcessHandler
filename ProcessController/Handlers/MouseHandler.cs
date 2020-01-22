using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ProcessController.Handlers
{
    public class MouseHandler
    {
        private readonly IntPtr _hWnd;

        public MouseHandler(IntPtr hWnd) => _hWnd = hWnd;

        public bool Click(Point p) => Click(_hWnd, p);
        public bool Click(IntPtr hWnd, Point p)
        {
            var lParam = (IntPtr)((p.Y << 16) | (p.X & 0xffff));
            var wParamDown = (UIntPtr)1;
            var wParamUp = (UIntPtr)0;

            if(External.PostMessage(hWnd, External.WM_LBUTTONDOWN, wParamDown, lParam))
                return External.PostMessage(hWnd, External.WM_LBUTTONUP, wParamUp, lParam);
            return false;
        }
    }
}
