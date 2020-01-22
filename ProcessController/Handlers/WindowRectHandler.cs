using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessController.Handlers
{
    public class WindowRectHandler
    {
        private readonly IntPtr _hWnd;

        public WindowRectHandler(IntPtr hWnd) => _hWnd = hWnd;

        public Rect GetRect() => GetRect(_hWnd);
        public Rect GetRect(IntPtr hWnd)
        {
            External.GetWindowRect(hWnd, out Rect rect);
            return rect;
        }
    }
}
