using ShopGiaySolution.ViewModels.Cammon;
using ShopGiaySolution.ViewModels.Catalog.Categories;
using ShopGiaySolution.ViewModels.Catalog.Products;

namespace ShopGiaySolution.WepApp.Models
{
    public class ProductCategoryViewModel
    {
        public CategoryVm? Category { get; set; }

        public PagedResult<ProductVm>? Products { get; set; }
    }
}
