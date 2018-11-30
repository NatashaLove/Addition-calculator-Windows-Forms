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

      
    }
}
