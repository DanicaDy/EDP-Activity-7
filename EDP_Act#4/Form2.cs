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
    public partial class SignUp : Form
    {

        string connectionString = "Server=localhost;Port=3306;Database=act_2_edp;Uid=root;Pwd=danica;";

        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void Loginklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide(); // Hide the current SignUp form
            LogIn loginForm = new LogIn();
            loginForm.Show(); // Show the LogIn form again
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            string email = EmailTextbox.Text;
            string username = usernametext.Text;
            string firstName = fnametextBox2.Text;
            string lastName = LnamtextBox1.Text;
            string createpass = cpasstextbox.Text;
            string confirmPass = Confrimpass.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(createpass) || string.IsNullOrEmpty(confirmPass))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (createpass != confirmPass)
            {
                MessageBox.Show("Passwords do not match. Please try again.");
                return;
            }

            if (user_account(email, username, firstName, lastName, createpass))
            {
                MessageBox.Show("Sign up successful!");
                this.Hide();
                LogIn loginForm = new LogIn();
                loginForm.Show();
            }
            else
            {
                MessageBox.Show("Failed to sign up. Please try again.");
            }
        }

        private bool user_account(string email, string username, string firstName, string lastName, string password)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO users_account (email, UserName, FirstName, LastName, password) VALUES (@email, @username, @firstName, @lastName, @password)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@password", password);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }
    }
}

