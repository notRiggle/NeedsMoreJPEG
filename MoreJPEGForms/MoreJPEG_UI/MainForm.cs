using NeedsMoreJPEG_core;
using System;
using System.Windows.Forms;

namespace MoreJPEG_UI
{
    public partial class MainForm : Form
    {
        private readonly IMoreJPEG MoreJPEG;

        public MainForm(IServiceProvider serviceProvider)
        {
            try
            {
                MoreJPEG = (IMoreJPEG)serviceProvider.GetService(typeof(IMoreJPEG));
                InitializeComponent();
            }
            catch (Exception e)
            {
                NLog.LogManager.GetCurrentClassLogger().Error(e, "Error occured while initialising the main form");
#if DEBUG
                throw;
#endif
            }
        }

        private void ContJPEG_click(object sender, EventArgs e)
        {

        }

        private void JPEGOnce_click(object sender, EventArgs e)
        {
            if (!long.TryParse(JPEGLevel.Text, out long jpegQuality))
            {
                MessageBox.Show("The value must be a long!", "Unexpected text", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MoreJPEG.JPEGOnce(jpegQuality);
            Test.Text = MoreJPEG.Test();
        }
    }
}
