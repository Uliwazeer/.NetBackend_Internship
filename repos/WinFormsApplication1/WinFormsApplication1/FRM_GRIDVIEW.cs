using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WinFormsApplication1
{
    public partial class FRM_GRIDVIEW : Form
    {
        private readonly HttpClient httpClient;

        public FRM_GRIDVIEW()
        {
            InitializeComponent();

            httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7096/")
            };

            // Ensure the DataGridView is empty on form load.
            dataGridView1.DataSource = null;
        }

        private void BTN_NewForm_Click(object sender, EventArgs e)
        {
            using (FormINFO formINFO = new FormINFO(this))
            {
                formINFO.ShowDialog();
            }
        }

        private async void GetData_Click(object sender, EventArgs e)
        {
            // Clear any existing data in the DataGridView before loading new data.
            dataGridView1.DataSource = null;

            // Load data from the API.
            await LoadDataFromApi();
        }

        public async Task LoadDataFromApi()
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync("api/Brand");
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var brands = JsonConvert.DeserializeObject<List<Brand>>(jsonString);

                    // Populate DataGridView only after pressing the button
                    dataGridView1.DataSource = brands;
                }
                else
                {
                    MessageBox.Show("Error fetching data from the API. Status Code: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching data: " + ex.Message);
            }
        }

        private void FRM_GRIDVIEW_Load(object sender, EventArgs e)
        {
            // Ensure no data is loaded automatically on form load.
            dataGridView1.DataSource = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Define the LinkedIn URL
            string linkedinUrl = "https://www.linkedin.com/company/efgholding/";

            try
            {
                // Open the LinkedIn link in the default browser
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = linkedinUrl,
                    UseShellExecute = true // Required for .NET Core/5.0+ to open URLs in the default browser
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to open the link: " + ex.Message);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Define the GitHub URL
            string githubUrl = "https://github.com/Uliwazeer/EFG-Hermes-Internship-Backend-.NET-";

            try
            {
                // Open the GitHub link in the default browser
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = githubUrl,
                    UseShellExecute = true // Required for .NET Core/5.0+ to open URLs in the default browser
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to open the link: " + ex.Message);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Define the email address
            string email = "ali.noureldeen.wazeer@gmail.com";

            try
            {
                // Open the default email client with the specified email address
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = $"mailto:{email}",
                    UseShellExecute = true // Required for .NET Core/5.0+ to open mailto in the default email client
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to open the email client: " + ex.Message);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            // Define the URL
            string url = "https://www.efghldg.com/";

            try
            {
                // Open the link in the default browser
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // Required for .NET Core/5.0+ to open URLs in the default browser
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to open the link: " + ex.Message);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // Define the URL
            string url = "https://x.com/efg_holding";

            try
            {
                // Open the link in the default browser
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // Required for .NET Core/5.0+ to open URLs in the default browser
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to open the link: " + ex.Message);
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            // Define the YouTube URL
            string url = "https://www.youtube.com/channel/UCt1LCFfbJkFN4k_Io6tQZ3A";

            try
            {
                // Open the link in the default browser
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // Required for .NET Core/5.0+ to open URLs in the default browser
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to open the link: " + ex.Message);
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            // Define the Facebook URL
            string url = "https://www.facebook.com/EFGHolding";

            try
            {
                // Open the link in the default browser
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // Required for .NET Core/5.0+ to open URLs in the default browser
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to open the link: " + ex.Message);
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            // Define the Instagram URL
            string url = "https://www.instagram.com/efgholdingofficial/";

            try
            {
                // Open the link in the default browser
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // Required for .NET Core/5.0+ to open URLs in the default browser
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while trying to open the link: " + ex.Message);
            }
        }

    }

    public class Brand
    {
        public int ID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string? Directions { get; set; }
    }
}







/*
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WinFormsApplication1
{
    public partial class FRM_GRIDVIEW : Form
    {
        private readonly HttpClient httpClient;

        public FRM_GRIDVIEW()
        {
            InitializeComponent();
            this.BTN_NewForm.Click += new EventHandler(this.BTN_NewForm_Click); // Link the event handler
            this.GetData.Click += new EventHandler(this.GetData_Click); // Link the GetData button click event handler

            // Initialize HttpClient
            httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7078/api/Employees")
            };
        }

        private void BTN_NewForm_Click(object sender, EventArgs e)
        {
            using (FormINFO formINFO = new FormINFO(this))
            {
                formINFO.ShowDialog();
            }
            LoadData(); // Refresh data after the form is closed
        }

        private async void GetData_Click(object sender, EventArgs e)
        {
            await LoadDataFromApi(); // Fetch and display data from the Web API
        }

        private async Task LoadDataFromApi()
        {
            try
            {
                // Send GET request to the API
                HttpResponseMessage response = await httpClient.GetAsync("api/Employees");

                if (response.IsSuccessStatusCode)
                {
                    // Deserialize response content to a list of employees
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var employees = JsonConvert.DeserializeObject<List<Employee>>(jsonString);

                    // Bind the list of employees to the DataGridView
                    dataGridView1.DataSource = employees;
                }
                else
                {
                    MessageBox.Show("Error fetching data from the API. Status Code: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while fetching data: " + ex.Message);
            }
        }

        // This method can be used to load data from SQL if needed
        public void LoadData()
        {
            // Updated database connection string
            string connectionString = "Server=DESKTOP-LBHS7A0;Database=EmployeesDb;Trusted_Connection=True;TrustServerCertificate=true;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL select query to load data from the Employees table
                    string query = "SELECT ID, Quantity, Price, Directions FROM Employees";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL error occurred while loading data: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message);
            }
        }
    }

    // Define the Employee class to match the API response
    public class Employee
    {
        public int ID { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public required string Directions { get; set; }
    }
    
}
*/


/*
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApplication1
{
    public partial class FRM_GRIDVIEW : Form
    {
        public FRM_GRIDVIEW()
        {
            InitializeComponent();
            LoadData(); // Load data when the form is initialized
        }

        private void BTN_NewForm_Click(object sender, EventArgs e)
        {
            using (FormINFO formINFO = new FormINFO(this))
            {
                formINFO.ShowDialog();
            }
            LoadData(); // Refresh data after the form is closed
        }

        public void LoadData()
        {
            // Database connection string
            string connectionString = "Data Source=DESKTOP-LBHS7A0;Initial Catalog=Empinv;Integrated Security=True;TrustServerCertificate=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL select query to load data
                    string query = "SELECT ID, Quantity, Price, Directions FROM Empinv";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message);
            }
        }

        private void GetData_Click(object sender, EventArgs e)
        {

        }
    }
}
*/

