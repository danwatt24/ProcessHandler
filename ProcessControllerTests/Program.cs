using ProcessController;
using ProcessController.Configs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessControllerTests
{
    class Program
    {
        static void Main(string[] args)
        {
            var process = ProcessHandler.GetProcess(Known.Nox);
            //testBringToFront(process);
            //testKeysForeground(process, Key.A, Key.B, Key.C, Key.D);
            //testScreenshot(process);
            //testGetWindowRect(process);
            testClick(process);
            //testKeysBackground(process, "a");

            Console.ReadKey();
        }

        static void testKeysBackground(ProcessHandler process, string keys)
        {
            Console.WriteLine("sending keys {0} to app", keys);
            process.SendKeysBackground(keys);
            Console.WriteLine("Keys {0} were sent", keys);
        }

        static void testClick(ProcessHandler process)
        {
            Console.WriteLine("getting rect");
            var rect = process.GetRect();
            var point = new Point(rect.Width / 2, rect.Height / 2);
            Console.WriteLine("Point is: {0}", point);
            Console.WriteLine("Clicking center");
            process.ClickOnPoint(point);
            Console.WriteLine("center should have been clicked");
        }

        static void testGetWindowRect(ProcessHandler process)
        {
            Console.WriteLine("getting rect");
            var result = process.GetRect();
            Console.WriteLine("result: {0}", result);
        }

        static void testScreenshot(ProcessHandler process)
        {
            Console.WriteLine("taking screen shot");
            var image = process.Screenshot();
            Console.WriteLine("saving to executing directory as test.png");
            image.Save("test.png", ImageFormat.Png);
        }

        //static void testKeysForeground(ProcessHandler process, params Key[] keys)
        //{
        //    Console.WriteLine("sending keys {0} to app", keys);
        //    process.SendKeysForeground(keys);
        //    Console.WriteLine("Keys {0} was sent", keys);
        //}

        static void testBringToFront(ProcessHandler process)
        {
            process.BringToForeground();
        }
    }
}
