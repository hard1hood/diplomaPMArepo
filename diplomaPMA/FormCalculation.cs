using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity; // работа с ентити фреймворком стартс хир

namespace diplomaPMA
{
    
    public partial class FormCalculation : Form
    {
        public FormCalculation()
        {
            InitializeComponent();
            FormClosed += FormCalculation_Closed;
        }

        private void FormCalculation_Load(object sender, EventArgs e)
        {

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

    }
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class UserContext : DbContext
    {
        public UserContext()
            : base("user id=root;password=oracle;server=localhost;database=diploma")
        { }

        public DbSet<User> Users { get; set; }
    }
}
