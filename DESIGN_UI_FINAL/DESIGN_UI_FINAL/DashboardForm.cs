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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();

            this.Load += new EventHandler(DashboardForm_Load);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void hToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;      // Text color
            dataGridView1.DefaultCellStyle.BackColor = Color.White;      // Background color
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LightGray;  // Selected row background
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;      // Selected row text color

            // Add rows to DataGridView when the form loads
            dataGridView1.Rows.Add("2024-09-01", "Room 101 booked by John Doe");
            dataGridView1.Rows.Add("2024-09-02", "Room 102 cleaned and marked available");
            dataGridView1.Rows.Add("2024-09-03", "Monitor replaced in Room 201");
            dataGridView1.Rows.Add("2024-09-04", "Room 203 check-in by Jane Smith");
            dataGridView1.Rows.Add("2024-09-05", "Room 204 maintenance scheduled");
            dataGridView1.Rows.Add("2024-09-06", "Room 105 booked by Emily Davis");
            dataGridView1.Rows.Add("2024-09-07", "Room 305 check-out by John Doe");
            dataGridView1.Rows.Add("2024-09-08", "Room 307 cleaning in progress");
            dataGridView1.Rows.Add("2024-09-09", "Room 103 repaired broken window");
            dataGridView1.Rows.Add("2024-09-10", "Room 206 check-in by Michael Brown");
            dataGridView1.Rows.Add("2024-09-11", "Room 208 TV replaced with new model");
            dataGridView1.Rows.Add("2024-09-12", "Room 109 cleaned after check-out");
            dataGridView1.Rows.Add("2024-09-13", "Room 210 scheduled for painting");
            dataGridView1.Rows.Add("2024-09-14", "Room 305 carpet replaced");
            dataGridView1.Rows.Add("2024-09-15", "Room 401 booked by Sarah Lee");
            dataGridView1.Rows.Add("2024-09-16", "Room 305 check-out by William Taylor");
            dataGridView1.Rows.Add("2024-09-17", "Room 308 plumbing repaired");
            dataGridView1.Rows.Add("2024-09-18", "Room 402 cleaned after maintenance");
            dataGridView1.Rows.Add("2024-09-19", "Room 403 booked by Alice Walker");
            dataGridView1.Rows.Add("2024-09-20", "Room 205 TV remote replaced");
            dataGridView1.Rows.Add("2024-09-21", "Room 106 check-in by George Martin");
            dataGridView1.Rows.Add("2024-09-22", "Room 107 cleaned after party event");
            dataGridView1.Rows.Add("2024-09-23", "Room 104 booked by Olivia Harris");
            dataGridView1.Rows.Add("2024-09-24", "Room 306 curtains replaced");
            dataGridView1.Rows.Add("2024-09-25", "Room 206 furniture rearranged for guest request");

            dataGridView1.ClearSelection();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance of the LoginForm
            KournerLoginApp loginForm = new KournerLoginApp();

            // Show the LoginForm
            loginForm.Show();

            // Close the current DashboardForm
            this.Close();  // Closes the current form (DashboardForm)
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance of the SettingsForm
            SettingForm settingsForm = new SettingForm();

            // Show the SettingsForm
            settingsForm.ShowDialog();  // Show as a modal dialog, meaning the user must close it before returning to the dashboard
        }

        private void paymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create an instance of the RoomForm
            RoomForm RoomForm = new RoomForm();

            // Optionally, pass data from the dashboard to the RoomForm (if needed)
            // For example, you can pass any shared data or objects here
            // RoomForm.LoadPayments(data);  <-- Example of passing data if needed

            // Show the RoomForm
            RoomForm.ShowDialog();
        }

        private void manageMonitorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonitorManagementForm MonitorManagementForm = new MonitorManagementForm();
            MonitorManagementForm.Show();
        }

        private void manageRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create an instance of the RoomManagementForm
            RoomManagementForm roomManagementForm = new RoomManagementForm();

            // Show the Room Management form as a dialog or non-dialog window
            roomManagementForm.Show();  // You can use roomManagementForm.ShowDialog(); if you want a modal dialog

            // Optionally hide the dashboard if needed
            // this.Hide();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
