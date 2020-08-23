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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartANewOrder_Click(object sender, EventArgs e)
        {
            // Instantiated a new SelectForm object
            SelectForm mf = new SelectForm();

            // Display the SelectForm 
            mf.Show();

            // Hide the StartForm
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Method to exit the form
            Application.Exit();
        }

        private void OpenOrderButton_Click(object sender, EventArgs e)
        {
            // Instantiated a new ProductInfoForm
            ProductInfoForm mf = new ProductInfoForm();

            // A method to display the ProductInfoForm
            mf.Show();

            // A method to hide the StartForm 
            this.Hide();

            // Instantiated a new object for OpenFileDialog
            OpenFileDialog df = new OpenFileDialog();

            // Displays the DialogMessage
            df.ShowDialog();
        }
    }
}
