using System;
using System.Linq;
using StackExchange.Redis;

namespace Task01
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string connectionString = "redis-19876.c72.eu-west-1-2.ec2.cloud.redislabs.com";
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("redis-19876.c72.eu-west-1-2.ec2.cloud.redislabs.com:19876,password=cg7bY38Ry4NjsESqKVeVXKSgD1CPc1lj,ConnectTimeout=10000,allowAdmin=true");
            IDatabase database = redis.GetDatabase();
            IServer server = redis.GetServer(connectionString, 19876);

            database.StringSet("test 1", "value 1");
            database.StringSet("test 2", "value 2");

            Console.WriteLine(database.StringGet("test 1"));
            Console.WriteLine(database.StringGet("test 2"));

            database.StringSet("test 2", "value 3");

            Console.WriteLine(database.StringGet("test 2"));

            if (database.KeyExists("test 3"))
            {
                Console.WriteLine(database.StringGet("test 3"));
            }
            else
            {
                Console.WriteLine("No value");
            }

            Console.WriteLine(database.StringGet("test 1"));
            Console.WriteLine(database.StringGet("test 2"));
        }
    }
}
