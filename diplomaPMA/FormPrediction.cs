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
    public partial class FormPrediction : Form
    {
        public FormPrediction()
        {
            InitializeComponent();
            FormClosed += FormPrediction_Closed;
        }

        private void FormPrediction_Load(object sender, EventArgs e)
        {

        }
        protected void FormPrediction_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //FormResults f = new FormResults();
            //f.Show();
            label1.Text = Data.combobox1CalculateValue;
            label4.Text = Data.Costs.ToString();
        }
    }
}
