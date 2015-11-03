using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FortuneCookieLibrary
{
    public static class CheckExtensions
    {
        public static void CheckNotNull(this object obj)
        {
            obj.CheckNotNull(string.Empty);
        }

        public static void CheckNotNull(this object obj, string name)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(name, "Parameter cannot be null.");
            }
        }

        public static void CheckStringNotNullOrEmpty(this string obj)
        {
            obj.CheckStringNotNullOrEmpty(string.Empty);
        }

        public static void CheckStringNotNullOrEmpty(this string obj, string name)
        {
            obj.CheckNotNull(name);

            if (obj.Length == 0)
            {
                throw new ArgumentException("String parameter cannot be empty.", name);
            }
        }

    }
}
