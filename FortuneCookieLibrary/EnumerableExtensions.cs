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
            if (source == null)
            {
                throw new ArgumentException("The list cannot be empty.", "source");
            }

            return source.PickRandom(1).Single();
        }

        public static IEnumerable<T> PickRandom<T>(this IEnumerable<T> source, int count)
        {
            if (source == null)
            {
                throw new ArgumentException("The list cannot be empty.", "source");
            }

            return source.Shuffle().Take(count);
        }

        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source)
        {
            if (source == null)
            {
                throw new ArgumentException("The list cannot be empty.", "source");
            }

            return source.OrderBy(x => Guid.NewGuid());
        }
    }
}
