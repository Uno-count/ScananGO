using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scanan_go.Classes
{
   public class MonitoringDatabase
    {
        private string fullname;
        private string email;
        private string phoneNo;
        private string address;


        // empty parameter
       
        public MonitoringDatabase()
        {

        }
        // overload parameters
        public MonitoringDatabase(string _fullname, string _email, string phoneNo, string _address)
        {
            this.fullname = _fullname;
            this.email = _email;
            this.phoneNo = phoneNo;
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
        public string getPhoneNo()
        {
            return phoneNo;
        }
        public string getAddress()
        {
            return address;
        }
    }
}
