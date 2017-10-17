using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace Webshop.Models.Pages
{
    [ContentType(DisplayName = "StartPage", GUID = "b087ac80-d24a-410d-9db7-735ced21f4fd", Description = "Web Shop")]
    public class StartPage : SitePageData
    {

        [CultureSpecific]
        [Display(
            Name = "Main website heading",
            Description = "Here we have website main heading and from here we start our journey to the online world of shopping excellence.",
            GroupName = SystemTabNames.Content,
            Order = 0)]
        public virtual string Heading { get; set; }


        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

    }
}