using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;
using System.Collections.Generic;
using Webshop.Models.Pages;

namespace Webshop.Models.Properties
{
    [ContentType(DisplayName = "ShoesPage", GUID = "ca560448-36d0-4ea0-b22b-59a1c480141e", Description = "")]
    public class ShoesPage : StandardPage
    {
        [Display(
            Name = "Shoes Image",
            GroupName = SystemTabNames.Content,
            Order = 320)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference ShoesImage { get; set; }

        [Display(
            Name = "Shoes name",
            GroupName = SystemTabNames.Content,
            Order = 321)]
        public virtual string ShoesName { get; set; }

        [Display(
            Name = "Shoes price",
            GroupName = SystemTabNames.Content,
            Order = 350)]
        public virtual int ShoesPrice { get; set; }

        [Display(
            Name = "Shoes description",
            GroupName = SystemTabNames.Content,
            Order = 323)]
        public virtual XhtmlString ShoesDecscription { get; set; }


        //[Display(
        //    Name = "Main content area",
        //    GroupName = SystemTabNames.Content,
        //    Order = 320)]
        //public virtual ContentArea MainContentArea { get; set; }
    }
}