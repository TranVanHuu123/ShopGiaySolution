using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopGiaySolution.Admin.App.Models;
using ShopGiaySolution.ApiIntegration;
using ShopGiaySolution.Utilities.Constants;

namespace ShopGiaySolution.Admin.App.Controllers.Components
{
    public class NavigationViewComponent : ViewComponent
    {
        private readonly ILanguageApiClient _languageApiClient;

        public NavigationViewComponent(ILanguageApiClient languageApiClient)
        {
            _languageApiClient = languageApiClient;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var languages = await _languageApiClient.GetAll();
            var navigationVm = new NavigationViewModel()
            {
                CurrentLanguageId = HttpContext
                .Session
                .GetString(SystemConstants.AppSettings.DefaultLanguageId),
                 Languages = languages.ResultObj
            };
            return View("Default", navigationVm);
        }
    }
}
