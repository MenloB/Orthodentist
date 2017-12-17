using Cassandra;

namespace CassandraDataLayer
{
    public static class SessionManager
    {
        public static ISession session;

        // GetSession(string) : ISession
        // returns Session object with selected keyspace
        // 
        public static ISession GetSession(string keyspace)
        {
            Cluster cluster = Cluster.Builder().AddContactPoint("127.0.0.1").Build();
            session = cluster.Connect(keyspace);

            return session;
        }
    }
}
