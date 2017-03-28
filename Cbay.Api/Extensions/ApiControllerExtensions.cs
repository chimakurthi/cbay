using System;
using System.Web.Http;
using System.Web.Http.Results;

namespace Cbay.Api.Extensions
{
    public static class ApiControllerExtensions
    {
       public static IHttpActionResult BuildResponse<TResult>(this ApiController controller, Func<TResult> func)
        {
            try
            {
                var result = func.Invoke();
                return new OkNegotiatedContentResult<TResult>(result, controller);
            }
            catch (Exception ex)
            {
                return new InternalServerErrorResult(controller);
            }
       }

        public static IHttpActionResult BuildResponse<TResult>(this ApiController controller, Action action)
        {
            try
            {
                action.Invoke();
                return  new OkResult(controller);
            }
            catch (Exception ex)
            {
                return new InternalServerErrorResult(controller);
            }
        }
    }
}