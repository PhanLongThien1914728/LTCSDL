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

namespace Lab07_Advanced_Command
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();

        }

        private void Account_Load(object sender, EventArgs e)
        {
            loadForm();
        }
        public void loadForm()
        {
            string connectionString = "server=.; database = Lab06; Integrated Security = true; ";
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = conn.CreateCommand();
            string sql = "select [AccountName], [Password], [FullName], [Email], [Tell], [DateCreated] from Account ";
            conn.Open();
            cmd.CommandText = sql;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable("Food");
            adapter.Fill(table);
            dgvAccount.DataSource = table;
            conn.Close();
            conn.Dispose();
        }
    

    }
}


