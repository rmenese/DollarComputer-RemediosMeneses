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
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void CancelButton2_Click(object sender, EventArgs e)
        {
            // This method terminates ProductInfoForm
            this.Hide();
        }

        private void NextButton2_Click(object sender, EventArgs e)
        {
            // Instantiated a new OrderForm object
            OrderForm mf = new OrderForm();

            // This method display the OrderForm
            mf.Show();

            // Instantiated a new SelectForm object
            SelectForm nf = new SelectForm();

            // Stop or hide the SelectForm
            nf.Hide();
        }

        
    }
}
