using System;
using System.Windows.Forms;

namespace EDP_Act_4
{
    public partial class Dashboard : Form
    {
        private readonly string userName;

        public Dashboard(string userName)
        {
            InitializeComponent();
            this.userName = userName;
            label4.Text = userName; // Set label text to display the username
        }

        public Dashboard()
        {
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Any additional loading logic can go here
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reports reportForm = new Reports(userName); // Pass the userName parameter
            reportForm.Show();
            this.Hide();
        }

        private void aboutbut_Click(object sender, EventArgs e)
        {
            this.Close();
            Form7 f = new Form7();
            f.ShowDialog();

        }

        private void logoutbut_Click(object sender, EventArgs e)
        {
            this.Close();
            LogIn loginForm = new LogIn();
            loginForm.Show(); // Show the LogIn form again
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form6 f = new Form6();
            f.ShowDialog();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
