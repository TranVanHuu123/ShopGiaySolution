﻿using ShopGiaySolution.ViewModels.Cammon;
using ShopGiaySolution.ViewModels.Catalog.Products;

namespace ShopGiaySolution.ApiIntegration
{
    public interface IProductApiClient
    {
        Task<PagedResult<ProductVm>> GetPagings(GetManagerProductPagingRequest request);
        Task<bool> CreateProduct(ProductCreateRequest request);
        Task<bool> UpdateProduct(ProductUpdateRequest request);

        Task<ApiResult<bool>> CategoryAssign(int id, CategoryAssignRequest request);
        Task<ProductVm> GetById(int id, string languageId);
        Task<List<ProductVm>> GetFeaturedProducts( string languageId, int take);
        Task<List<ProductVm>> GetLatestProducts(string languageId, int take);

        Task<bool> DeleteProduct(int id);



    }
}
