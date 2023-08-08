using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secure_Password
{
    internal class LoginManager
    {
        int loginAttempts = 5;

        HashManager hashManager;
        DatabaseManager databaseManager;
        User user;
        public LoginManager()
        {
            user = new User();
            hashManager = new HashManager();
            databaseManager = new DatabaseManager(user);
        }
        public string CreateUser(string username, string password)
        {
            byte [] salt = hashManager.GenerateSalt();
            Debug.WriteLine(Encoding.ASCII.GetBytes(password));
            Debug.WriteLine(salt);
            string hash = Convert.ToBase64String(hashManager.HashPassword(Encoding.UTF8.GetBytes(password),salt));
            return databaseManager.SaveUserToDatabase(username, hash, Convert.ToBase64String(salt));
        }
        public string ValidatePassword(string username,string password)
        {
            string hashWithSalt;
            databaseManager.GetUserFromDatabase(username);
            

            hashWithSalt = Convert.ToBase64String(hashManager.HashPassword(Encoding.UTF8.GetBytes(password), Convert.FromBase64String(user.Salt)));
            Debug.WriteLine(hashWithSalt + " " + user.Hash);
            if(hashManager.CheckHash(Convert.FromBase64String(hashWithSalt), Convert.FromBase64String(user.Hash)) && loginAttempts > 0)
            {
                return "Login succeded";
            }
            else if(loginAttempts > 0)
            {
                loginAttempts--;
                return "Wrong password";
            }
            else
            {
                return "Too many attemtps";
            }
        }

    }
}
