using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputer_RemediosMeneses
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        Timer gmr;
        private void LogoPictureBox_Click(object sender, EventArgs e)
        {
            gmr = new Timer();
            gmr.Interval = 3000;
            gmr.Start();
            gmr.Tick += gmr_Tick;
        }

        private void gmr_Tick(object sender, EventArgs e)
        {
            gmr.Stop();
            StartForm mf = new StartForm();
            mf.Show();
            this.Hide();
        }
    }
}
