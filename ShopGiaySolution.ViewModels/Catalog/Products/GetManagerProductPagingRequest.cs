﻿using ShopGiaySolution.ViewModels.Cammon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopGiaySolution.ViewModels.Catalog.Products
{
    public class GetManagerProductPagingRequest : PagingRequestBase
    {
        public string? Keyword {get; set;}
      
        public string? LanguageId { get; set; }
        public int? CategoryId { get; set; }
    }
}
