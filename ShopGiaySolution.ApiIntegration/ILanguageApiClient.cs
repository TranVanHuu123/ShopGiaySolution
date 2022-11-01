using ShopGiaySolution.ViewModels.Cammon;
using ShopGiaySolution.ViewModels.System.Languages;

namespace ShopGiaySolution.ApiIntegration
{
    public interface ILanguageApiClient
    {
        Task<ApiResult<List<LanguageVm>>> GetAll();
    }
}
