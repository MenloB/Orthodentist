namespace CassandraDataLayer.QueryEntities
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName  { get; set; }
        public string Email     { get; set; }
        public string Username  { get; set; }

        public string ToString()
        {
            return "First Name: " + FirstName + "\n"
                + "Last Name: " + LastName + "\n"
                + "Email: " + Email + "\n"
                + "Username: " + Username;
        }
    }
}
