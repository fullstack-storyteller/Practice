// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using StackExchange.Redis;

public class RedisDataCapture
{
    static string redisHost = "localhost";
    static string redisPort = "6379";
    static string redisKey = "mykey1";

    //static readonly ConnectionMultiplexer redis = ConnectionMultiplexer.Connect(
    //        new ConfigurationOptions
    //        {
    //            EndPoints = { string.Format("{0}:{1}", redisHost, redisPort) },
    //            AbortOnConnectFail = false,
    //            ConnectTimeout = 30000
    //        });
    //public static async Task Main(string[] args)
    public static void Main(string[] args)
    {
        ConnectionMultiplexer redis = ConnectionMultiplexer.Connect(
            new ConfigurationOptions
            {
                EndPoints = { string.Format("{0}:{1}", redisHost, redisPort) },
                AbortOnConnectFail = false,
                ConnectTimeout = 30000
            });
        try
        {
            var db = redis.GetDatabase();
            var pong =  db.Ping();
            //var pong = await db.PingAsync();
            Console.WriteLine(pong);
            //var myvalue = await db.StringGetAsync(redisKey);
            var myvalue =  db.StringGet(redisKey);
            if (RedisValue.Null == myvalue)
                Console.WriteLine("No value present in cache for {0}", redisKey);

            else

                Console.WriteLine("{0}: {1}", redisKey, myvalue);
        }
        catch (RedisTimeoutException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }


    }
}