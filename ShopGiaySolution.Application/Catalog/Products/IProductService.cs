
using Microsoft.AspNetCore.Http;
using ShopGiaySolution.ViewModels.Cammon;
using ShopGiaySolution.ViewModels.Catalog.ProductImages;
using ShopGiaySolution.ViewModels.Catalog.Products;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopGiaySolution.Application.Catalog.Products
{
    public interface IProductService
    {
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update( ProductUpdateRequest request);

        Task<int> Delete(int productId);
        Task<ProductVm> GetById(int productId ,string languageId);
        Task<bool> UpdatePrice(int productId, decimal newPrice);

        Task<bool> UpdateStock(int productId , int addedQuantity);

        Task AddViewcount(int productId);

      

        Task<PagedResult<ProductVm>> GetAllPaging(GetManagerProductPagingRequest request);


        Task<int> AddImages(int productId, ProductImageCreateRequest request);

        Task<int> RemoveImages(int imageId );
        Task<int> UpdateImages(int imageId , ProductImageUpdateRequest request);
        Task<ProductImageViewModel> GetImageById(int imageId);

        Task<List<ProductImageViewModel>> GetListImages(int productId);
        Task<PagedResult<ProductVm>> GetAllByCategoryId(string languageId, GetPublicProductPagingRequest request);
        Task<ApiResult<bool>> CategoryAssign(int id, CategoryAssignRequest request);
        Task<List<ProductVm>> GetFeaturedProducts(string languageId, int take);
        Task<List<ProductVm>> GetLatestProducts(string languageId, int take);


    }
}
