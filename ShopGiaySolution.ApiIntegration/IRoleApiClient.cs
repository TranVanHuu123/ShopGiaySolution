using ShopGiaySolution.ViewModels.Cammon;
using ShopGiaySolution.ViewModels.System.Roles;

namespace ShopGiaySolution.ApiIntegration
{
    public interface IRoleApiClient
    {
        Task<ApiResult<List<RoleVm>>> GetAll();
    }
}
