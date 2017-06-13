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
    public partial class FormChart : Form
    {
        MySqlConnection con = new MySqlConnection("user id=root;password=oracle;server=localhost;database=diploma;");

        public FormChart()
        {
            InitializeComponent();
        }

        private void FormChart_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'diplomaDataSet.prognoz' table. You can move, or remove it, as needed.
            this.prognozTableAdapter.Fill(this.diplomaDataSet.prognoz);
            //msChart.Series["Series"].Enabled = false;
            comboBox2.SelectedValue = "Zhyto";
            
            con.Open();
            MySqlCommand sc = new MySqlCommand("select Vyd_z_k from Zberigannya", con);
            MySqlDataReader reader;

            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("vyd_z_k", typeof(string));

            dt.Load(reader);

            comboBox2.ValueMember = "vyd_z_k";
            comboBox2.DisplayMember = "vyd_z_k";
            comboBox2.DataSource = dt;

            con.Close();
        }
    }
}
