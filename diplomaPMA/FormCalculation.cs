using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace diplomaPMA
{

    public partial class FormCalculation : Form
    {

        MySqlConnection con = new MySqlConnection("user id=root;password=oracle;server=localhost;database=diploma;");

        public FormCalculation()
        {
            InitializeComponent();
            FormClosed += FormCalculation_Closed;
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
        private void FormCalculation_Load(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            con.Open();
            MySqlCommand sc = new MySqlCommand("select Vyd_z_k from Zberigannya", con);
            MySqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("vyd_z_k", typeof(string));

            dt.Load(reader);

            comboBox1.ValueMember = "vyd_z_k";
            comboBox1.DisplayMember = "vyd_z_k";
            comboBox1.DataSource = dt;

            con.Close();
        }
        protected void FormCalculation_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ID = comboBox1.SelectedValue.ToString();
            button2.Show();
            button2.PerformClick();
            button2.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Data.combobox1CalculateValue = comboBox1.Text;

            if ((int)numericUpDown1.Value < 14)
            {
                Data.wetnessParamInt = 0;
            }
            else
           
                try
                {
                    con.Open();
                    MySqlCommand com1 = new MySqlCommand("SELECT Sushka FROM Tsiny WHERE Vyd_z_k='" + comboBox1.Text + "'", con);
                    MySqlDataReader reader = com1.ExecuteReader();
                    while (reader.Read())

                    {
                        Data.wetnessParamInt = Int32.Parse(reader.GetValue(0).ToString());
                    }
                }
                catch (Exception ex)

                { }
                finally

                {
                    con.Close();
                }



                if (comboBox3.SelectedIndex == 0)
                {
                    Data.chystkaParamInt = 0;
                }
                else
                
                    try
                    {
                        con.Open();
                        MySqlCommand com1 = new MySqlCommand("SELECT Chystka FROM Tsiny WHERE Vyd_z_k='" + comboBox1.Text + "'", con);
                        MySqlDataReader reader = com1.ExecuteReader();
                        while (reader.Read())

                        {
                            Data.chystkaParamInt = Int32.Parse(reader.GetValue(0).ToString());
                        }
                    }
                    catch (Exception ex)

                    { }
                    finally

                    {
                        con.Close();
                    }
                
                
            
            if (comboBox2.SelectedIndex == 0)
            {
                Data.zberParamInt = 0;
            }
            else
           
                try
                {
                    con.Open();
                    MySqlCommand com1 = new MySqlCommand("SELECT " + comboBox2.Text + " FROM Zberigannya WHERE Vyd_z_k='" + comboBox1.Text + "'", con);
                    MySqlDataReader reader = com1.ExecuteReader();
                    while (reader.Read())

                    {
                        Data.zberParamInt = Int32.Parse(reader.GetValue(0).ToString());
                    }
                }
                catch (Exception ex)

                { }
                finally

                {
                    con.Close();
                }
            
            //ответ
            Data.Costs = (double)numericUpDown2.Value * (double)numericUpDown3.Value * (1 + Data.wetnessParamInt + Data.chystkaParamInt + (int)numericUpDown4.Value * Data.zberParamInt);//ответ!
            
            label13.Text = Data.Costs.ToString();
           
            //
            Data.wetnessParamInt = 0;
            Data.chystkaParamInt = 0;
            Data.zberParamInt = 0;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            button2.Show();
            button2.PerformClick();
            button2.Hide();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            button2.Show();
            button2.PerformClick();
            button2.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button2.Show();
            button2.PerformClick();
            button2.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button2.Show();
            button2.PerformClick();
            button2.Hide();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Show();
            button2.PerformClick();
            button2.Hide();
        }








        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            button2.Show();
            button2.PerformClick();
            button2.Hide();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            button2.Show();
            button2.PerformClick();
            button2.Hide();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Show();
            button2.PerformClick();
            button2.Hide();
        }
    }
}
    



