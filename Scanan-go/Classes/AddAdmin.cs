using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scanan_go.Classes
{
    public class AddAdmin
    {
        private string usertype;
        private string username;
        private string password;


        public AddAdmin()
        {

        }
        public AddAdmin(string _usertype, string _username, string _password)
        {
            this.usertype = _usertype;
            this.username = _username;
            this.password = _password;

        }

        public string GetUsertype()
        {
            return usertype;
        }
        public string GetUsername()
        {
            return username;
        }
        public string GetPassword()
        {
            return password;
        }
    }
}
