using ProcessController.Handlers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace ProcessController
{
    public class ProcessHandler
    {
        private ForegroundHandler _foreground;
        private WindowRectHandler _windowRect;
        private ScreenshotHandler _screenshot;
        private KeyboardHandler _keyboard;
        private MouseHandler _mouse;

        private ProcessHandler(IntPtr foregroundHWnd, IntPtr windowRectHWnd, IntPtr screenshotHWnd, IntPtr keyboardHWnd, IntPtr mouseHWnd)
        {
            _foreground = new ForegroundHandler(foregroundHWnd);
            _windowRect = new WindowRectHandler(windowRectHWnd);
            _screenshot = new ScreenshotHandler(screenshotHWnd);
            _keyboard = new KeyboardHandler(keyboardHWnd);
            _mouse = new MouseHandler(mouseHWnd);
        }

        public void BringToForeground()
        {
            _foreground.BringToForeground();
        }

        public Rect GetRect()
        {
            return _windowRect.GetRect();
        }

        public Bitmap Screenshot()
        {
            var rect = _windowRect.GetRect();
            return _screenshot.Take(rect);
        }

        public void SendKeysBackground(string keys)
        {
            _keyboard.SendKey(keys[0]);
        }

        public void ClickOnPoint(Point point)
        {
            _mouse.Click(point);
        }

        public static ProcessHandler GetProcess(string config)
        {
            var process = loadConfig(config);

            var mouse = IntPtr.Zero;
            if(process.Mouse != null)
            {
                mouse = getWindow(process.Mouse);
                if (mouse == IntPtr.Zero)
                    throw new Exception("Mouse target not found");
            }

            var keyboard = IntPtr.Zero;
            if (process.Keyboard != null)
            {
                keyboard = getWindow(process.Keyboard);
                if (keyboard == IntPtr.Zero)
                    throw new Exception("Keyboard target not found");
            }

            return null;// new ProcessHandler(mouse, keyboard);
        }

        private static Process loadConfig(string config)
        {
            var path = $"Configs/{config}.json";
            if (!File.Exists(path))
                throw new FileNotFoundException($"Path '{path}' was not found");

            using (var sr = new StreamReader(path))
            {
                var content = sr.ReadToEnd();
                var process = Newtonsoft.Json.JsonConvert.DeserializeObject<Process>(content);
                return process;
            }
        }

        private static IntPtr getWindow(Target t)
        {
            string c = null;
            string w = null;
            var hWnd = IntPtr.Zero;
            for (var target = t; target.Child != null; target = target.Child)
            {
                if (target.IsClass)
                    c = target.Name;
                else
                    w = target.Name;
                hWnd = External.FindWindowEx(hWnd, (IntPtr)null, c, w);
                if (hWnd == IntPtr.Zero)
                    break;
            }

            return hWnd;
        }
    }
}
