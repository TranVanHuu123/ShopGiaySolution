using ShopGiaySolution.ViewModels.Sales;

namespace ShopGiaySolution.WepApp.Models
{
    public class CheckoutViewModel
    {
        public List<CartItemViewModel>? CartItems { get; set; }

        public CheckoutRequest? CheckoutModel { get; set; }
    }
}
