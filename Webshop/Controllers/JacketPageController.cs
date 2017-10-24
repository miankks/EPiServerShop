using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using Webshop.Models.Properties;

namespace Webshop.Controllers
{
    public class JacketPageController : PartialContentController<JacketPage>
    {
        public override ActionResult Index(JacketPage currentContent)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            return PartialView("/Views/JacketPage/Index.cshtml", currentContent);
        }
    }
}