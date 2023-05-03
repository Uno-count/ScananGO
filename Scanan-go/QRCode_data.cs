using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scanan_go
{
    class QRCode_data
    {
        private string Fname;
        private string Mi;
        private string Lname;
        private string email;
        private string number;
        private string address;
         
        public string FirstName
        {
            get { return Fname; }
            set { Fname = value; }

        }
        public string MiddleName
        {
            get { return Mi; }
            set { Mi = value; }
        }
        public string LastName
        {
            get { return Lname; }
            set { Lname = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Num
        {
            get { return number; }
            set { number = value; }
        }
        public string Add
        {
            get { return address; }
            set { address = value; }
        }
    }
}
