using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopGiaySolution.Utilities.Exceptions
{
    public class ShopGiayException : Exception
    {
        public ShopGiayException()
        {
        }

        public ShopGiayException(string message)
            : base(message)
        {
        }

        public ShopGiayException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
