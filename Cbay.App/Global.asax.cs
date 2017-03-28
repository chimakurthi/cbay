using System.Web.Http;

namespace Cbay.App
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            JsonConfiguration.Configure();
        }
    }
}
