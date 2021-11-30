using System;
using System.Collections.Generic;
using System.Linq;
using StackExchange.Redis;

namespace Task02
{
    public static class RedisClient
    {
        private static ConnectionMultiplexer redis;
        private static IDatabase database;

        public static void Connect(string connectionString = "redis-17130.c226.eu-west-1-3.ec2.cloud.redislabs.com:17130,password=K8oksHvcmmOtD2rk3QCSH9q0pBNgxRb9,ConnectTimeout=10000,allowAdmin=true")
        {
            redis = ConnectionMultiplexer.Connect(connectionString);
            database = redis.GetDatabase();
        }

        public static void Add(string key, string value)
        {
            database.SetAdd(key, value);
        }

        public static bool Exist(string key)
        {
            return database.KeyExists(key);
        }

        public static bool ExistProduct(string key, string productName)
        {
            if (!Exist(key))
            {
                return false;
            }
            return database.SetContains(key, productName);
        }

        public static string[] ToStringArray(RedisValue[] values)
        {
            return Array.ConvertAll(values, x => (string)x);
        }

        public static List<string> GetProducts(string key)
        {
            if (!Exist(key))
            {
                Console.WriteLine("Склада не существует.");
                return new List<string>();
            }
            RedisValue[] values = database.SetMembers(key);
            List<string> a = new List<string>();
            foreach (string s in ToStringArray(values))
            {
                a.Add(s);
            }
            return a;
        }
    }
}