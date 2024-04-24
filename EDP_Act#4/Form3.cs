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
    public partial class ForgotPass : Form
    {
        private readonly string _connectionString = "Server=localhost;Port=3306;Database=act_2_edp;Uid=root;Pwd=danica;";

        public ForgotPass()
        {
            InitializeComponent();
        }

        private void ForgotPass_Load(object sender, EventArgs e)
        {
        }

        private void Fpassbut_Click_1(object sender, EventArgs e)
        {
                string email = LEmailTextbox.Text;
                string newPassword = Newpasstextbox.Text;
                string confirmPassword = Fcpasstextbox.Text;

                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                if (newPassword != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match. Please try again.");
                    return;
                }

                if (ResetPassword(email, newPassword))
                {
                    MessageBox.Show("Your password has been reset.");
                    this.Hide(); // Hide the current ForgotPass form
                    LogIn loginForm = new LogIn();
                    loginForm.Show(); // Show the LogIn form again
                }
                else
                {
                    MessageBox.Show("Failed to reset password. Please try again later.");
                }
            }

            private bool ResetPassword(string email, string newPassword)
            {
                string query = "UPDATE users_account SET password = @newPassword WHERE email = @email";

                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@newPassword", newPassword);
                        command.Parameters.AddWithValue("@email", email);

                        connection.Open();
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
