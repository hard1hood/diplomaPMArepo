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
    public partial class FormSelectPrognoz : Form
    {
        MySqlConnection con = new MySqlConnection("user id=root;password=oracle;server=localhost;database=diploma;");

        public FormSelectPrognoz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void FormSelectPrognoz_Load(object sender, EventArgs e)
        {
            con.Open();
            MySqlDataAdapter oda = new MySqlDataAdapter("select * from prognoz", con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            dataGridView1.ReadOnly = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            //Form2 f = new Form2();
            //f.Show();
        }
    }
}
