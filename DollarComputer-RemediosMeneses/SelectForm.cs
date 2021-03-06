﻿using System;
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
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            ProductInfoForm mf = new ProductInfoForm();
            mf.Show();
            this.Hide();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarComputersDBDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDBDataSet.Products);

        }
    }
}
