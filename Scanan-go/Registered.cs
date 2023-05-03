using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scanan_go
{
    public partial class Registered : Form
    {
        public Registered()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            DisplayRegistered();

        }
        public void DisplayRegistered()
        {
            Classes.SQLControl obj = new Classes.SQLControl();

            string sql = "";
            obj.fetchRegistered(sql, dgvRegistered );

        }
        private void dgvRegistered_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {        
        }
        private void tbRegSearch_TextChanged(object sender, EventArgs e)
        {
            Classes.SQLControl obj = new Classes.SQLControl();
            obj.findingRegistered(tbRegSearch.Text, dgvRegistered);
        }
    }
}
