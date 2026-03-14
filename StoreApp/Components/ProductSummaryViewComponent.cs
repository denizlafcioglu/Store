using Microsoft.AspNetCore.Mvc;
using Repositories;
using Services.Contracts;
using System.Reflection.Metadata.Ecma335;

namespace StoreApp.Components
{
    public class ProductSummaryViewComponent : ViewComponent
    {
        private readonly IServiceManager _serviceManager;

        public ProductSummaryViewComponent(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        public string Invoke()
        {
            //service
            return _serviceManager.ProductServices.GetAllProducts(false).Count().ToString();
        }
    }


}
