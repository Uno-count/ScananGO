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
  
    public partial class AccSett : Form
    {

       
        public AccSett()
        {
            InitializeComponent();
     
        }

        public static string id, usr, pass, usrtype;


        public void ListAdmin()
        {
            Classes.SQLControl obj = new Classes.SQLControl();
            string sql = "";
            obj.fetchAdmin(sql, guna2DataGridView1);
            this.guna2DataGridView1.Columns["Id"].Visible = false;
        }

        public void AccSett_Load(object sender, EventArgs e)
        {         
            ListAdmin();
            label1.Hide();
           
        }

        private void btnMonitring_Click(object sender, EventArgs e)
        {
            addAcc addAdmin = new addAcc();
            addAdmin.ShowDialog();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            ListAdmin();
        }

        public void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {           
            label1.Text  = guna2DataGridView1.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
            usr = guna2DataGridView1.Rows[e.RowIndex].Cells["username"].FormattedValue.ToString();
            pass = guna2DataGridView1.Rows[e.RowIndex].Cells["password"].FormattedValue.ToString();
            //usrtype = guna2DataGridView1.Rows[e.RowIndex].Cells["usertype"].FormattedValue.ToString();


        }
        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cmsUpdateDel.Show(Cursor.Position);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            id = label1.Text;
            updateAcc showupdate = new updateAcc();
            showupdate.ShowDialog();
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Classes.SQLControl obj = new Classes.SQLControl();
            Classes.DeleteAdmin delAdmin = new Classes.DeleteAdmin(
                label1.Text 
                );
            obj.DeleteAdmin(delAdmin.GetID());
            ListAdmin();
        }
        private void guna2DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.guna2DataGridView1.Columns[e.ColumnIndex].Name == "password")
            {
                if (e.Value != null)
                {
                    e.Value = new string ('*', e.Value.ToString().Length);
                }
            }
        }

    }
}
