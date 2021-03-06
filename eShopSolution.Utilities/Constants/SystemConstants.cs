﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Utilities.Constants
{
    public class SystemConstants
    {
        public const string MainConnectionString = "eShopSolutionDb";

        public class AppSettings
        {
            public const string DefaultLanguageId = "DefaultLanguageId";
            public const string Token = "Token";
            public const string BaseAddress = "BaseAddress";
           
        }
        public class ProductSettings
        {
            public const int NumberFeaturedProducts = 4;
            public const int NumberLatestProducts = 6;
        }
        public class ProductConstants
        {
            public const string NA = "N/A";
        }
    }
}