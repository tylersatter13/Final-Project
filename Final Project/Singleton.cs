using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public sealed class Singleton
    {
        private static Singleton instance = null;
        private static readonly object padlock = new object();
        private User user;
        private bool userIsSet = false;
        Alert alert = new Alert();
  
        Singleton() { }
  
        public void setUpUser(String username, int UserRoleID)
        {
            if (userIsSet == false)
            {
                user = new User(username, UserRoleID);
                userIsSet = true;
            }
            else
            {
                alert.CreateBasicAlert(1, "User is already set. Logout to changes users", "Notice");

            }
            
        }
        public static Singleton Instance
        {
            get{
                lock (padlock)
                {
                    if (instance == null) {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }

        internal User User { get => user; set => user = value; }
    }
    

}
