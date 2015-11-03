using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FortuneCookieLibrary
{
    public class FortuneCookie
    {
        private readonly string _name;

        public FortuneCookie(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("The name cannot be empty.", "name");
            }

            this._name = name;
        }

        public string TellMeMyFortune()
        {
            this.CheckFortune();
            
            return this.fortunes.PickRandom();
        }

        public bool WillIMarryARichPerson()
        {
            // This is a very complex calculation
            var entropy = DateTime.Now.Millisecond * Math.Pow(3, 5) / Math.Log(this._name.Length);

            var result = true;
            for (int i = 0; i < (entropy + 1) * 5; i++)
            {
                result &= this.WillIMarryARichPerson();
            }

            return result;
        }

        private static Random randomObject = new Random();

        public void CheckFortune()
        {
            if (randomObject.Next(5) == 1)
            {
                throw new BadLuckException("No fortune for you today.");
            }
        }

        #region Secret fortune 
        private readonly IEnumerable<string> fortunes = new List<string>()
        {
            "A friend asks only for your time not your money.",
            "If you refuse to accept anything but the best, you very often get it.",
            "A smile is your passport into the hearts of others.",
            "Today it's up to you to create the peacefulness you long for.",
            "A good way to keep healthy is to eat more Chinese food.",
            "Your high-minded principles spell success.",
            "Hard work pays off in the future, laziness pays off now.",
            "Change can hurt, but it leads a path to something better.",
            "Enjoy the good luck a companion brings you.",
            "People are naturally attracted to you.",
            "Hidden in a valley beside an open stream- This will be the type of place where you will find your dream.",
            "A chance meeting opens new doors to success and friendship.",
            "You learn from your mistakes... You will learn a lot today.",
            "If you have something good in your life, don't let it go!",
            "What ever you're goal is in life, embrace it visualize it, and for it will be yours",
            "Your shoes will make you happy today",
            "You cannot love life until you live the life you love",
            "Be on the lookout for coming events; They cast their shadows beforehand.",
            "Land is always on the mind of a flying bird",
            "The man or woman you desire feels the same about you",
            "Meeting adversity well is the source of your strength",
            "A dream you have will come true",
            "Our deeds determine us, as much as we determine our deeds",
            "Never give up. You're not a failure if you don't give up",
            "You will become great if you believe in yourself",
            "There is no greater pleasure than seeing your loved ones prosper",
            "You will marry your lover",
            "A very attractive person has a message for you",
            "You already know the answer to the questions lingering inside your head",
            "It is now, and in this world, that we must live",
            "You must try, or hate yourself for not trying",
            "You can make your own happiness",
            "The greatest risk is not taking one",
            "The love of your life is stepping into your planet this summer",
            "Love can last a lifetime, if you want it to",
            "Adversity is the parent of virtue",
            "Serious trouble will bypass you",
            "A short stranger will soon enter your life with blessings to share",
            "Now is the time to try something new",
            "Wealth awaits you very soon",
            "If you feel you are right, stand firmly by your convictions",
            "If winter comes, can spring be far behind?",
            "Keep your eye out for someone special",
            "You are very talented in many ways",
            "A stranger, is a friend you have not spoken to yet",
            "A new voyage will fill your life with untold memories",
            "You will travel to many exotic places in your lifetime",
            "Your ability for accomplishment will follow with success",
            "Nothing astonishes men so much as common sense and plain dealing",
            "Its amazing how much good you can do if you dont care who gets the credit"
        };
        #endregion

        public IEnumerable<string> TellMeMyManyFortunes()
        {
            return this.TellMeMyManyFortunes(10);
        }

        public IEnumerable<string> TellMeMyManyFortunes(int count)
        {
            for (int i = 0; i < count; i++)
            {
                // We simulate that reading fortune is a costly exercise, this way the believers think it is more realistic
                Thread.Sleep(1000);
                yield return this.fortunes.PickRandom();
            }
        }
    }
}
