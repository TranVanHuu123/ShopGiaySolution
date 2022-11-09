using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopGiaySolution.Utilities.Constants
{
    public class SystemConstants
    {
        public const string MainConectionString = "ShopGiaySolutionDb";
        public const string CartSession = "CartSession";

        public class AppSettings
        {
            public const string DefaultLanguageId = "DefaultLanguageId";
            public const string Token = "Token";
            public const string BaseAddress = "BaseAddress";
        }

        public class ProductSettings
        {
            public const int NumberOfFeaturedProducts = 6;
            public const int NumberOfLatestProducts = 3;
        }
        public class ProductConstants
        {
            public const string NA = "N/A";
        }
    }
   
}
