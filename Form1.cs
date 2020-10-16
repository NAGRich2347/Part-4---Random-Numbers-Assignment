using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_4___Random_Numbers_Assignment
{
    public partial class Form1 : Form
    {
        Random generator = new Random();

        int min, max;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMinimum_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMaximum_Click(object sender, EventArgs e)
        {

        }

        private void txtMinimum_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            min = Convert.ToInt32(txtMinimum.Text);
            max = Convert.ToInt32(txtMaximum.Text);

            txtOutput.Text = generator.NextDouble() + generator.Next(0,11) +"";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            min = Convert.ToInt32(txtMinimum.Text);
            max = Convert.ToInt32(txtMaximum.Text);

            txtOutput.Text = generator.Next(min, max) + "";
        }
    }
}
