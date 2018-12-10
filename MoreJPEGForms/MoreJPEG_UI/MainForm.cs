using NeedsMoreJPEG_core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoreJPEG_UI
{
    public partial class MainForm : Form
    {
        private readonly IMoreJPEG MoreJPEG;

        public MainForm(IMoreJPEG moreJPEG)
        {
            MoreJPEG = moreJPEG;
            InitializeComponent();
        }
    }
}
