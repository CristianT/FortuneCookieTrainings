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

            while (true)
            {
                var name = string.Empty;

                while (name.Length == 0)
                {
                    Console.WriteLine("Tell me your name:");
                    name = Console.ReadLine();

                    if(string.IsNullOrEmpty(name))
                    {
                        Console.WriteLine("Please specify a name.");
                    }
                }

                if (name == "exit")
                {
                    break;
                }

                try
                {
                    var fortuneTeller = new FortuneCookie(name);
                    var fortune = fortuneTeller.TellMeMyFortune();

                    Console.WriteLine(fortune);
                }
                catch (BadLuckException)
                {
                    Console.WriteLine("I can't tell your fortune now, try again later.");
                }
            }

            Console.WriteLine("Press a key to exit...");
            Console.ReadLine();
        }
    }
}
