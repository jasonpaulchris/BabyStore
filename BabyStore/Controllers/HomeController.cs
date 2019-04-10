using System.Web.Mvc;

namespace BabyStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About(string Id)
        {
            ViewBag.Message = "Your application description page. You entered the ID " + Id;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}