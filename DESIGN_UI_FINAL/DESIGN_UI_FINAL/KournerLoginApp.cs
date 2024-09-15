using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESIGN_UI_FINAL
{
    public partial class KournerLoginApp : Form
    {
        public KournerLoginApp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Simple validation (in real-world cases, you would check this against a database)
            if (username == "admin" && password == "admin")
            {
                // Hide the login form
                this.Hide();

                // Show the dashboard (you'll create the dashboard in the next step)
                DashboardForm dashboard = new DashboardForm();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void KournerLoginApp_Load(object sender, EventArgs e)
        {

        }
    }
}
