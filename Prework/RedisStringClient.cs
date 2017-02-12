using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prework
{
    public class RedisStringClient
    {
        public const string StringChangeChannel = "string-change";
        private readonly IDatabase _redisDatabase;

        public RedisStringClient(IDatabase redisDatabase)
        {
            _redisDatabase = redisDatabase;
        }

        public void Set(string key, string value)
        {
            _redisDatabase.StringSet(key, value);
            _redisDatabase.Publish(StringChangeChannel, key+":"+value);
        }

        public void GetValue(string key)
        {
            _redisDatabase.StringGet(key);
        }
    }
}
