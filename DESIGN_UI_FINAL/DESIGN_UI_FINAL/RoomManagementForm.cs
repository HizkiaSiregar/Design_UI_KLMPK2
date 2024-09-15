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
    public partial class RoomManagementForm : Form
    {
        public RoomManagementForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewRooms.Rows.Clear();

            dataGridViewRooms.Rows.Add("101", "1", "Available");
            dataGridViewRooms.Rows.Add("102", "2", "Not Available");
            dataGridViewRooms.Rows.Add("103", "1", "Available");
            dataGridViewRooms.Rows.Add("104", "2", "Not Available");
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
