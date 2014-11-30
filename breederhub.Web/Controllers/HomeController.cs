using System.Web.Mvc;

namespace breederhub.Web.Controllers
{
    public class HomeController : breederhubControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}