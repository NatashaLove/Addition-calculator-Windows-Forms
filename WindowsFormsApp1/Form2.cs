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
    public partial class Form2 : Form
    {
        private decimal _n1, _n2;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(decimal n1, decimal n2)
        {
            //creates new form
            InitializeComponent();
            _n1 = n1;
            _n2 = n2;
            txtAnswer.Text = (_n1 + _n2).ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
