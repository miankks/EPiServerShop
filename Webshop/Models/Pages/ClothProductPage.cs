using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace Webshop.Models.Pages
{
    [ContentType(DisplayName = "ClothProductPage", GUID = "bfc7d2db-7b3f-4425-8c40-932fab5ad10f", Description = "")]
    public class ClothProductPage : StandardPage
    {

        [Display(
            Name = "Product name",
            GroupName = SystemTabNames.Content,
            Order = 320)]
        public virtual string ProductName { get; set; }

        [Display(
            Name = "Product price",
            GroupName = SystemTabNames.Content,
            Order = 330)]
        public virtual int ProductPrice { get; set; }

        [Display(
            Name = "Product description",
            GroupName = SystemTabNames.Content,
            Order = 340)]
        public virtual XhtmlString ProductDecscription { get; set; }

        [Display(
            Name = "Product Image",
            GroupName = SystemTabNames.Content,
            Order = 320)]
        [UIHint(UIHint.Image)]
        public virtual IList<ContentReference>  ProductImage { get; set; }

        [Display(
            Name = "Main content area",
            GroupName = SystemTabNames.Content,
            Order = 320)]
        public virtual  ContentArea MainContentArea { get; set; }
    }
}