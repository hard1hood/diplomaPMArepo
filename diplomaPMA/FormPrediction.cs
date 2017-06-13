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
    public partial class FormPrediction : Form
    {
        MySqlConnection con = new MySqlConnection("user id=root;password=oracle;server=localhost;database=diploma;");
        public FormPrediction()
        {
            InitializeComponent();
            FormClosed += FormPrediction_Closed;
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
        private void FormPrediction_Load(object sender, EventArgs e)
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

            try
            {
                con.Open();
                MySqlCommand com1 = new MySqlCommand("SELECT SUM(" + comboBox1.Text + ") FROM Prognoz", con);
                MySqlDataReader reader = com1.ExecuteReader();
                while (reader.Read())

                {
                    Data.sumPredictDouble = Convert.ToDouble(reader.GetValue(0).ToString());
                }
            }
            catch (Exception ex)

            { }
            finally

            {
                con.Close();
            }

            try
            {
                con.Open();
                MySqlCommand com1 = new MySqlCommand("SELECT COUNT(" + comboBox1.Text + ") FROM Prognoz", con);
                MySqlDataReader reader = com1.ExecuteReader();
                while (reader.Read())

                {
                    Data.countInt = Int32.Parse(reader.GetValue(0).ToString());
                }
            }
            catch (Exception ex)

            {  }
            finally

            {
                con.Close();
            }

            try
            {
                con.Open();
                MySqlCommand com1 = new MySqlCommand("SELECT " + comboBox1.Text + " FROM Prognoz WHERE Rik='2015'", con);
                MySqlDataReader reader = com1.ExecuteReader();
                while (reader.Read())

                {
                    Data.punkt3 = Convert.ToDouble(reader.GetValue(0).ToString());
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
                Data.zberPredInt = 0;
            }
            else

                try
                {
                    con.Open();
                    MySqlCommand com1 = new MySqlCommand("SELECT " + comboBox2.Text + " FROM Zberigannya WHERE Vyd_z_k='" + comboBox1.Text + "'", con);
                    MySqlDataReader reader = com1.ExecuteReader();
                    while (reader.Read())

                    {
                        Data.zberPredInt = Int32.Parse(reader.GetValue(0).ToString());
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
                Data.chystkaPredInt = 0;
            }
            else

                try
                {
                    con.Open();
                    MySqlCommand com1 = new MySqlCommand("SELECT Chystka FROM Tsiny WHERE Vyd_z_k='" + comboBox1.Text + "'", con);
                    MySqlDataReader reader = com1.ExecuteReader();
                    while (reader.Read())

                    {
                        Data.chystkaPredInt = Int32.Parse(reader.GetValue(0).ToString());
                    }
                }
                catch (Exception ex)

                { }
                finally

                {
                    con.Close();
                }


            Data.ur = Math.Round(Data.punkt3 + ((Data.punkt3 - (Data.sumPredictDouble / Data.countInt)) / Data.countInt),2);//прогнозована урожайнысть
            label3.Text = Data.ur.ToString();

            Data.costsPrediction = Data.ur * (double)numericUpDown3.Value * (1 + (int)numericUpDown4.Value * Data.zberPredInt + Data.chystkaPredInt);//прогнозована вартисть
            label13.Text = Data.costsPrediction.ToString();
            Data.sumPredictDouble = 0;
            Data.countInt = 0;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ID = comboBox1.SelectedValue.ToString();
            button2.Show();
            button2.PerformClick();
            button2.Hide();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
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
    }
}
