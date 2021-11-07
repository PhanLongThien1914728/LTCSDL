using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06_Basic_Command
{
    public partial class frmFood : Form
    {
        public frmFood()
        {
            InitializeComponent();
        }
        public void LoadFood (int categoryID)
        {
            string connectionString = "server=.; database = Lab06; Integrated Security = true;";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "SELECT Name FROM Category where ID = " + categoryID;
            sqlConnection.Open();

            string catName = sqlCommand.ExecuteScalar().ToString();
            this.Text = "Danh sách các món ăn thuộc nhóm : " + catName;
            sqlCommand.CommandText = "SELECT * FROM food WHERE FoodCategoryID = " + categoryID;

            SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable("Food");
            da.Fill(dt);
            dgvFood.DataSource = dt;
            sqlConnection.Close();
            sqlConnection.Dispose();
            da.Dispose();
        }
    }
}
