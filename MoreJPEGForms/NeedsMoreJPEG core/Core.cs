using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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

        [DllImport("User32.dll")]
        static extern IntPtr GetDC(IntPtr hwnd);

        public void JPEGOnce()
        {
            using (Graphics g = Graphics.FromHdc(GetDC(IntPtr.Zero)))
            {
                ImageCodecInfo jpegEnc = GetEncoder(ImageFormat.Jpeg);
                EncoderParameters encoderParameters = new EncoderParameters(1);
                encoderParameters.Param[0] = new EncoderParameter(Encoder.Quality, 0L);
                MemoryStream memStream = new MemoryStream();

                Image screenCap = CaptureWindow();
                screenCap.Save(memStream, jpegEnc, encoderParameters);

                memStream.Position = 0;
                Image decoded = Image.FromStream(memStream);
                g.DrawImage(decoded, 0, 0);

                screenCap.Dispose();
                memStream.Dispose();
                decoded.Dispose();
            }
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

        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
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
