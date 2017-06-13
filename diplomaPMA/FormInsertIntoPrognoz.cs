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
    public partial class FormInsertIntoPrognoz : Form
    {
        MySqlConnection con = new MySqlConnection("user id=root;password=oracle;server=localhost;database=diploma;");
        public FormInsertIntoPrognoz()
        {
            InitializeComponent();
            FormClosed += FormInsertInto_Closed;
        }
        protected void FormInsertInto_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormInsertInto_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand com1 = new MySqlCommand("select max(rik) from prognoz", con);
                MySqlDataReader reader = com1.ExecuteReader();
                while (reader.Read())

                {
                    numericUpDown11.Value = Int32.Parse(reader.GetValue(0).ToString()) + 1;
                }
            }
            catch (Exception ex)

            { }
            finally

            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand com1 = new MySqlCommand("insert into prognoz values(" + numericUpDown11.Value + "," + numericUpDown1.Value + "," + numericUpDown2.Value + "," + numericUpDown3.Value + "," + numericUpDown4.Value + "," + numericUpDown5.Value + "," + numericUpDown6.Value + "," + numericUpDown7.Value + "," + numericUpDown8.Value + "," + numericUpDown9.Value + "," + numericUpDown10.Value + ")", con);
                com1.ExecuteNonQuery();
            }

            catch (Exception ex)

            { MessageBox.Show("Запис за цей рік вже існує!"); }
            finally

            {

                con.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           // numericUpDown1.Text = numericUpDown1.Text.Replace(',', '.');
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                MySqlCommand com1 = new MySqlCommand("delete from prognoz where rik = "+ numericUpDown11.Value +"", con);
                com1.ExecuteNonQuery();
            }

            catch (Exception ex)

            { MessageBox.Show("Запис за цей рік не існує!"); }
            finally

            {
                con.Close();
                FormSelectPrognoz f = new FormSelectPrognoz();
                f.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormSelectPrognoz f = new FormSelectPrognoz();
            f.Show();
        }
    }
}
