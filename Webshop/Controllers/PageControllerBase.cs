using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using Webshop.Models.Pages;

namespace Webshop.Controllers
{
    public abstract class PageControllerBase<T> : PageController<T> where T : SitePageData
    {
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Index");
        }
    }
}