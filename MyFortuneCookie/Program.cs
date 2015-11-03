using FortuneCookieLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MyFortuneCookie
{
    class Program
    {
        static void Main(string[] args)
        {
            SetUpExceptionHandling();

            var name = string.Empty;

            while (name != "exit")
            {
                Log("Tell me your name:");
                name = Console.ReadLine();

                var fortuneTeller = new FortuneCookie(name);

                Log("Reading fortunes...");
                var fortunes = fortuneTeller.TellMeMyManyFortunes();

                Log("Fortunes prepared...");

                Log("Do you have fortunes? " + fortunes.Any());

                Log("How many? " + fortunes.Count());

                foreach (var fortune in fortunes)
                {
                    Log(fortune);
                }
            }

            Console.WriteLine("Press a key to exit...");
            Console.ReadLine();
        }

        private static void Log(string s)
        {
            var timeStamp = DateTime.Now;

            Console.WriteLine(timeStamp.ToString("HH:mm:ss.fff - ") + s);
        }

        private static void SetUpExceptionHandling()
        {
            AppDomain.CurrentDomain.UnhandledException += (object sender, UnhandledExceptionEventArgs e) =>
            {
                Console.WriteLine("I predict bad fortune during the next seconds... press enter to see it...");
                Console.ReadLine();

                Environment.FailFast("Unable to recover from such bad luck!");
            };
        }
    }
}
