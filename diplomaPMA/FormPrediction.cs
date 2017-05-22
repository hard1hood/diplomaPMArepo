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

        private void FormPrediction_Load(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = 0;
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
            label1.Text = Data.combobox1CalculateValue;
            label4.Text = Data.Costs.ToString();
        }
    }
}
