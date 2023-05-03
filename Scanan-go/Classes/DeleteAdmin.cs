using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scanan_go.Classes
{
    public class DeleteAdmin
    {

        private string  getID;

        public DeleteAdmin()
        {
        }
        public DeleteAdmin(string _getID)
        {
            this.getID = _getID;
        }

        public string GetID()
        {
            return getID;
        }
    }
}
