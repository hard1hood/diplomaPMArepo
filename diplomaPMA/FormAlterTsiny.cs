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
    public partial class FormAlterTsiny : Form
    {
        public FormAlterTsiny()
        {
            InitializeComponent();
            FormClosed += FormAT;
        }
        protected void FormAT(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void FormAlterTsiny_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormSelectTsiny f = new FormSelectTsiny();
            f.Show();

        }
    }
}
