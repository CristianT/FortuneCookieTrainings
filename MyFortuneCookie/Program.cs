using FortuneCookieLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFortuneCookie
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = string.Empty;

            while (name != "exit")
            {
                try
                {
                    while (string.IsNullOrEmpty(name))
                    {
                        Console.WriteLine("Tell me your name:");
                        name = Console.ReadLine();

                        if (string.IsNullOrEmpty(name))
                        {
                            Console.WriteLine("Please enter a correct name.");
                        }
                    }

                    var fortuneTeller = new FortuneCookie(name);
                    var fortune = fortuneTeller.TellMeMyFortune();

                    Console.WriteLine(fortune);
                }
                catch (BadLuckException)
                {
                    Console.WriteLine("Bad luck for now, try again.");
                }
            }

            Console.WriteLine("Press a key to exit...");
            Console.ReadLine();
        }
    }
}
