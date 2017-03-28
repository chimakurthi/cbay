//using System.Web.Http;
//using Cbay.Service;
//using Cbay.Service.Interfaces;

//namespace Cbay.App.Controllers
//{
//    public class CategoriesController : ApiController
//    {
//        private readonly ICategoriesService _categoriesService;

//        public CategoriesController()
//        {
//                _categoriesService = new CategoriesService();
//        }
//        public CategoriesController(ICategoriesService categoriesService)
//        {
//            _categoriesService = categoriesService;
//        }

//        public IHttpActionResult Get()
//        {
//            return Ok(_categoriesService.GetCategories());
//        } 
//    }
//}
