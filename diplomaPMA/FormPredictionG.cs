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
    public partial class FormPredictionG : Form
    {
        MySqlConnection con = new MySqlConnection("user id=root;password=oracle;server=localhost;database=diploma;");
        public FormPredictionG()
        {
            InitializeComponent();
            FormClosed += FormCalculation_Closed;
        }

        protected void FormCalculation_Closed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormPredictionG_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrediction f = new FormPrediction();
            f.Show();
        }
    }
}
