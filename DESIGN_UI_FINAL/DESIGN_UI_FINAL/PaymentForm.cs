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
    public partial class RoomForm : Form
    {
        public RoomForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(RoomForm_Load);
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            // Clear existing rows
            dataGridView1.Rows.Clear();

            // Add sample payment data
            dataGridView1.Rows.Add("2024-09-01", "Room 101", "$100.00", "Paid");
            dataGridView1.Rows.Add("2024-09-02", "Room 102", "$120.00", "Unpaid");
            dataGridView1.Rows.Add("2024-09-03", "Room 103", "$140.00", "Paid");
            dataGridView1.Rows.Add("2024-09-04", "Room 104", "$150.00", "Paid");
        }


        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
