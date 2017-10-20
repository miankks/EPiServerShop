using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Core;
using Webshop.Business;
using Webshop.Models.Pages;

namespace Webshop.Models.ViewModels
{
    public class DefaultPageViewModel<T> : IPageViewModel<T> where T : SitePageData
    {
        public DefaultPageViewModel(T currentPage)
        {
            CurrentPage = currentPage;
            Section = ContentExtensions.GetSection(currentPage.ContentLink);
        }
        public T CurrentPage { get; set; }
        public IContent Section { get; set; }
    }
}