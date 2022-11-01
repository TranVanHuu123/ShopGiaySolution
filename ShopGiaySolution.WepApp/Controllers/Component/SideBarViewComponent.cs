using Microsoft.AspNetCore.Mvc;
using ShopGiaySolution.ApiIntegration;
using System.Globalization;

namespace ShopGiaySolution.WepApp.Controllers.Component
{
    public class SideBarViewComponent : ViewComponent
    {
        private readonly ICategoryApiClient _categoryApiClient;

        public SideBarViewComponent(ICategoryApiClient categoryApiClient)
        {
            _categoryApiClient = categoryApiClient;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = await _categoryApiClient.GetAll(CultureInfo.CurrentCulture.Name);
            return View(items);
        }

    }
}
