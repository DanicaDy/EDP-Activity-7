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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogInLabel_Click(object sender, EventArgs e)
        {

        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void fpassLinkL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // When the "Forgot Password?" link is clicked, open the ForgotPass form
            ForgotPass forgotPassForm = new ForgotPass();
            forgotPassForm.Show();

            this.Hide();
        }

        private void SignUplinklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUpForm = new SignUp();
            signUpForm.Show();

            this.Hide();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            string email = LEmailTextbox.Text;
            string password = passwordtextbox.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Email and password are required.");
                return;
            }

            
            if (AuthenticateUser(email, password))
            {
                
                Dashboard dashboardForm = new Dashboard();
                dashboardForm.Show();
                this.Hide();
            }
            else
            {
                
                MessageBox.Show("Invalid email or password. Please try again.");
            }
        }

        private bool AuthenticateUser(string email, string password)
        {
            string connectionString = "Server=localhost;Port=3306;Database=act_2_edp;Uid=root;Pwd=danica;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM users_account WHERE email = @email AND password = @password";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@password", password);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
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
