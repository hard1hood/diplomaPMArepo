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
        private void MyForm_MouseClick(object sender, MouseEventArgs e)
        {
            Button btn = new Button
            {
                Location = e.Location, // e.Location - координаты мыши
                Visible = true,
                Text = "Some text"
            };
            Controls.Add(btn);
        }
        public Form1()
        {
            InitializeComponent();
            MouseClick += MyForm_MouseClick;
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
