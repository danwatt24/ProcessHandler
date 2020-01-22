using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessController.Handlers
{
    public class ForegroundHandler
    {
        private readonly IntPtr _hWnd;

        public ForegroundHandler(IntPtr hWnd) => _hWnd = hWnd;

        public bool BringToForeground() => BringToForeground(_hWnd);
        public bool BringToForeground(IntPtr hWnd) => External.SetForegroundWindow(hWnd);
    }
}
