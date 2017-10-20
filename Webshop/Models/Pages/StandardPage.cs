using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using Webshop.Models.Blocks;

namespace Webshop.Models.Pages
{
    [ContentType(DisplayName = "StandardPage", GUID = "40aac895-3791-43ba-8194-e470a23cd82b", Description = "Alloy Standard Page")]
    public class StandardPage : SitePageData
    {
        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 310)]
        public virtual XhtmlString MainBody { get; set; }

        [Display(
            Name = "Teaser",
            Description = "Teaser block as a property.",
            GroupName = SystemTabNames.Content,
            Order = 320)]
        public virtual TeaserBlock Teaser { get; set; }

    }
}