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
    [ContentType(DisplayName = "JeansPage", GUID = "6d332184-231a-4f88-b386-41f261aca9af", Description = "")]
    public class JeansPage : StandardPage
    {
        [Display(
            Name = "Jeans Image",
            GroupName = SystemTabNames.Content,
            Order = 320)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference JeansImage { get; set; }

        [Display(
            Name = "Jeans name",
            GroupName = SystemTabNames.Content,
            Order = 321)]
        public virtual string JeansName { get; set; }

        [Display(
            Name = "Jeans price",
            GroupName = SystemTabNames.Content,
            Order = 322)]
        public virtual int JeansPrice { get; set; }

        [Display(
            Name = "Jeans description",
            GroupName = SystemTabNames.Content,
            Order = 323)]
        public virtual XhtmlString JeansDecscription { get; set; }


        [Display(
            Name = "Main content area",
            GroupName = SystemTabNames.Content,
            Order = 320)]
        public virtual ContentArea MainContentArea { get; set; }
    }
}