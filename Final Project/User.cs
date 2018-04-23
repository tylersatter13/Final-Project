using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class User
    {
        private String strUserName;
        private int intRole;
        private String strUserID;

        public User(String strUserName, int intRole, String strUserID)
        {
            this.strUserName = strUserName;
            this.intRole = intRole;
            this.strUserID = strUserID;
        }
        public String getUserName()
        {
            return strUserName;
        }
        public int getIntRole()
        {
            return intRole;
        }
        public String getStrUserId()
        {
            return strUserID;
        }

    }
}
