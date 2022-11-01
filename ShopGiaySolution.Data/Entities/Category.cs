using ShopGiaySolution.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopGiaySolution.Data.Entities
{
    public class Category
    {
        public int Id { set; get; }
        public int SortOrder { set; get; }
        public bool IsShowOnHome { set; get; }
        public int? ParentId { set; get; }
        public Status Status { set; get; }
        public List<ProductInCategory>? productInCategories { set; get; }
        public List<CategoryTranslation>? CategoryTranslations { get; set; }

    }
}
