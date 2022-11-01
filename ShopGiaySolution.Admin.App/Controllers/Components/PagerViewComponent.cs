using Microsoft.AspNetCore.Mvc;
using ShopGiaySolution.ViewModels.Cammon;

namespace ShopGiaySolution.Admin.App.Controllers.Components
{
    public class PagerViewComponent : ViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(PagedResultBase result)
        {
            return Task.FromResult((IViewComponentResult)View("Default", result));
        }

    }
}
