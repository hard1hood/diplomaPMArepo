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
    public partial class FormAlterZberigannya : Form
    {
        MySqlConnection con = new MySqlConnection("user id=root;password=oracle;server=localhost;database=diploma;");
        public FormAlterZberigannya()
        {
            InitializeComponent();
            FormClosed += FormAZ;
        }

        protected void FormAZ(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormAlterZberigannya_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                MySqlDataReader reader1 =new MySqlCommand("select elevator from zberigannya where vyd_z_k = 'zhyto'", con).ExecuteReader();
                while (reader1.Read())

                {
                    numericUpDown1.Value = Int32.Parse(reader1.GetValue(0).ToString());
                }
                con.Close();

                con.Open();
                MySqlDataReader reader2 = new MySqlCommand("select elevator from zberigannya where vyd_z_k = 'pshenitsya'", con).ExecuteReader();
                while (reader2.Read())

                {
                    numericUpDown2.Value = Int32.Parse(reader2.GetValue(0).ToString());
                }
                con.Close();

                con.Open();
                MySqlDataReader reader3 = new MySqlCommand("select elevator from zberigannya where vyd_z_k = 'proso'", con).ExecuteReader();
                while (reader3.Read())

                {
                    numericUpDown3.Value = Int32.Parse(reader3.GetValue(0).ToString());
                }
                con.Close();

            }
            catch (Exception ex)

            { MessageBox.Show("Помилка"); }
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

        private void button4_Click(object sender, EventArgs e)
        {
            FormSelectZberigannya f = new FormSelectZberigannya();
            f.Show();
        }
    }
}
