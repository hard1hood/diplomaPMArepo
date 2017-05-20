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
    public partial class Form1 : Form
    {

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();          
            Form2 f = new Form2();
            f.Show();
        }
        public Form1()
        {
            InitializeComponent();
            MouseClick += Form1_MouseClick;
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}
