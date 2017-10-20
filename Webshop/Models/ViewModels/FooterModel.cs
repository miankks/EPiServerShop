using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Web.Routing;
using Webshop.Models.Pages;

namespace Webshop.Models.ViewModels
{  
    public class FooterModel
    {
        public FooterModel(SitePageData currentPage)
        {
            LoginUrl = GetLoginUrl(currentPage.ContentLink);
            LoggedIn = System.Web.HttpContext.Current.User.Identity.IsAuthenticated;
            RetrieveSiteProductPage();
        }

        private void RetrieveSiteProductPage()
        {
            throw new NotImplementedException();
        }

        public string GetLoginUrl(ContentReference returnToContentLink)
        {
            var local = ServiceLocator.Current.GetInstance<UrlResolver>();
            return "Hello";
        }

        public bool LoggedIn { get; set; }
        public PageDataCollection ProductPages { get; set; }
        public string LoginUrl { get; set; }
    }
}