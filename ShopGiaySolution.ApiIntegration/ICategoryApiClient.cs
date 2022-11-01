using ShopGiaySolution.ViewModels.Catalog.Categories;

namespace ShopGiaySolution.ApiIntegration
{
    public interface ICategoryApiClient
    {
        Task<List<CategoryVm>> GetAll(string languageId);

        Task<CategoryVm> GetById(string languageId, int id);
    }
}
