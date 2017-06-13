using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diplomaPMA
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            FormClosed += Form2_Closed;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";

            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }

        protected void Form2_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCalculation f = new FormCalculation();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrediction f = new FormPrediction();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInsertIntoPrognoz f = new FormInsertIntoPrognoz();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //this.Hide();
            FormSelectPrognoz f = new FormSelectPrognoz();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAlterTsiny f = new FormAlterTsiny();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAlterZberigannya f = new FormAlterZberigannya();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormSelectTsiny f = new FormSelectTsiny();
            f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormSelectZberigannya f = new FormSelectZberigannya();
            f.Show();
        }
    }
}
