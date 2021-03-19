using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Threading.Tasks;
using KFC.Modals;

namespace KFC.Data
{
    public class UserDatabaseController
    {
        static Object locker = new Object();
        SQLiteConnection database;

        public UserDatabaseController()
        {

            database = DependencyService.Get<SQLlite>().GetConnection();
            database.CreateTable<User>();
        }

        public User GetUser(int i)
        {

            if (database.Table<User>().Count() == 0)
            {
                return null;
            }
            else
            {
                return database.Table<User>().ElementAt(i);
            }
        }

        public int SaveUser(User user)
        {
            lock (locker)
            {

                if (user.iId != 0)
                {
                    database.Update(user);
                    return user.iId;
                }
                else
                {
                    return database.Insert(user);
                }
            }
        }

        public int DeleteUser(int id)
        {
            lock (locker)
            {
                return database.Delete<User>(id);
            }
        }
        public int getUserCount()
        {



            return database.Table<User>().Count();

        }
    }
}
