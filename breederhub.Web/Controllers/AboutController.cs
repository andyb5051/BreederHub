using System.Web.Mvc;

namespace breederhub.Web.Controllers
{
    public class AboutController : breederhubControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}