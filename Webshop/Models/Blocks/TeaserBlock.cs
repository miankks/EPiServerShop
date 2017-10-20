using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace Webshop.Models.Blocks
{
    [ContentType(DisplayName = "TeaserBlock", GUID = "41f82668-4b96-47fb-b9f6-d113d8fb9f86", Description = "")]
    public class TeaserBlock : BlockData
    {
        
         [Display(
            Name = "teaser image",
            GroupName = SystemTabNames.Content,
            Order = 100)]
         [UIHint(UIHint.Image)]
         public virtual ContentReference TeaserImage { get; set; }

        [Display(
            Name = "teaser heading",
            GroupName = SystemTabNames.Content,
            Order = 200)]
        public virtual string TeaserHeading { get; set; }

        [Display(
            Name = "teaser text",
            GroupName = SystemTabNames.Content,
            Order = 300)]
        [UIHint(UIHint.Textarea)]
        public virtual string TeaserText { get; set; }

        [Display(
            Name = "teaser link",
            GroupName = SystemTabNames.Content,
            Order = 400)]
        public virtual PageReference TeaserLink { get; set; }

        [Display(
            Name = "teaser price",
            GroupName = SystemTabNames.Content,
            Order = 410)]
        public virtual int TeaserPrice { get; set; }
    }
}