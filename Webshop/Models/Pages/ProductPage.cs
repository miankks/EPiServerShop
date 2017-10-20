using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace Webshop.Models.Pages
{
    [ContentType(DisplayName = "ProductPage", GUID = "3323bb98-0705-4f9e-87c8-fe5d497611c8", Description = "Alloy Product Page")]
    public class ProductPage : StandardPage
    {

        [Display(
            Name = "Unique selling point",
            GroupName = SystemTabNames.Content,
            Order = 305)]
        [UIHint(UIHint.Textarea)]
        public virtual string UniqueSellingPoints { get; set; }

        [Display(
            Name = "Main content area",
            GroupName = SystemTabNames.Content,
            Order = 320)]
        public virtual ContentArea MainContentArea { get; set; }

        [Display(
            Name = "RelatedContentArea",
            GroupName = SystemTabNames.Content,
            Order = 330)]
        public virtual ContentArea RelatedContentArea { get; set; }

    }
}