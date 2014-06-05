using System.Web.Mvc;
using System.Threading;
using WebApplicationCultureInfo.infrastructure;
namespace WebApplicationCultureInfo.Controllers
{
    public class HomeController : DefaultController
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Moeda(decimal valor)
        {
            return View(valor);
        }
    }
}
