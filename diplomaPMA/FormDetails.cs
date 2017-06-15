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
    public partial class FormDetails : Form
    {
        public FormDetails()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e) //draw a line after last param 
        {
            base.OnPaint(e);
            Graphics g;

            g = e.Graphics;

            Pen myPen = new Pen(Color.Black);
            myPen.Width = 2;
            g.DrawLine(myPen, 135, 318, 670, 318);

            //g.DrawLine(myPen, 1, 1, 45, 65);
        }
        private void FormDetails_Load(object sender, EventArgs e)
        {
            if (Data.flag == 1)
            {
                label5.Visible = false;
                label6.Visible = true;
                // label7.Visible=false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label13.Visible = true;


                double temp = Data.zberParamInt * Data.zberTermDouble;

                label13.Text = Data.chystkaParamInt.ToString();
                label1.Text = temp.ToString();
                label3.Text = Data.chystkaParamInt.ToString();
                label11.Text = Data.vsegoZerna.ToString();
            }
            else
            if (Data.flag==2)
            {
                label5.Visible = true;
                label6.Visible = false;
                // label7.Visible=false;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label13.Visible = false;
                label12.Visible = false;

                double temp = Data.zberParamInt * Data.zberTermDouble;

                label1.Text = Data.zberTermDouble.ToString();
                label3.Text = Data.chystkaPredInt.ToString();
                label7.Text = Data.ur.ToString();
                label9.Text = Data.costsPrediction.ToString();
                label11.Text = Data.vsegoZerna.ToString();
            }

            
            
          
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
