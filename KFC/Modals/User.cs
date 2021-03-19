using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace KFC.Modals
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int iId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }


        public User() { }

        public User(string Username, string Password)
        {

            this.Username = Username;
            this.Password = Password;
        }

        public bool Check()
        {
            try
            {
                if (!this.Username.Equals("") && !this.Password.Equals(""))
                {
                    return true;
                }
                else
                {


                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
