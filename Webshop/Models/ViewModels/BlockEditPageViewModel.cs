using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Core;
using Webshop.Models.Blocks;
using Webshop.Models.Pages;

namespace Webshop.Models.ViewModels
{
    public class BlockEditPageViewModel : IPageViewModel<SitePageData>
    {
        public BlockEditPageViewModel(PageData page, IContent content)
        {
            previewBlock = new PreviewBlock(page, content);
            CurrentPage =page as SitePageData;
        }
        public PreviewBlock previewBlock { get; set; }
        public SitePageData CurrentPage { get; set; }
    }
}