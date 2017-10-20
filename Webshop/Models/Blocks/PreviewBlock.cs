using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Core;

namespace Webshop.Models.Blocks
{
    public class PreviewBlock : PageData
    {
        public PreviewBlock(PageData currentPage, IContent previewContent) : base(currentPage)
        {
            this.PreviewContent = previewContent;
            this.ContentArea = new ContentArea();
            this.ContentArea.Items.Add(new ContentAreaItem{ContentLink = this.PreviewContent.ContentLink});
        }
        public IContent PreviewContent { get; set; }
        public ContentArea ContentArea { get; set; }

    }
}