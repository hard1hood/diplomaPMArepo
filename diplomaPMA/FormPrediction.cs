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
    }
}
