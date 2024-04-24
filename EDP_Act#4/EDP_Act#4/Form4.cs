using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDP_Act_4
{
    public partial class Dashboard : Form
    {
        public object ReportForm { get; private set; }

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Report reportForm = new Report();
            reportForm.Show();

            this.Hide();
        }

        private void aboutbut_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            f.ShowDialog();

            this.Hide();
        }

        private void logoutbut_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current SignUp form
            LogIn loginForm = new LogIn();
            loginForm.Show(); // Show the LogIn form again
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.ShowDialog();

            this.Hide();
        }
    }
}
