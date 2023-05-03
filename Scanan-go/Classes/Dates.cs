using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scanan_go.Classes
{
   public class Dates
    {
        private string date1;
        private string date2;

        // empty parameters
        public Dates()
        {

        }

        //overload parameters
        public Dates(string _date1,string _date2)
        {
            this.date1 = _date1;
            this.date2 = _date2;
        }

        //properties
        public string getDate1()
        {
            return date1;
        }
        public string getDate2()
        {
            return date2;
        
        }
    }
}
