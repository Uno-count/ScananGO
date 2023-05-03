using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Scanan_go
{
    public partial class addAcc : Form
    {
        public addAcc()
        {
            InitializeComponent();
        }

        private void btnCrtClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        

        private void btnCrtCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCrtSignUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbCrtPass.Text) || (string.IsNullOrEmpty(tbCrtUser.Text) || (string.IsNullOrEmpty(cbCrtUserTyoe.Text))))
            {
                MessageBox.Show("Please fill the information above completely");
                tbCrtUser.Clear();
                tbCrtUser.Clear();
                cbCrtUserTyoe.SelectedIndex = -1;
                return;
            }
            else
            {
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=scanango;password=");
                DataTable resultTable = new DataTable("ACCOUNT");
                con.Open();
                MySqlDataAdapter Da = new MySqlDataAdapter();
                Da.SelectCommand = new MySqlCommand();
                Da.SelectCommand.Connection = con;
                Da.SelectCommand.CommandType = CommandType.Text;
                Da.SelectCommand.CommandText = "SELECT * FROM tblAdmin";
                Da.Fill(resultTable);

                if (resultTable.Rows.Count > 4)
                {
                    MessageBox.Show("maximum acc");
                    con.Close();
                }
                else
                {
                    InsertAdmin();
                    con.Close();
                }
                con.Close();
            }





        }
        public void InsertAdmin()
        {


            Classes.SQLControl obj = new Classes.SQLControl();
            Classes.AddAdmin addAdmin = new Classes.AddAdmin(

                cbCrtUserTyoe.Text ,
                tbCrtUser.Text ,
                tbCrtPass.Text
                );

            obj.InsertAdmin(addAdmin.GetUsertype(), addAdmin.GetUsername(), addAdmin.GetPassword());
        }
        public void refresh()
        {
            AccSett Adminform = new AccSett();
            //Adminform.ListAdmin(this);
            
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

