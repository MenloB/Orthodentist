using StackExchange.Redis;

namespace RedisDataLayer
{
    public static class DataProvider
    {
        public static RedisValue GetPost(string id)
        {
            IDatabase db = SessionManager.GetDatabase();

            return db.StringGet(id);
        }
    }
}
