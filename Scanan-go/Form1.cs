using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using System.IO;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace Scanan_go
{
    public partial class Form1 : Form

    {
        Form2 ScannersForm = new Form2();
        string fullname;
        int count;
        string fname;
        public static string username;
        public static string password;
        
        public Form1()
        {
            InitializeComponent();
        }
        #region UI
        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (slidePanel.Location.X > 0)
            {
                slidePanel.Location = new Point(slidePanel.Location.X - 10, slidePanel.Location.Y);
                slideRegisterPanel.Location = new Point(slideRegisterPanel.Location.X + 10, slideRegisterPanel.Location.Y);
                slideLoginPanel.Location = new Point(slideLoginPanel.Location.X + 10, slideLoginPanel.Location.Y);
                btnAdminLogin.Enabled = false;
                btnRegister.Enabled = true;
                label3.Show();
                label4.Hide();
                label5.Hide();
                label6.Hide();
                btnRegister.FillColor = Color.FromArgb(33, 82, 67);

            }
            else
            {
                timer1.Stop();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (slidePanel.Location.X < 325)
            {
                slidePanel.Location = new Point(slidePanel.Location.X + 10, slidePanel.Location.Y);
                slideLoginPanel.Location = new Point(slideLoginPanel.Location.X - 10, slideLoginPanel.Location.Y);
                slideRegisterPanel.Location = new Point(slideRegisterPanel.Location.X - 10, slideRegisterPanel.Location.Y);
                btnAdminLogin.Enabled = true;
                btnRegister.Enabled = false;
                btnAdminLogin.FillColor = Color.FromArgb(33, 82, 67);

                label3.Hide();
                label4.Show();
                label5.Show();
                label6.Show();
            }
            else
            {
                timer2.Stop();
            }
        }
        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximumSize = Screen.FromRectangle(this.DesktopBounds).WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;
            tbHolder.Visible = false;
            label7.Hide();

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ScannersForm.Close();
            ScannersForm.Dispose();
            Application.Exit();
        }
        #endregion
        #region QRCODE GENERATOR
        public void RegisterQuery()
        {
            
            fullname = tbFname.Text + " " + tbMI.Text + " " + tbLname.Text;
            Classes.SQLControl obj = new Classes.SQLControl();
            Classes.Users user = new Classes.Users(
                fullname.ToUpper(),
                tbEmail.Text,
                tbPhoneNum.Text.ToUpper(),
                tbAddress.Text.ToUpper()
                );
            obj.CheckIfExist(user.getFullname(), user.getEmail(), user.getPhonenum(), user.getAddress());
        }
        private void btnFormReg_Click(object sender, EventArgs e)

        {
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=;database=scanango");
            DataTable resultTable = new DataTable("EMAIL");
            con.Open();
            MySqlDataAdapter Da = new MySqlDataAdapter();
            Da.SelectCommand = new MySqlCommand();
            Da.SelectCommand.Connection = con;
            Da.SelectCommand.CommandType = CommandType.Text;
            Da.SelectCommand.CommandText = "SELECT email FROM tblRegistered WHERE email = '" + tbEmail.Text + "'";
            Da.Fill(resultTable);


            if (resultTable.Rows.Count > 0)
            {
                label7.Text  = resultTable.Rows[0]["email"].ToString();               
                con.Close();
            }
            else
            {             
                con.Close();
            }
            con.Close();


            fname = tbFname.Text + " " + tbMI.Text + " " + tbLname.Text;
            //Embede data in textboxes
            QRCode_data Embed = new QRCode_data();
            Embed.FirstName = tbFname.Text.ToUpper();
            Embed.MiddleName = tbMI.Text.ToUpper();
            Embed.LastName = tbLname.Text.ToUpper();
            Embed.Email = tbEmail.Text;
            Embed.Num = tbPhoneNum.Text.ToUpper();
            Embed.Add = tbAddress.Text.ToUpper();

            //check for empty Textbox
            if (string.IsNullOrEmpty(Embed.FirstName) || (string.IsNullOrEmpty(Embed.LastName) || (string.IsNullOrEmpty(Embed.Email) || (string.IsNullOrEmpty(Embed.Num) || (string.IsNullOrEmpty(Embed.Add))))))
            {
                validation();
                return;
            }
            //Check if file name already exists 
            else if (File.Exists(@"C:\SCANAN-GO\" + Embed.LastName + "," + Embed.FirstName + ".png"))
                {
                MessageBox.Show("File Exist");              
                clear();
                return;      
                }
            else if(tbEmail.Text == label7.Text )
            {
                MessageBox.Show("Email Already Registered");
                clear();
                return;
                
            }
            //perform qr generate
            else
            {
                DialogResult dialogresult = MessageBox.Show($"PLEASE CONFIRM THE REGISTRATION OF {tbFname.Text}?", "CONFIRMATION", MessageBoxButtons.OKCancel);
                if (dialogresult == DialogResult.OK)
                {
                    
                    RegisterQuery();
                    //data listed in the QRCODE
                    tbHolder.AppendText(Embed.FirstName.ToString() + Environment.NewLine);
                    tbHolder.AppendText(Embed.MiddleName.ToString() + Environment.NewLine);
                    tbHolder.AppendText( Embed.LastName.ToString() + Environment.NewLine);
                    tbHolder.AppendText( Embed.Email.ToString() + Environment.NewLine);
                    tbHolder.AppendText(Embed.Num.ToString() + Environment.NewLine);
                    tbHolder.AppendText(Embed.Add.ToString() + Environment.NewLine);

                    //QRCode Writer
                    BarcodeWriter write = new BarcodeWriter();
                    //QR
                    write.Format = BarcodeFormat.QR_CODE;
                    // embeding data into qr image and save to specified location wit filename
                    write.Write(tbHolder.Text).Save(@"C:\SCANAN-GO\" + Embed.LastName + "," + Embed.FirstName + ".png");

                    //send email
                    try
                    {
                        MailMessage mail = new MailMessage();
                        SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                        mail.From = new MailAddress("info.scanan.go@gmail.com");
                        mail.To.Add(Embed.Email);
                        mail.Subject = "SCANAN-GO";
                        mail.Body = "Welcome! This is your generated QRcode containing your basic contact information ";
                        System.Net.Mail.Attachment attachment;
                        attachment = new System.Net.Mail.Attachment(@"C:\SCANAN-GO\" + Embed.LastName + "," + Embed.FirstName + ".png");
                        mail.Attachments.Add(attachment);
                        smtp.Port = 587;
                        smtp.Credentials = new System.Net.NetworkCredential("info.scanan.go@gmail.com", "usukdiebezbsaqjf");
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                        MessageBox.Show("Email has been Succesfully sent", "Email Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    
                    //clear all data in textbox 
                    clear();
                }
                else if (dialogresult == DialogResult.Cancel)
                {
                    clear();
                }
            }
        }
        #endregion
        #region Clear Function
        private void clear()
        {
            tbFname.Clear();
            tbMI.Clear();
            tbLname.Clear();
            tbEmail.Clear();
            tbPhoneNum.Clear();
            tbAddress.Clear();
            tbHolder.Clear();
            tbUsername.Clear();
            tbPassword.Clear();
        }
        #endregion
        #region Validation
        private Boolean validation()
        {
            bool value = true;
            if (tbFname.Text.Length == 0)
            {
                errorProvider1.SetError(tbFname, "Firstname is required");
                tbFname.Focus();
                return false;
            }
            else if (tbLname.Text.Length == 0)
            {
                errorProvider1.SetError(tbLname, "Lastname is required");
                tbLname.Focus();
                return false;
            }
            else if (tbEmail.Text.Length == 0)
            {
                errorProvider1.SetError(tbEmail, "Email is required");
                tbEmail.Focus();
                return false;
            }
            else if (tbPhoneNum.Text.Length == 0)
            {
                errorProvider1.SetError(tbPhoneNum, "Phone Number is required");
                tbPhoneNum.Focus();
                return false;
            }
            else if (tbAddress.Text.Length == 0)
            {
                errorProvider1.SetError(tbAddress, "Address is required");
                tbAddress.Focus();
                return false;
            }
            return value;
        }
        #endregion
        #region 3 attempts
        public void AdminLogin()
        {
            count++;          
            Classes.SQLControl obj = new Classes.SQLControl();
            Classes.admin admin = new Classes.admin(
                tbUsername.Text,
                tbPassword.Text
                );        
            obj.Login(admin.getUsername(), admin.getPassword());
            clear();  
            if(count >= 3)
            {
                
                MessageBox.Show("Sorry you have reached the number of log-in attempts");
                Application.Exit();
                //shutdown computer 
                var psi = new ProcessStartInfo("shutdown", "/s /t 0");
                psi.CreateNoWindow = true;
                psi.UseShellExecute = false;
                Process.Start(psi);
            }
        }
        #endregion
        #region Click UI Functions
        public void btnSignin_Click(object sender, EventArgs e)
        {
            username = tbUsername.Text;
            password = tbPassword.Text;
            AdminLogin();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ScannersForm.ShowDialog();
            
        }

        private void toggleLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (tbPassword.UseSystemPasswordChar == true)
            {
                tbPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbPassword.UseSystemPasswordChar = true;

            }

        }
        private void tbPhoneNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void tbPhoneNum_TextChanged(object sender, EventArgs e)
        {
            tbPhoneNum.MaxLength = 11;
        }
        #endregion
    }

}
