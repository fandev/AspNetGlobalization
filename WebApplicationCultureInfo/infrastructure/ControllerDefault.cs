using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web.Mvc;

namespace WebApplicationCultureInfo.infrastructure
{
    public class DefaultController : Controller
    {
        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {
            base.Initialize(requestContext);

            var userLanguages = requestContext.HttpContext.Request.UserLanguages;

            CultureInfo ciClient = CultureInfo.GetCultureInfo(userLanguages.First());

            CultureInfo ciServer = CultureInfo.GetCultureInfo("en");

            Thread.CurrentThread.CurrentCulture = ciClient;
            Thread.CurrentThread.CurrentUICulture = ciClient;
        }
    }
}