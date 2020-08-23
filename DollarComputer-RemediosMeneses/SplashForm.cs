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

        private void SplashForm_Load(object sender, EventArgs e)
        {
            // Start method to begin the Splashscreen
            Timer.Start();
        }
        
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Stop method to stop the Splashscreen
            Timer.Stop();
            
            // Instantiate a new StartForm object 
            StartForm mf = new StartForm();

            // A method to show the SplashForm
            mf.Show();

            // A method to hide the SplashForm
            this.Hide();
        }

    }
}
