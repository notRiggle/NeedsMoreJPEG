using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using System.Runtime.InteropServices;

namespace NeedsMoreJPEG_core
{
    public class Core : IMoreJPEG
    {
        private int ScreenHeight { get; set; }
        private int ScreenWidth { get; set; }

        public Core()
        {
            UpdateScreenBounds();
        }

        public void JPEGOnce()
        {
            
        }

        Image CaptureWindow()
        {
            var handle = User32.GetDesktopWindow();
            IntPtr hdcSrc = User32.GetWindowDC(handle);

            IntPtr hdcDest = GDI32.CreateCompatibleDC(hdcSrc);
            IntPtr hBitmap = GDI32.CreateCompatibleBitmap(hdcSrc, ScreenWidth, ScreenHeight);
            IntPtr hOld = GDI32.SelectObject(hdcDest, hBitmap);

            GDI32.BitBlt(hdcDest, 0, 0, ScreenWidth, ScreenHeight, hdcSrc, 0, 0, GDI32.SRCCOPY);
            GDI32.SelectObject(hdcDest, hOld);
            GDI32.DeleteDC(hdcDest);
            User32.ReleaseDC(handle, hdcSrc);

            Image img = Image.FromHbitmap(hBitmap);
            GDI32.DeleteObject(hBitmap);
            return img;
        }

        public void UpdateScreenBounds()
        {
            var windowRect = new User32.Rectangle();
            User32.GetWindowRect(User32.GetDesktopWindow(), ref windowRect);
            int ScreenWidth = windowRect.right - windowRect.left;
            int ScreenHeight = windowRect.bottom - windowRect.top;
        }

        public string Test()
        {
            return "Test successful";
        }

        public void CrashTest()
        {
            throw new Exception();
        }
    }
}
