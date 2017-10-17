using System.Web.Mvc;
using Webshop.Models.Pages;
using Webshop.Models.ViewModels;

namespace Webshop.Controllers
{
    public class StandardPageController : PageControllerBase<StandardPage>
    {
       
            public ActionResult Index(StandardPage currentPage)
            {
                /* Implementation of action. You can create your own view model class that you pass to the view or
                 * you can pass the page type for simpler templates */
                var model = new DefaultPageViewModel<StandardPage>(currentPage);

                return View(model);
            }
        
    }
}