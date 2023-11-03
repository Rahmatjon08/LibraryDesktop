using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secret_Library
{
    public partial class UserControl1 : UserControl
    {
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDateAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();

        public SqlCredential Ct { get; private set; }

        public UserControl1()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {
            NameTxt.Clear();
            PriceTxt.Clear();
            MadeTxt.Clear();
            DateTxt.Clear();
            AuthorTxt.Clear();
            CategoryTxt.Clear();
        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"");
        }
    }
}
