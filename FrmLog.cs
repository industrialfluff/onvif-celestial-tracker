using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONVIFCelestialTracker
{
    public partial class FrmLog : Form
    {
        public FrmLog()
        {
            InitializeComponent();
        }

        private void FrmLog_Load(object sender, EventArgs e)
        {

        }

        public void Log(string s)
        {
            // Don't let the text get too long.
            if(txtLog.TextLength > 32000)
            {
                txtLog.Text.Remove(0, s.Length);
            }
            txtLog.Text += $"{DateTime.Now} {s}" + Environment.NewLine;
            txtLog.SelectionStart = txtLog.Text.Length;
            txtLog.ScrollToCaret();
        }
    }
}
