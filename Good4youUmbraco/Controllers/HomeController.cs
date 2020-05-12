using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace Good4youUmbraco.Controllers
{
    public class HomeController : SurfaceController
    {
        public ActionResult RenderFeatured()
        {
            return PartialView("~/Views/Partials/Home/Featured.cshtml");
        }
    }
}