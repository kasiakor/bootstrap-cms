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
        public ActionResult RenderBanner()
        {
            return PartialView("~/Views/Partials/Home/Banner.cshtml");
        }
        public ActionResult RenderIntro()
        {
            return PartialView("~/Views/Partials/Home/Intro.cshtml");
        }
        public ActionResult RenderFeatured()
        {
            return PartialView("~/Views/Partials/Home/Featured.cshtml");
        }

        public ActionResult RenderBlog()
        {
            return PartialView("~/Views/Partials/Home/Blog.cshtml");
        }
        public ActionResult RenderTestimonials()
        {
            return PartialView("~/Views/Partials/Home/Testimonials.cshtml");
        }
    }
}