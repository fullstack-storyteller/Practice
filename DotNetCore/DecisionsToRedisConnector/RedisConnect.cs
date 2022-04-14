﻿using System;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecisionsFramework.Design.Flow;
using DecisionsFramework.Design.Flow.Mapping;
using DecisionsFramework.Design.Flow.CoreSteps;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;
using StackExchange.Redis;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace DecisionsToRedisConnector
{
    [AutoRegisterStep("Retrieve Data From Redis", "Redis Connector")]
    [Writable]
    public class RedisConnect : BaseFlowAwareStep, ISyncStep, IDataConsumer, IDataProducer
    {
        public override OutcomeScenarioData[] OutcomeScenarios
        {
            get
            {
                return new OutcomeScenarioData[] {
                    new OutcomeScenarioData("Error", new DataDescription[] { new DataDescription(new DecisionsNativeType(typeof(string)), "Error Message", false, true, false)}),
                    new OutcomeScenarioData("Retrieved", new DataDescription[] { new DataDescription(new DecisionsNativeType(typeof(string)), "JSON Output", false, true, false)} ),
                    new OutcomeScenarioData("NotRetrieved")};
            }
        }

        public DataDescription[] InputData {
            //get { throw new NotImplementedException(); }
            get {
                return new DataDescription[] { 
                    new DataDescription(new DecisionsNativeType(typeof(string)), "RedisKeyToCheck"),
                    new DataDescription(new DecisionsNativeType(typeof(string)), "RedisConnectionString"),
                    new DataDescription(new DecisionsNativeType(typeof(bool)), "AbortOnConnectFail"),
                    new DataDescription(new DecisionsNativeType(typeof(int)), "TimeOut")
                };
            }
        }
        
        public ResultData Run(StepStartData data)
        {
            //throw new NotImplementedException();
            string redisKeyToSearch = (string)data.Data["RedisKeyToCheck"];
            string redisConnectionString = (string)data.Data["RedisConnectionString"];
            bool abortOnConnectFail = (bool)data.Data["AbortOnConnectFail"];
            int timeOut = (int)data.Data["TimeOut"];

            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect(
            new ConfigurationOptions
            {
                EndPoints = { redisConnectionString },
                AbortOnConnectFail = abortOnConnectFail,
                ConnectTimeout = timeOut
            });
            try
            {
                var db = redis.GetDatabase();
                var value = db.StringGet(redisKeyToSearch);

                if(value != RedisValue.Null || value != RedisValue.EmptyString)
                {
                    //record retrieved
                    JObject obj = JObject.Parse(value);
                    Dictionary<string, object> resultData = new Dictionary<string, object>();
                    resultData.Add("JSON Output", obj.ToString());
                    return new ResultData("Retrieved", resultData);
                }
                else
                {
                    //record not present 
                    return new ResultData("NotRetrieved");
                }
            }
            catch (Exception ex)
            {
                //exception happened
                Dictionary<string, object> resultData = new Dictionary<string, object>();
                resultData.Add("Error Message", ex.Message);
                return new ResultData("Error", resultData);
            }
        }

    }
}