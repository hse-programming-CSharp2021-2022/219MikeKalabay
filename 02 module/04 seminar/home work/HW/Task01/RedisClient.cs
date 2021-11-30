using System;
using StackExchange.Redis;

namespace Task01
{
    public static class RedisClient
    {
        public const uint MaxCount = 5;
        
        private static ConnectionMultiplexer redis;
        private static IDatabase database;

        public static void Connect(string connectionString = "redis-17130.c226.eu-west-1-3.ec2.cloud.redislabs.com:17130,password=K8oksHvcmmOtD2rk3QCSH9q0pBNgxRb9,ConnectTimeout=10000,allowAdmin=true")
        {
            redis = ConnectionMultiplexer.Connect(connectionString);
            database = redis.GetDatabase();
        }

        public static string Get(string key)
        {
            if (!Exist(key))
            {
                return "Нет версий.";
            }
            return database.ListGetByIndex(key, database.ListLength(key) - 1);
        }

        public static bool Exist(string key)
        {
            return database.KeyExists(key);
        }

        public static void Add(string key, string value)
        {
            database.ListRightPush(key, value);
            if (database.ListLength(key) > MaxCount)
            {
                database.ListLeftPop(key);
            }
        }

        public static string Back(string key)
        {
            if (!Exist(key))
            {
                return "Нет версий.";
            }
            if (database.ListLength(key) == 1)
            {
                database.KeyDelete(key);
                return "Нет предыдущей версии.";
            }
            database.ListRightPop(key);
            return database.ListGetByIndex(key, database.ListLength(key) - 1);
        }
    }
}