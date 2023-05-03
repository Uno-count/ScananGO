using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Scanan_go.Classes
{
    public class SQLControl
    {
        Classes.connection obj = new Classes.connection();

        #region Check if Exist in the Registered 
        // check if exist and add data
        public string CheckIfExist(string fullsname, string email, string phoneNo, string address)
        {
            MySqlConnection con = obj.Activecon();
            MySqlCommand cmdcheck = new MySqlCommand("SELECT * FROM tblRegistered WHERE fullname = '" + (fullsname) + "' or email = '" + (email) + "'", con);
            MySqlDataAdapter sdacheck = new MySqlDataAdapter(cmdcheck);
            DataTable dtcheck = new DataTable();
            sdacheck.Fill(dtcheck);

            if (dtcheck.Rows.Count > 0)
            {
                // Record already exists
                return "Record already exists";
            }
            else
            {
                // Insert new record
                MySqlCommand cmd = new MySqlCommand("INSERT INTO tblRegistered(fullname,email, phoneNo, address) VALUES ('" + (fullsname) + "','" + (email) + "','" + (phoneNo) + "','" + (address) + "' ) ", con);
                MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                return fullsname;
            }
        }

        // checking if the data exist
        private static void NewMethodcheck(DataTable dtcheck, MySqlCommand cmd)
        {
            
            if (dtcheck.Rows.Count > 0)
            {
                System.Windows.Forms.MessageBox.Show("ACCOUNT EXIST");
                //Form2 frm2 = new Form2();
                // frm2.Show();      
            }
            else
            {
                if (cmd.ExecuteNonQuery().Equals(1))
                {
                    //System.Windows.Forms.MessageBox.Show("REGISTERED SUCCESFUL");
                }
                else
                {
                   // System.Windows.Forms.MessageBox.Show("REGISTERED SUCCESFUL");
                }
            }
        }
        #endregion
        // database login
        #region Login Query
        public string Login(string username, string password)
        {
            MySqlConnection con = obj.Activecon();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tblAdmin Where username = '" + (username) + "' and password = '" + (password) + "'", con);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            NewMethod(dt);
            con.Close();
            return username;
        }

        private static void NewMethod(DataTable dt)
        {
           
            if (dt.Rows.Count > 0)
            {
                System.Windows.Forms.MessageBox.Show("WELCOME");
                AdMain_Form adminform = new AdMain_Form();
                adminform.ShowDialog();
                Form1 frm1 = new Form1();
                frm1.Close();
                frm1.Dispose();
            }
            else
            {                          
                System.Windows.Forms.MessageBox.Show("wrong username or password");
                

            }
        }
        #endregion
        #region Admin Main Form
        public string MonitoringDatabase(string fullname, string email, string phoneNo, string address, string date, string time)
        {
            MySqlConnection con = obj.Activecon();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO tblMonitoring(FullName, Email, PhoneNum, Address, date, time) VALUES(@fullname, @email, @phoneNo, @address, @date, @time) ON DUPLICATE KEY UPDATE FullName = VALUES(FullName), Email = VALUES(Email)", con);
            cmd.Parameters.AddWithValue("@fullname", fullname);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@phoneNo", phoneNo);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@time", time);
            cmd.ExecuteNonQuery();

            MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM tblRegistered WHERE FullName = @fullname AND Email = @email", con);
            cmd1.Parameters.AddWithValue("@fullname", fullname);
            cmd1.Parameters.AddWithValue("@email", email);
            MySqlDataAdapter sda1 = new MySqlDataAdapter(cmd1);
            DataTable dt = new DataTable();
            sda1.Fill(dt);
            NewMethod1(dt);
            con.Close();
            return fullname;
        }

        private static void NewMethod1(DataTable dt)
        {
            if (dt.Rows.Count > 0)
            {
                frmWelcome frmwelcome = new frmWelcome();
                frmwelcome.ShowDialog(); 
            }
            else
            {
                frmUnregistered unregistered = new frmUnregistered();
                unregistered.ShowDialog();
             
            }
            return;
        }
        public string fetchRegistered(string sql, DataGridView grid)
        {
            MySqlConnection con = obj.Activecon();
            MySqlCommand cmd = new MySqlCommand("SELECT fullname, email, phoneNo, address FROM tblRegistered", con);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            grid.DataSource = dt;
            return sql;
        }

        public string findingRegistered(string search, DataGridView grid)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tblRegistered WHERE CONCAT(fullname,email,phoneNo,address) LIKE '%" + search + "%'", obj.Activecon());
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            grid.DataSource = dt;
            return search;
        }

        public string fetchMonitoring(string sql, DataGridView grid)
        {
            MySqlConnection con = obj.Activecon();
            MySqlCommand cmd = new MySqlCommand("SELECT FullName, Email, PhoneNum, Address, date, time FROM tblMonitoring", con);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            grid.DataSource = dt;
            return sql;
        }

        public string findingMonitoring(string search, DataGridView grid)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT FullName, Email, PhoneNum, Address, date, time FROM tblMonitoring WHERE CONCAT(FullName, Email, PhoneNum, Address, date, time) LIKE '%" + search + "%'", obj.Activecon());
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            grid.DataSource = dt;
            return search;
        }

        public string fetchingDatetoDate(string dateFrom, string dateTo, DataGridView grid)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT FullName, Email, PhoneNum, Address, date, time FROM tblMonitoring WHERE date BETWEEN '" + (dateFrom) + "' and '" + (dateTo) + "' ", obj.Activecon());
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            grid.DataSource = dt;
            return dateFrom;
        }

        public string fetchAdmin(string sql, DataGridView grid)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tblAdmin", obj.Activecon());
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            grid.DataSource = dt;

            return sql;
        }

        public string InsertAdmin(string usertype, string username, string password)
        {
            MySqlConnection con = obj.Activecon();
            MySqlCommand cmdcheck = new MySqlCommand("SELECT * FROM tblAdmin WHERE username = '" + (username) + "' or password = '" + (password) + "'", con);
            MySqlDataAdapter sdacheck = new MySqlDataAdapter(cmdcheck);
            DataTable dtcheck = new DataTable();
            sdacheck.Fill(dtcheck);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO tblAdmin(usertype, username, password) VALUES ('" + (usertype) + "','" + (username) + "','" + (password) + "' ) ", con);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            NewMethodcheck2(dtcheck, cmd);
            return usertype;
        }






        // checking if the data exist
        private static void NewMethodcheck2(DataTable dtcheck, MySqlCommand cmd)
        {
            if (dtcheck.Rows.Count > 0)
            {
                System.Windows.Forms.MessageBox.Show("ACCOUNT EXIST");
                //Form2 frm2 = new Form2();
                // frm2.Show();      
            }
            else
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Added");
                
            }
        }
        public string DeleteAdmin(string id)
        {
            MySqlConnection con = obj.Activecon();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM tblAdmin WHERE id = '" + (id) + "'", con);
            DialogResult dialogResult = MessageBox.Show($"you want to delete ?", "CONFIRMATION", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                cmd.ExecuteNonQuery();
            }
            else
            {
                return id;
            }

            //MessageBox.Show("done");
            return id;
        }

        public string UpdateAdmin(string usertype, string username, string password, string id)
        {
            MySqlConnection con = obj.Activecon();
            MySqlCommand cmd = new MySqlCommand("UPDATE tblAdmin SET usertype = '" + (usertype) + "', username = '" + (username) + "', password = '" + (password) + "' WHERE id = '" + (id) + "'", con);
            System.Windows.Forms.DialogResult dialogResult = MessageBox.Show($"you want to update ?", "CONFIRMATION", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                cmd.ExecuteNonQuery();
            }
            else
            {
                return id;
            }

            //MessageBox.Show("done");
            return id;
        }

        #endregion
    }
}
