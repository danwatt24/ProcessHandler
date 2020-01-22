using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessController.Handlers
{
    public class ScreenshotHandler
    {
        private readonly IntPtr _hWnd;
        private readonly int _nFlags;

        public ScreenshotHandler(IntPtr hWnd, int nFlags = 0)
        {
            _hWnd = hWnd;
            _nFlags = nFlags;
        }

        public Bitmap Take(Rect rect) => Take(rect, _hWnd, _nFlags);
        public Bitmap Take(Rect rect, IntPtr hWnd, int nFlags)
        {
            var image = new Bitmap(rect.Width, rect.Height);
            using (var gfx = Graphics.FromImage(image))
            {
                var ptr = gfx.GetHdc();
                External.PrintWindow(hWnd, ptr, nFlags);
                gfx.ReleaseHdc(ptr);
            }

            return image;
        }
    }
}
