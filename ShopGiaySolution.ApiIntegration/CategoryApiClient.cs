﻿using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using ShopGiaySolution.ViewModels.Catalog.Categories;

namespace ShopGiaySolution.ApiIntegration
{
    public class CategoryApiClient : BaseApiClient, ICategoryApiClient
    {
        public CategoryApiClient(IHttpClientFactory httpClientFactory,
                  IHttpContextAccessor httpContextAccessor,
                   IConfiguration configuration)
           : base(httpClientFactory, httpContextAccessor, configuration)
        {
        }

        public async Task<List<CategoryVm>> GetAll(string languageId)
        {
            return await GetListAsync<CategoryVm>("/api/categories?languageId=" + languageId);
        }

        public async Task<CategoryVm> GetById(string languageId, int id)
        {
            return await GetAsync<CategoryVm>($"/api/categories/{id}/{languageId}");
        }

        //public async Task<CategoryVm> GetById(string languageId, int id)
        //{
        //    return await GetAsync<CategoryVm>($"/api/categories/{id}/{languageId}");
        //}
    }
}
