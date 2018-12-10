using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace NeedsMoreJPEG_core
{
    public class Core : IMoreJPEG
    {
        private int ScreenHeight { get; set; }
        private int ScreenWidth { get; set; }

        public Core()
        {
            
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
