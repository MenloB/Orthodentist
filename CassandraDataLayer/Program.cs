using System;
using CassandraDataLayer.QueryEntities;

namespace CassandraDataLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = DataProvider.GetUserByUsername("r1dl3r");

            Console.WriteLine(user.ToString());
            Console.ReadKey();
        }
    }
}
