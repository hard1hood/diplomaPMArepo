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
            FormInsertInto f = new FormInsertInto();
            f.Show();
        }
    }
}
