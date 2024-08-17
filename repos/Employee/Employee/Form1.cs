using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Employee
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void cboState_SelectedIndexChanged(object sender, EventArgs e)
        {
            label11.Text = cboState.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IDbtn.Text = "";
            Quantitybtn.Text = "";
            Pricebtn.Text = "";
        }

        private void Submitbtn_Click(object sender, EventArgs e)
        {
            if (IDbtn.Text == "" || Quantitybtn.Text == "" || Pricebtn.Text == "")
            {
                MessageBox.Show("Missing Data!!");
            }
            else
            {
                // Corrected connection string
                string connectionString = "Data Source=DESKTOP-LBHS7A0;Initial Catalog=Empinv;Integrated Security=True;TrustServerCertificate=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO Empinv (ID, Quantity, Price) VALUES (@ID, @Quantity, @Price)";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ID", IDbtn.Text);
                        command.Parameters.AddWithValue("@Quantity", Quantitybtn.Text);
                        command.Parameters.AddWithValue("@Price", Pricebtn.Text);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data inserted successfully!");
                            IDbtn.Text = "";
                            Quantitybtn.Text = "";
                            Pricebtn.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Error inserting data.");
                        }
                    }
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection("Data Source=DESKTOP-LBHS7A0;Initial Catalog=Empinv;Integrated Security=True;Trust Server Certificate=True");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
