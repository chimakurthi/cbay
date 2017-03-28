using System.Web.Http;

namespace Cbay.App
{
    public static class JsonConfiguration
    {
        public static void Configure()
        {
            GlobalConfiguration
                .Configuration
                .Formatters
                .JsonFormatter
                .SerializerSettings
                .ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
        }
    }
}