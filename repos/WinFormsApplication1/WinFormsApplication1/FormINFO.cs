using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WinFormsApplication1
{
    public partial class FormINFO : Form
    {
        private readonly FRM_GRIDVIEW fgrid;
        private readonly HttpClient httpClient;

        public FormINFO(FRM_GRIDVIEW fg)
        {
            InitializeComponent();
            this.fgrid = fg;
            httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7096/") };

            this.label1.Click += new EventHandler(this.label1_Click);
            this.textBox4.TextChanged += new EventHandler(this.textBox4_TextChanged);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(textBox1.Text) || !int.TryParse(textBox1.Text, out _))
            {
                MessageBox.Show("ID is required and must be a valid integer.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text) || !int.TryParse(textBox2.Text, out _))
            {
                MessageBox.Show("Quantity is required and must be a valid integer.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox3.Text) || !int.TryParse(textBox3.Text, out _))
            {
                MessageBox.Show("Price is required and must be a valid decimal.");
                return;
            }

            string directions = textBox4.Text.Trim().ToLower();
            if (directions != "sell" && directions != "buy")
            {
                MessageBox.Show("Directions must be either 'sell' or 'buy'.");
                return;
            }

            // Create the brand object
            var brand = new
            {
                id= 0,
                quantity = int.Parse(textBox2.Text),
                price = int.Parse(textBox3.Text),
                directions = textBox4.Text
            };
            /*
            MessageBox.Show(brand.ID.ToString());
            MessageBox.Show(brand.Quantity.ToString());
            MessageBox.Show(brand.Price.ToString());
            MessageBox.Show(brand.Directions.ToString());
            */
            // Serialize the object to JSON
            var json = JsonConvert.SerializeObject(brand);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                // Send the POST request to the Web API
                var response = await httpClient.PostAsync("api/Brand", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Data inserted successfully!");

                    // Clear the textboxes after successful insert
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";

                    // Refresh the data in FRM_GRIDVIEW
                    await fgrid.LoadDataFromApi(); // Ensure this method call is awaited
                }
                else
                {
                    MessageBox.Show("Error inserting data. Status Code: " + response.StatusCode);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("An error occurred while inserting data: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Label1 was clicked!");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            label1.Text = "Current Text: " + textBox4.Text;
        }

        private void label7_Click(object sender, EventArgs e) { }

        private void label5_Click(object sender, EventArgs e) { }

        private void FormINFO_Load(object sender, EventArgs e) { }
    }
}


/*
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WinFormsApplication1
{
    public partial class FormINFO : Form
    {
        private readonly FRM_GRIDVIEW fgrid;
        private readonly HttpClient httpClient;

        public FormINFO(FRM_GRIDVIEW fg)
        {
            InitializeComponent();
            this.fgrid = fg;
            httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7096/") };

            this.label1.Click += new EventHandler(this.label1_Click);
            this.textBox4.TextChanged += new EventHandler(this.textBox4_TextChanged);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || !int.TryParse(textBox1.Text, out _))
            {
                MessageBox.Show("ID is required and must be a valid integer.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text) || !int.TryParse(textBox2.Text, out _))
            {
                MessageBox.Show("Quantity is required and must be a valid integer.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox3.Text) || !decimal.TryParse(textBox3.Text, out _))
            {
                MessageBox.Show("Price is required and must be a valid decimal.");
                return;
            }

            string directions = textBox4.Text.Trim().ToLower();
            if (directions != "sell" && directions != "buy")
            {
                MessageBox.Show("Directions must be either 'sell' or 'buy'.");
                return;
            }

            var brand = new
            {
                ID = int.Parse(textBox1.Text),
                Quantity = int.Parse(textBox2.Text),
                Price = decimal.Parse(textBox3.Text),
                Directions = textBox4.Text
            };

            var json = JsonConvert.SerializeObject(brand);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var response = await httpClient.PostAsync("api/Brand", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Data inserted successfully!");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";

                    // Refresh the data in FRM_GRIDVIEW
                    await fgrid.LoadDataFromApi(); // Ensure this method call is awaited
                }
                else
                {
                    MessageBox.Show("Error inserting data. Status Code: " + response.StatusCode);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show("An error occurred while inserting data: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Label1 was clicked!");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            label1.Text = "Current Text: " + textBox4.Text;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FormINFO_Load(object sender, EventArgs e)
        {

        }
    }
}
*/




/*
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApplication1
{
    public partial class FormINFO : Form
    {
        private readonly FRM_GRIDVIEW fgrid;

        public FormINFO(FRM_GRIDVIEW fg)
        {
            InitializeComponent();
            this.fgrid = fg;

            // Wire up event handlers
            this.label1.Click += new EventHandler(this.label1_Click);
            this.textBox4.TextChanged += new EventHandler(this.textBox4_TextChanged);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                !int.TryParse(textBox1.Text, out _)) // ID should be an integer
            {
                MessageBox.Show("ID is required and must be a valid integer.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text) ||
                !int.TryParse(textBox2.Text, out _)) // Quantity should be an integer
            {
                MessageBox.Show("Quantity is required and must be a valid integer.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox3.Text) ||
                !decimal.TryParse(textBox3.Text, out _)) // Price should be a decimal
            {
                MessageBox.Show("Price is required and must be a valid decimal.");
                return;
            }

            // Validate that Directions is "sell" or "buy"
            string directions = textBox4.Text.Trim().ToLower();
            if (directions != "sell" && directions != "buy")
            {
                MessageBox.Show("Directions must be either 'sell' or 'buy'.");
                return;
            }

            // Database connection string
            string connectionString = "Data Source=DESKTOP-LBHS7A0;Initial Catalog=Empinv;Integrated Security=True;TrustServerCertificate=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL insert query
                    string query = "INSERT INTO Empinv (ID, Quantity, Price, Directions) VALUES (@ID, @Quantity, @Price, @Directions)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Adding parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
                        command.Parameters.AddWithValue("@Quantity", int.Parse(textBox2.Text));
                        command.Parameters.AddWithValue("@Price", decimal.Parse(textBox3.Text));
                        command.Parameters.AddWithValue("@Directions", textBox4.Text);

                        // Execute the command
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Data inserted successfully!");
                            // Optionally clear the textboxes after successful insert
                            textBox1.Text = "";
                            textBox2.Text = "";
                            textBox3.Text = "";
                            textBox4.Text = "";

                            // Refresh the data in FRM_GRIDVIEW
                            fgrid.LoadData(); // Call LoadData to refresh the grid view
                        }
                        else
                        {
                            MessageBox.Show("Error inserting data.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while inserting data: " + ex.Message);
            }
        }

        // Event handler for label1 Click event
        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Label1 was clicked!");
        }

        // Event handler for textBox4 TextChanged event
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // Example logic: Update the label with the text from textBox4
            label1.Text = "Current Text: " + textBox4.Text;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
*/

/*
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApplication1
{
    public partial class FormINFO : Form
    {
        private readonly FRM_GRIDVIEW fgrid;

        public FormINFO(FRM_GRIDVIEW fg)
        {
            InitializeComponent();
            this.fgrid = fg;

            // Wire up event handlers
            this.label1.Click += new EventHandler(this.label1_Click);
            this.textBox4.TextChanged += new EventHandler(this.textBox4_TextChanged);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                !int.TryParse(textBox1.Text, out _)) // ID should be an integer
            {
                MessageBox.Show("ID is required and must be a valid integer.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text) ||
                !int.TryParse(textBox2.Text, out _)) // Quantity should be an integer
            {
                MessageBox.Show("Quantity is required and must be a valid integer.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox3.Text) ||
                !decimal.TryParse(textBox3.Text, out _)) // Price should be a decimal
            {
                MessageBox.Show("Price is required and must be a valid decimal.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Directions are required.");
                return;
            }

            // Database connection string
            string connectionString = "Data Source=DESKTOP-LBHS7A0;Initial Catalog=Empinv;Integrated Security=True;TrustServerCertificate=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL insert query
                    string query = "INSERT INTO Empinv (ID, Quantity, Price, Directions) VALUES (@ID, @Quantity, @Price, @Directions)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Adding parameters to prevent SQL injection
                        command.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
                        command.Parameters.AddWithValue("@Quantity", int.Parse(textBox2.Text));
                        command.Parameters.AddWithValue("@Price", decimal.Parse(textBox3.Text));
                        command.Parameters.AddWithValue("@Directions", textBox4.Text);

                        // Execute the command
                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Data inserted successfully!");
                            // Optionally clear the textboxes after successful insert
                            textBox1.Text = "";
                            textBox2.Text = "";
                            textBox3.Text = "";
                            textBox4.Text = "";

                            // Refresh the data in FRM_GRIDVIEW
                            fgrid.LoadData(); // Call LoadData to refresh the grid view
                        }
                        else
                        {
                            MessageBox.Show("Error inserting data.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while inserting data: " + ex.Message);
            }
        }

        // Event handler for label1 Click event
        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Label1 was clicked!");
        }

        // Event handler for textBox4 TextChanged event
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // Example logic: Update the label with the text from textBox4
            label1.Text = "Current Text: " + textBox4.Text;
        }
    }
}
*/