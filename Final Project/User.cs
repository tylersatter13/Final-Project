using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class User
    {
        private String UserName;
        private int UserRoleID;
            
        public User(String UserName, Int32 UserRoleID)
        {
            this.UserName = UserName;
            this.UserRoleID = UserRoleID;
        }
        
        public String getUserName()
        {
            return UserName;
        }
        public int getUserRoleID()
        {
            return UserRoleID;
        }
    }
}
