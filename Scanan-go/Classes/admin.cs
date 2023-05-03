using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scanan_go.Classes
{
    public class admin
    {

        private string username;
        private string password;

        // empty parameter
        public admin()

        {

        }

        public admin(string _username, string _password)
        {
            this.username = _username;
            this.password = _password;
        }
        // properties
        public string getUsername()
        {
            return username ;
        }
        public string getPassword()
        {
            return password;
        }
    }
}
