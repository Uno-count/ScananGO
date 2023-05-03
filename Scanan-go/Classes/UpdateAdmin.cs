using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scanan_go.Classes
{
    public class UpdateAdmin
    {
        private string getID;
        private string username;
        private string usertype;
        private string password;

        public UpdateAdmin()
        {
        }
        public UpdateAdmin(string _usertype, string _username, string _password, string _getID )
        {
            
            this.usertype = _usertype;
            this.username = _username;
            this.password = _password;
            this.getID = _getID;

        }

        public string GetID()
        {
            return getID;
        }

        public string getUsername()
        {
            return username;
        }
        public string getPassword()
        {
            return password;
        }
        public string getUsertype()
        {
            return usertype;
        }

    }
}
