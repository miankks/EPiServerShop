using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using System.Data.Entity;
using Webshop.Models.Pages;
using Webshop.Models.ViewModels;

namespace Webshop.Controllers
{
    public class ClothProductPageController : PageControllerBase<ClothProductPage>
    {
        public ActionResult Index(ClothProductPage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */
             var  clothes = new ClothProductPage();
            //clothes.ProductImage =
            
            var model = new DefaultPageViewModel<ClothProductPage>(currentPage);

            return View(model);
        }

        public ActionResult AddToCart(ClothProductPage cloth)
        {
            var model = new ClothProductPage();
            //db.model.Add(cloth);
            //db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}