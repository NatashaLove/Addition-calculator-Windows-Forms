using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clearFields()
        {
            txtNumber1.Text = "";
            txtNumber2.Text = "";
            txtResolved.Text = "";
            txtErrors.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //before clearing - a confirmation message first:
            //if user clicks - yes
            if (MessageBox.Show("Are you sure you want to clear?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                clearFields();
            }
            else
            {
                MessageBox.Show("I will not clear the fields.");
            }
        }

        

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //decimal is like double, but more precise
            decimal number1 = 0, number2 = 0;
            bool good1 = false, good2 = false;

            //will clear the box with errors
            txtErrors.Text = "";

            //first number can't be blank
            if (String.IsNullOrWhiteSpace(txtNumber1.Text))
            {
                //concatenation - in case there's another error message - but this one will be the first
                txtErrors.Text += "First number cannot be blank.\n";
            }
            else if (!(Decimal.TryParse(txtNumber1.Text, out number1)))
            {
                txtErrors.Text += "First number is not valid.\n";
            }
            else
            {
                good1 = true;
            }

            //second number can't be blank
            if (String.IsNullOrWhiteSpace(txtNumber2.Text))
            {
                //concatenation - in case there's another error message - but this one will be the first
                txtErrors.Text += "Second number cannot be blank.\n";
            }
            else if (!(Decimal.TryParse(txtNumber2.Text, out number2)))
            {
                txtErrors.Text += "Second number is not valid.\n";
            }
            else
            {
                good2 = true;
            }

            if (good1&&good2)
            {
                txtResolved.Text = String.Format("{0}+{1}={2}", number1, number2, number1+number2);
            }
        }
    }
}
