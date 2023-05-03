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
    
    public partial class AdMain_Form : Form
    {
        private Form currentChildForm;
        Boolean btnMonitoringIsClicked = false;
        Boolean btnAccSettingsIsClicked = false;
        Boolean btnRegisteredIsClicked = false;
        Boolean btnLogoutIsClicked = false;

        Form1 frm1 = new Form1();
        //string usertype;
        public AdMain_Form()
        {
            InitializeComponent();
         
        }
        public void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelDesktop.Controls.Add(childForm);
            PanelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        
                
        }
        private void AdMain_Form_Load(object sender, EventArgs e)
        {
            label1.Text = Form1.username;

            MySqlConnection con = new MySqlConnection("server=localhost;database=scanango;username=root;password=");
            DataTable resultTable = new DataTable("EMAIL");
            con.Open();
            MySqlDataAdapter Da = new MySqlDataAdapter();
            Da.SelectCommand = new MySqlCommand();
            Da.SelectCommand.Connection = con;
            Da.SelectCommand.CommandType = CommandType.Text;
            Da.SelectCommand.CommandText = "SELECT usertype FROM tblAdmin WHERE username = '" + Form1.username + "'  and password = '" + Form1.password + "'";
            Da.Fill(resultTable);

            if (resultTable.Rows.Count > 0)
            {
                label1.Text = resultTable.Rows[0]["usertype"].ToString();
                con.Close();
            }
            else
            {
                con.Close();
            }
            if (label1.Text == "User")
            {
                btnAccSettings.Hide();
            }
            con.Close();
            timer1.Start();
            this.MaximumSize = Screen.FromRectangle(this.DesktopBounds).WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;
            btnMonitoringIsClicked = true;
            OpenChildForm(new Monitoring());
            lblHeaderTitle.Text = "Monitoring";

            if (btnMonitoringIsClicked == true)
            {
                btnAccSettingsIsClicked = false;
                btnRegisteredIsClicked = false;
                btnLogoutIsClicked = false;
                btnMonitoring.FillColor = Color.FromArgb(33, 82, 67);
            }
            if (btnAccSettingsIsClicked == false && btnRegisteredIsClicked == false && btnLogoutIsClicked == false)
            {
                btnRegistered.FillColor = Color.Transparent;
                btnAccSettings.FillColor = Color.Transparent;
                btnLogout.FillColor = Color.Transparent;

            }
        }


        private void btnMonitring_Click(object sender, EventArgs e)
        {
            btnMonitoringIsClicked = true;
            lblHeaderTitle.Text = "Monitoring";
            OpenChildForm(new Monitoring());

            if (btnMonitoringIsClicked == true)
            {
                btnAccSettingsIsClicked = false;
                btnRegisteredIsClicked = false;
                btnLogoutIsClicked = false;
                btnMonitoring.FillColor = Color.FromArgb(33, 82, 67);
            }
            if (btnAccSettingsIsClicked == false  && btnRegisteredIsClicked == false && btnLogoutIsClicked == false)
            {
                btnRegistered.FillColor = Color.Transparent;
                btnAccSettings.FillColor = Color.Transparent;
                btnLogout.FillColor = Color.Transparent;

            }
        }

       

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            ToolTip  tltp = new ToolTip();
            tltp.SetToolTip(this.btnClose, "Close");

        }

        private void btnMazimize_Click(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Normal) {
                WindowState = FormWindowState.Maximized;

            }
            else {
                WindowState = FormWindowState.Normal;

            }


        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
           
        }

        private void btnMazimize_MouseHover(object sender, EventArgs e)
        {
            ToolTip tltp = new ToolTip();
            ToolTip tltp1 = new ToolTip();
            String ts = "Restore Down";
            //String ts1 = "Maximize";


            if (WindowState == FormWindowState.Maximized)
            {
                tltp.SetToolTip(this.btnMaximize, ts);
                tltp1.Hide(btnMaximize);
            }
            else if (WindowState == FormWindowState.Normal)
            {
                tltp1.SetToolTip(this.btnMaximize, "Maximize");
                tltp.Hide(btnMaximize);



            }


        }

        private void btnMinimize_MouseHover(object sender, EventArgs e)
        {
            ToolTip tltp = new ToolTip();
            tltp.SetToolTip(this.btnMinimize, "Minimize");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Form2 form2 = new Form2();
            form2.Dispose();
        }

        private void AdMain_Form_SizeChanged(object sender, EventArgs e)
        {
            ToolTip tltp = new ToolTip();
            ToolTip tltp1 = new ToolTip();

            if (WindowState == FormWindowState.Maximized)
            {
                tltp1.Dispose();

            }
            else
            {
                tltp.Dispose();

            }
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            btnLogoutIsClicked = true;
            if (btnLogoutIsClicked == true)
            {
                btnAccSettingsIsClicked = false;
                btnRegisteredIsClicked = false;
                btnLogoutIsClicked = false;
                btnLogout.FillColor = Color.FromArgb(33, 82, 67);
            }
            if (btnAccSettingsIsClicked == false && btnRegisteredIsClicked == false && btnLogoutIsClicked == false)
            {
                btnRegistered.FillColor = Color.Transparent;
                btnAccSettings.FillColor = Color.Transparent;
                btnMonitoring.FillColor = Color.Transparent;

            }
            Application.Exit();
            this.Dispose();
        }

        private void btnMonitring_Click_1(object sender, EventArgs e)
        {
            btnMonitoringIsClicked = true;
            lblHeaderTitle.Text = "Monitoring";
            OpenChildForm(new Monitoring());

            if (btnMonitoringIsClicked == true)
            {
                btnAccSettingsIsClicked = false;
                btnRegisteredIsClicked = false;
                btnLogoutIsClicked = false;
                btnMonitoring.FillColor = Color.FromArgb(33, 82, 67);
            }
            if (btnAccSettingsIsClicked == false && btnRegisteredIsClicked == false && btnLogoutIsClicked == false)
            {
                btnRegistered.FillColor = Color.Transparent;
                btnAccSettings.FillColor = Color.Transparent;
                btnLogout.FillColor = Color.Transparent;
            }         
        }
        private void btnRegistered_Click_1(object sender, EventArgs e)
        {
            btnRegisteredIsClicked = true;
            lblHeaderTitle.Text = "Registered";
            OpenChildForm(new Registered());
            if (btnRegisteredIsClicked == true)
            {
                btnAccSettingsIsClicked = false;
                btnLogoutIsClicked = false;
                btnMonitoringIsClicked = false;
                btnRegistered.FillColor = Color.FromArgb(33, 82, 67);
            }
            if (btnAccSettingsIsClicked == false && btnMonitoringIsClicked == false && btnLogoutIsClicked == false)
            {
                btnMonitoring.FillColor = Color.Transparent;
                btnAccSettings.FillColor = Color.Transparent;
                btnLogout.FillColor = Color.Transparent;
            }
        
        }

        private void btnAccSettings_Click_1(object sender, EventArgs e)
        {
            btnAccSettingsIsClicked = true;
            lblHeaderTitle.Text = "Account Settings";
            OpenChildForm(new AccSett());
            if (btnAccSettingsIsClicked == true)
            {
                btnRegisteredIsClicked = false;
                btnLogoutIsClicked = false;
                btnMonitoringIsClicked = false;
                btnAccSettings.FillColor = Color.FromArgb(33, 82, 67);
            }
            if (btnRegisteredIsClicked == false && btnMonitoringIsClicked == false && btnLogoutIsClicked == false)
            {
                btnMonitoring.FillColor = Color.Transparent;
                btnRegistered.FillColor = Color.Transparent;
                btnLogout.FillColor = Color.Transparent;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime CurrentDateTime;
            CurrentDateTime = DateTime.Now;
            lblDate.Text = CurrentDateTime.ToString("dddd, d MMMM yyyy  |  hh:mm:ss tt");
        }
    }
}
