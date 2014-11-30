using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace breederhub.Web.Controllers
{
    public class ContactController : breederhubControllerBase
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }
    }
}