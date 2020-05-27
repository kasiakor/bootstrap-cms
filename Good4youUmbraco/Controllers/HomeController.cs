using Good4youUmbraco.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Mvc;
using Archetype.Models;

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
            List<FeaturedItem> model = new List<FeaturedItem>();
            IPublishedContent homePage = CurrentPage.AncestorOrSelf(1).DescendantsOrSelf().Where(x => x.DocumentTypeAlias == "home").FirstOrDefault();
            ArchetypeModel featuredItems = homePage.GetPropertyValue<ArchetypeModel>("featuredItems");

            foreach (ArchetypeFieldsetModel fieldset in featuredItems)
            {
                string name = fieldset.GetValue<string>("name");
                string category = fieldset.GetValue<string>("category");

                int imageId = fieldset.GetValue<int>("image");
                var mediaItem = Umbraco.Media(imageId);
                string imageUrl = mediaItem.Url;

                int pageId = fieldset.GetValue<int>("page");
                IPublishedContent linkToPage = Umbraco.TypedContent(pageId);
                string linkUrl = linkToPage.Url;

                model.Add(new FeaturedItem(name, category, imageUrl, linkUrl));
            }

            return PartialView("~/Views/Partials/Home/Featured.cshtml", model);
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