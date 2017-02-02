using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Courses;

namespace University.Users
{
    public class Administrator : User
    {
        public override string GetInfo()
        {
            return base.ToString();
        }

        /// <summary>
        /// only the admin is able to set a new password
        /// </summary>
        /// <param name="password">the new password string to be set for a particular student</param>
        public void setPassword(string password)
        {
            this.password = password;
        }
    }
}
