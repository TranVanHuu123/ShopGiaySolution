﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopGiaySolution.ViewModels.Cammon
{
    public class PagedResult<T> : PagedResultBase
    {
        public List<T>? Items { set; get; }
     

    }
}
