using Microsoft.AspNetCore.Mvc;
using ShopGiaySolution.ViewModels.Cammon;

namespace ShopGiaySolution.WepApp.Controllers.Component
{
    public class PagerViewComponent : ViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(PagedResultBase result)
        {
            return Task.FromResult((IViewComponentResult)View("Default", result));
        }

    }
}
