using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using Webshop.Models.Pages;
using System.Collections.Generic;

namespace Webshop.Models.Properties
{
    [ContentType(DisplayName = "JacketPage", GUID = "200b2a69-d9a9-4e9e-8ce5-dfc4d3755a8f", Description = "")]
    public class JacketPage : StandardPage
    {
        [Display(
            Name = "Jacket Image",
            GroupName = SystemTabNames.Content,
            Order = 320)]
        [UIHint(EPiServer.Web.UIHint.Image)]
        public virtual ContentReference JacketImage { get; set; }

        [Display(
            Name = "Jacket name",
            GroupName = SystemTabNames.Content,
            Order = 321)]
        public virtual string JacketName { get; set; }

        [Display(
            Name = "Jacket price",
            GroupName = SystemTabNames.Content,
            Order = 322)]
        public virtual int JacketPrice { get; set; }

        [Display(
            Name = "Jacket description",
            GroupName = SystemTabNames.Content,
            Order = 323)]
        public virtual XhtmlString JacketDecscription { get; set; }


        [Display(
            Name = "Main content area",
            GroupName = SystemTabNames.Content,
            Order = 320)]
        public virtual ContentArea MainContentArea { get; set; }
    }
}