using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherTweet.Services;

namespace WeatherTweet
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter sw = new StreamWriter(GetFilePath(), true, Encoding.GetEncoding("Shift-JIS")))
            using (TextWriter syncWriter = TextWriter.Synchronized(sw))
            {
                syncWriter.WriteLine("{0} File path : {1}", DateTime.Now.ToString(), GetFilePath());
                try
                {
                    if (args.Length != 4)
                    {
                        syncWriter.WriteLine("[Error] args.Length:{0}", args.Length.ToString());
                        return;
                    }

                    var APIKey = args[0];
                    var APISecret = args[1];
                    var AccessToken = args[2];
                    var AccessTokenSecret = args[3];
                    var tokens = CoreTweet.Tokens.Create(APIKey, APISecret, AccessToken, AccessTokenSecret);
                    syncWriter.WriteLine("[Normal]");

                    var service = new TweetService();
                    var text = service.GetTweetText();
                    System.Diagnostics.Debug.WriteLine(text);
                    tokens.Statuses.Update(status => text);
                }
                catch (Exception ex)
                {
                    syncWriter.WriteLine("[Error] Message:{0}", ex.Message);

                }
            }
        }

        static string GetFilePath()
        {
            return System.Configuration.ConfigurationManager.AppSettings["logFilePath"];
        }
    }
}
