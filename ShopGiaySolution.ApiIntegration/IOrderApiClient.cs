using ShopGiaySolution.ViewModels.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopGiaySolution.ApiIntegration
{
    public interface IOrderApiClient
    {
        Task<List<CheckoutRequest>> GetAll(string languageId);
        Task<List<OrderDetailVm>> Save(string invoice);


    }
}
