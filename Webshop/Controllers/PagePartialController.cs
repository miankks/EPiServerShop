using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer.DataAbstraction;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using Webshop.Models.Pages;

namespace Webshop.Controllers
{
    [TemplateDescriptor(Inherited = true)]
    public class PagePartialController : PartialContentController<SitePageData>
    {
        // GET: PagePartial
        public override ActionResult Index(SitePageData currentContent)
        {
            return PartialView("/Views/Shared/PagePartials/PagePartial.cshtml", currentContent);
        }
    }
}