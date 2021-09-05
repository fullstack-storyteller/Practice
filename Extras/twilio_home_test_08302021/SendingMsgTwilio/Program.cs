using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace SendingMsgTwilio
{
    class Program
    {
        static void Main(string[] args)
        {
            string accountSid = "ACa8c54f7eeffdbf5e0ad00a6c144ae2cf";
            string authToken = "d17f311941856d4c985bb51baeb084ec";
            string fromPhoneNumber = "+15867855091";
            string[] toPhones = { "1112223333", "2223334444", "3334445555", "1234567890","9876543210" };
            string messageBody = "This is a test message.";
            SendMessage(accountSid, authToken, fromPhoneNumber, messageBody, toPhones);
            
            Console.ReadKey();
        }
        static void SendMessage(string accountSid, string authToken, string fromPhoneNumber, string messageBody, string[] toPhoneNumbers )
        {
            try
            {
                TwilioClient.Init(accountSid, authToken);//initialize the client

                foreach (string toPhoneNumber in toPhoneNumbers)
                {
                    var message = MessageResource.Create(
                            body: messageBody,
                            from: new Twilio.Types.PhoneNumber(fromPhoneNumber),
                            to: new Twilio.Types.PhoneNumber(toPhoneNumber));
                    Console.WriteLine(message.Sid);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                Console.WriteLine(exception.StackTrace);
            }
        }
    }
}
