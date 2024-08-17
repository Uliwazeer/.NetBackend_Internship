using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Employee
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string connectionString = "Data Source=DESKTOP-LBHS7A0;Initial Catalog=Empinv;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT ID, Quantity, Price FROM Empinv", connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}

/*
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Employee
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-LBHS7A0;Initial Catalog=Empinv;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            SqlCommand cmd = new SqlCommand("Select ID,Quantity,Price,Directions From Table",conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
*/