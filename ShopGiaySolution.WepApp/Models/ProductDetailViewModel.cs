using ShopGiaySolution.ViewModels.Catalog.Categories;
using ShopGiaySolution.ViewModels.Catalog.ProductImages;
using ShopGiaySolution.ViewModels.Catalog.Products;

namespace ShopGiaySolution.WepApp.Models
{
    public class ProductDetailViewModel
    {
        public CategoryVm? Category { get; set; }

        public ProductVm? Product { get; set; }

        public List<ProductVm>? RelatedProducts { get; set; }

        public List<ProductImageViewModel>? ProductImages { get; set; }
    }
}
