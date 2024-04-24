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

namespace EDP_Act_4
{
    public partial class Form6 : Form
    {
        private readonly string _connectionString = "Server=localhost;Port=3306;Database=act_2_edp;Uid=root;Pwd=danica;";
        private DataTable _userData;
        private DataGridView dataGridView1;

        public Form6()
        {
            InitializeComponent();
            InitializeDataGridView();
            LoadUserData();
        }

        private void InitializeDataGridView()
        {
            dataGridView1 = new DataGridView();
            dataGridView1.Dock = DockStyle.Fill;
            panel7.Controls.Add(dataGridView1);
            dataGridView1.Location = new Point(10, 10);


            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void LoadUserData()
        {
            _userData = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                string query = "SELECT email, UserName, FirstName, LastName, is_active FROM users_account";
                MySqlCommand command = new MySqlCommand(query, connection);
                try
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    adapter.Fill(_userData);
                    dataGridView1.DataSource = _userData;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];



                EmailTextbox.Text = selectedRow.Cells["email"].Value.ToString();
                usernametext.Text = selectedRow.Cells["UserName"].Value.ToString();
                fnametextBox2.Text = selectedRow.Cells["FirstName"].Value.ToString();
                LnamtextBox1.Text = selectedRow.Cells["LastName"].Value.ToString();
            }
        }

        private void UpdateChanges()
        {
            
            string email = EmailTextbox.Text;
            string username = usernametext.Text;
            string firstName = fnametextBox2.Text;
            string lastName = LnamtextBox1.Text;

            
            foreach (DataRow row in _userData.Rows)
            {
                
                if (row["email"].ToString() == email)
                {
                    
                    row["UserName"] = username;
                    row["FirstName"] = firstName;
                    row["LastName"] = lastName;

                    
                    break;
                }
            }

            
            dataGridView1.DataSource = _userData;

            
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                string query = "UPDATE users_account SET UserName = @username, FirstName = @firstName, LastName = @lastName WHERE email = @email";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@lastName", lastName);
                command.Parameters.AddWithValue("@email", email);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User information updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No rows were updated.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating user information: " + ex.Message);
                }
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            UpdateChanges();

            LoadUserData();
        }

        private void sBtn_Click(object sender, EventArgs e)
        {
            string searchCriteria = stextBox1.Text;


            string query = "SELECT * FROM users_account WHERE email LIKE @search OR UserName LIKE @search OR FirstName LIKE @search OR LastName LIKE @search";
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@search", "%" + searchCriteria + "%");

                try
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable searchResults = new DataTable();
                    adapter.Fill(searchResults);
                    dataGridView1.DataSource = searchResults;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private bool user_account(string email, string username, string firstName, string lastName, string password)
        {
            
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM users_account WHERE UserName = @username";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Username already exists. Please choose a different username.");
                        return false;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error checking username availability: " + ex.Message);
                    return false;
                }
            }

            
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO users_account (email, UserName, FirstName, LastName) VALUES (@email, @username, @firstName, @lastName)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error inserting user account: " + ex.Message);
                    return false;
                }
            }
        }

        private void homebut_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current SignUp form
            Dashboard f = new Dashboard();
            f.Show(); // Show the LogIn form again
        }

        private void logoutbut_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current SignUp form
            LogIn loginForm = new LogIn();
            loginForm.Show(); // Show the LogIn form again
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}