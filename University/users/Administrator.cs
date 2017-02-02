using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Users
{
    public class Administrator : User
    {
        public override string GetInfo()
        {
            return base.ToString();
        }

        public void setPassword(string password)
        {
            this.password = password;
        }
    }
}
