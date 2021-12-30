using System;
using System.Collections.Generic;
using System.Text;

namespace Triple_G_System
{
    class Users
    {

        private string name;
        private string email;
        private string password;

        public Users()
        {

        }

        public Users(string user_name, string user_email, string user_password )
        {
            name = user_name;
            email = user_email;
            password = user_password;
           
        }

        public bool ValidEmail(string emailAddress)
        {
            if(!emailAddress.Contains("@") || emailAddress.Length <6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool ValidPassword(string password)
        {
            if (password.Length > 7)
            {
                return true;
            }
            else
            {
                return false;
            }
        }       


    }
}
