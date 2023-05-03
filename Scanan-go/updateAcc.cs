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
    public partial class updateAcc : Form
    {
    

        public updateAcc()
        {
            InitializeComponent();
            
        }
        public string identity;
        

        private void btnUdClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnUdCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void updateAcc_Load(object sender, EventArgs e)
        {
            tbUdUser.Text = AccSett.usr;
            tbUdPass.Text = AccSett.pass;
            cbUdUserTyoe.Text = AccSett.usrtype;
            identity = AccSett.id;
        }

        private void btnUdUpdate_Click(object sender, EventArgs e)
        {
            updateAdmin();
            clear();
            this.Close();
        }
        private void updateAdmin()
        {
            Classes.SQLControl obj = new Classes.SQLControl();
            Classes.UpdateAdmin Upadmin = new Classes.UpdateAdmin(
                cbUdUserTyoe.Text,
                tbUdUser.Text ,
                tbUdPass.Text ,
                identity 
                );

            obj.UpdateAdmin(Upadmin.getUsertype(),Upadmin.getUsername(),Upadmin.getPassword(),Upadmin.GetID());
        }
        public void clear()
        {
            tbUdPass.Clear();
            tbUdUser.Clear();
            cbUdUserTyoe.Dispose();
        }
    }
}
