using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace Webshop.Models.Blocks
{
    [ContentType(DisplayName = "ClothesBlock", GUID = "90ed5d0d-54fa-4ff7-8d30-984eea429c22", Description = "")]
    public class ClothesBlock : BlockData
    {
        [Display(
            Name = "Cloth image",
            GroupName = SystemTabNames.Content,
            Order = 100)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference ClothImage { get; set; }

        [Display(
            Name = "Cloth heading",
            GroupName = SystemTabNames.Content,
            Order = 200)]
        public virtual string ClothHeading { get; set; }

        [Display(
            Name = "Cloth text",
            GroupName = SystemTabNames.Content,
            Order = 300)]
        [UIHint(UIHint.Textarea)]
        public virtual string ClothDescription { get; set; }

        [Display(
            Name = "Cloth link",
            GroupName = SystemTabNames.Content,
            Order = 400)]
        public virtual PageReference ClothLink { get; set; }

        [Display(
            Name = "Cloth price",
            GroupName = SystemTabNames.Content,
            Order = 410)]
        public virtual int ClothPrice { get; set; }
    }
}