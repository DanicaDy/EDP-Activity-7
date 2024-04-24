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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        internal void show()
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Report_Load(object sender, EventArgs e)
        {

        }

        private void aboutbut_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            f.ShowDialog();

            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
