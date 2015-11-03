using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneCookieLibrary
{
    public static class EnumerableExtension
    {
        public static T PickRandom<T>(this IEnumerable<T> source)
        {
            source.CheckNotNull("source");

            return source.PickRandom(1).SingleOrDefault();
        }

        public static IEnumerable<T> PickRandom<T>(this IEnumerable<T> source, int count)
        {
            source.CheckNotNull("source");

            return source.Shuffle().Take(count);
        }

        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source)
        {
            source.CheckNotNull("source");

            return source.OrderBy(x => Guid.NewGuid());
        }
    }
}
