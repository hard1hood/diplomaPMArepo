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
    public partial class FormSelectZberigannya : Form
    {
        MySqlConnection con = new MySqlConnection("user id=root;password=oracle;server=localhost;database=diploma;");

        public FormSelectZberigannya()
        {
            InitializeComponent();
            
        }
        
        private void FormSelectZberigannya_Load(object sender, EventArgs e)
        {
            con.Open();
            MySqlDataAdapter oda = new MySqlDataAdapter("select * from zberigannya", con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            dataGridView1.ReadOnly = true;
        }
    }
}
