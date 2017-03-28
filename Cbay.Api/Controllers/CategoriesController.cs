using System;
using System.Web.Http;
using Cbay.Api.Extensions;
using Cbay.Service.Interfaces;

namespace Cbay.Api.Controllers
{
    public class CategoriesController : ApiController
    {
        private readonly ICategoriesService _categoriesService;

       public CategoriesController(ICategoriesService categoriesService)
        {
            if (categoriesService == null)
            {
                throw new ArgumentNullException(nameof(categoriesService));
            }

            _categoriesService = categoriesService;
        }

        [HttpGet]
        public IHttpActionResult GetCategories()
        {
            return this.BuildResponse(() => _categoriesService.GetCategories());
        }
    }
}
