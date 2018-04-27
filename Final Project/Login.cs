using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Login
    {
        public Alert alert = new Alert();
        public bool validateUser(String username, String password)
        {
            var results = fetchUser(username,password);
            
            if (results.Count == 0)
            {
                alert.CreateBasicAlert(3, "Invalid Username or Password", "Error");
                return false;
            }else if (results.Count < 1) {
                alert.CreateBasicAlert(3, "User are only allowed one acoount. Contact Admin" ,"Error");
                return false;
            }
            else
            {
                User user = results[0];
                Singleton singleton = Singleton.Instance;
                singleton.setUpUser(user.getUserName(), user.getUserRoleID());
                return true;
            }
        }
        private List<User> fetchUser(String username, String password)
        {
            Fetch fetch = new Fetch();
            var results = fetch.fetchUserInformation(username, password);

            return results;
        }
    }
}
