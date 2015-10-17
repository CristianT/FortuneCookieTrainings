using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneCookieLibrary
{
    [Serializable]
    public class BadLuckException : Exception
    {
        public BadLuckException()
            : base()
        {
        }

        public BadLuckException(string msg)
            : base(msg)
        {
        }

        public BadLuckException(string msg, Exception innerException)
            : base(msg, innerException)
        {
        }
    }
}
