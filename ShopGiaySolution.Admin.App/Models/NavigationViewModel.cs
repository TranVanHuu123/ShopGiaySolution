using Microsoft.AspNetCore.Mvc.Rendering;
using ShopGiaySolution.ViewModels.System.Languages;

namespace ShopGiaySolution.Admin.App.Models
{
    public class NavigationViewModel
    {
        public List<LanguageVm>? Languages { get; set; }

        public string? CurrentLanguageId { get; set; }

        public string? ReturnUrl { set; get; }
    }
}
