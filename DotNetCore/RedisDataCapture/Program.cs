// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using StackExchange.Redis;

public class RedisDataCapture
{
    static string redisHost = "localhost";
    static string redisPort = "6379";
    static string redisKey = "mytest";


    public static void Main(string[] args)
    {
        //ConnectionMultiplexer redis = ConnectionMultiplexer.Connect(
        //    new ConfigurationOptions
        //    {
        //        EndPoints = { string.Format("{0}:{1}", redisHost, redisPort) },
        //        AbortOnConnectFail = false,
        //        ConnectTimeout = 30000
        //    });
       
        //try
        //{
        //    var db = redis.GetDatabase();
        //    var pong =  db.Ping();
        //    //var pong = await db.PingAsync();
        //    Console.WriteLine(pong);
        //    //var myvalue = await db.StringGetAsync(redisKey);
        //    var myvalue =  db.StringGet(redisKey);
        //    if (RedisValue.Null == myvalue)
        //        Console.WriteLine("No value present in cache for {0}", redisKey);

        //    else

        //        Console.WriteLine("{0}: {1}", redisKey, myvalue);
        //}
        //catch (RedisTimeoutException ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}

        new RedisDataCapture().FindValue(redisHost,redisPort,redisKey);
    }

    public void FindValue(string host, string port, string redisKey)
    {
        try
        {
            RedisCache redisCache = new RedisCache(new ConfigurationOptions()
        {
            EndPoints = { string.Format("{0}:{1}", host, port) },
            AbortOnConnectFail = false,
            ConnectTimeout = 30000
        });
        
            var db = RedisCache.Connection.GetDatabase();
            var pong = db.Ping();
            //var pong = await db.PingAsync();
            Console.WriteLine(pong);
            //var myvalue = await db.StringGetAsync(redisKey);
            var myvalue = db.StringGet(redisKey);
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

public class RedisCache //: IRepositoryCache
{
    private static ConfigurationOptions? _configurationOptions;
    //private readonly CachePrefix _prefix;

    public RedisCache(ConfigurationOptions configurationOptions)//, CachePrefix prefix)
    {
        if (configurationOptions == null) throw new ArgumentNullException("configurationOptions");
        _configurationOptions = configurationOptions;
        //_prefix = prefix;
    }


    //private static IDatabase Cache
    //{
    //    get
    //    {
    //        return Connection.GetDatabase();
    //    }
    //}

    private static readonly Lazy<ConnectionMultiplexer> LazyConnection
      = new Lazy<ConnectionMultiplexer>(() => ConnectionMultiplexer.Connect(_configurationOptions));

    public static ConnectionMultiplexer Connection
    {
        get
        {
            return LazyConnection.Value;
        }
    }
    //public void ClearItem(string key)
    //{
    //    key = _prefix + key;
    //    if (key == null) throw new ArgumentNullException("key");
    //    Cache.KeyDelete(key);
    //}

    // Other cache access methods ommited for brevity
}