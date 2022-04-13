// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

using StackExchange.Redis;

using System.Threading.Tasks;
class Program
{
    static readonly ConnectionMultiplexer redis = ConnectionMultiplexer.Connect(
            new ConfigurationOptions
            {
                AbortOnConnectFail = false,
                EndPoints = { 
                    "localhost:6379"
                    //"myredis.6z0rww.ng.0001.aps1.cache.amazonaws.com:6379"
                //    ,"myredis-ro.6z0rww.ng.0001.aps1.cache.amazonaws.com:6379"
                },ConnectTimeout =30000
                ,
                User = {}
            });
    //public static void Main(string[] args)
    //{
    //    Console.WriteLine("Hello World!");
    //}
    static async Task Main(string[] args)
    {
        var db = redis.GetDatabase();
        var pong = await db.PingAsync();
        Console.WriteLine(pong);
    }
}
