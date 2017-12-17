using Cassandra;
using CassandraDataLayer.QueryEntities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CassandraDataLayer
{
    public static class DataProvider
    {
        #region USER
        // Returns Username using given username
        public static User GetUserByUsername(string username)
        {
            ISession session = SessionManager.GetSession("dentsoft");
            User u = new User();
            if (session == null)
                return null;

            Row result = session.Execute("select * from user where username='" + username + "'").FirstOrDefault();

            if(result != null)
            {
                u.FirstName = result["first_name"] != null ? result["first_name"].ToString() : String.Empty;
                u.LastName  = result["last_name"] != null ? result["last_name"].ToString() : String.Empty;
                u.Username  = result["username"] != null ? result["username"].ToString() : String.Empty;
                u.Email     = result["email"] != null ? result["email"].ToString() : String.Empty;
            }

            return u;
        }

        public static List<User> GetAllUsers()
        {
            ISession session = SessionManager.GetSession("dentsoft");

            List<User> users = new List<User>();
            User u = new User();

            if (session == null)
                return null;

            RowSet result = session.Execute("select * from user");

            foreach(Row row in result)
            {
                u.FirstName = row["first_name"] != null ? row["first_name"].ToString() : String.Empty;
                u.LastName = row["last_name"] != null ? row["last_name"].ToString() : String.Empty;
                u.Username = row["username"] != null ? row["username"].ToString() : String.Empty;
                u.Email = row["email"] != null ? row["email"].ToString() : String.Empty;

                users.Add(u);
            }

            return users;
        }

        #endregion
    }
}
