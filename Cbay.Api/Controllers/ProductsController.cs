using System.Web.Http;
using Cbay.Api.Extensions;
using Cbay.Service.Interfaces;
using Cbay.Service;

namespace Cbay.Api.Controllers
{
    public class ProductsController : ApiController
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IHttpActionResult GetProducts(int categoryId)
        {
            return this.BuildResponse(() => _productService.GetProducts(categoryId));
        }
    }
}
