﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using Webshop.Models.Pages;
using Webshop.Models.ViewModels;

namespace Webshop.Controllers
{
    public class ProductPageController : PageControllerBase<ProductPage>
    {
        public ActionResult Index(ProductPage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */
            var model = new DefaultPageViewModel<ProductPage>(currentPage);
            return View(model);
        }
    }
}