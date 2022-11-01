using ShopGiaySolution.ViewModels.Catalog.Products;

namespace ShopGiaySolution.WepApp.Models
{
    public class HomeViewModel
    {
        public List<ProductVm>? FeaturedProducts { get; set; }
        public List<ProductVm>? LatestProducts { get; set; }

    }
}
