using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace EDP_Act_4
{
    public partial class LogIn : Form
    {
        private string authenticatedUserName;

        public LogIn()
        {
            InitializeComponent();
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
                authenticatedUserName = GetUserName(email);
                OpenDashboardForm(authenticatedUserName);
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
                    string query = "SELECT COUNT(*) FROM users_account WHERE email = @Email AND password = @Password";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);
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

        private string GetUserName(string email)
        {
            string connectionString = "Server=localhost;Port=3306;Database=act_2_edp;Uid=root;Pwd=danica;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT CONCAT(FirstName, ' ', LastName) AS FullName FROM users_account WHERE email = @Email";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Email", email);
                    string fullName = command.ExecuteScalar() as string;
                    return fullName;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return null;
                }
            }
        }



        private void OpenDashboardForm(string userName)
        {
            Dashboard dashboardForm = new Dashboard(userName);
            dashboardForm.Show();
            this.Hide();
        }

        private void fpassLinkL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide(); // Hide the current SignUp form
            ForgotPass f = new ForgotPass();
            f.Show(); // Show the LogIn form again
        }

        private void SignUplinklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide(); // Hide the current SignUp form
            SignUp f = new SignUp();
            f.Show(); // Show the LogIn form again
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
