using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scanan_go.Classes
{
    public class Users
    {
        private string fullname;
        private string email;
        private string phonenum;
        private string address;

        // empty parameter
        public Users()
        {

        }
        // overload parameter
        public Users(string _fullname, string _email, string _phonenum, string _address)
        {
            this.fullname = _fullname;
            this.email = _email;
            this.phonenum = _phonenum;
            this.address = _address;
        }

        // properties
        public string getFullname()
        {
            return fullname;
        }
        public string getEmail()
        {
            return email;
        }
        public string getPhonenum()
        {
            return phonenum;
        }
        public string getAddress()
        {
            return address;
        }

    }
}
