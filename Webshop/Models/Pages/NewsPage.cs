using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using Webshop.Models.Blocks;

namespace Webshop.Models.Pages
{
    [ContentType(DisplayName = "NewsPage", GUID = "b7bf4131-ae71-4b55-9813-e8237a7883d3", Description = "")]
    public class NewsPage : StartPage
    {

        [Display(
            Name = "Main Listing",
            Description = "A listing of news pages.",
            GroupName = SystemTabNames.Content,
            Order = 315)]
        public virtual ListingBlock MainListing { get; set; }

    }
}