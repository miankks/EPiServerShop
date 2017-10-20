using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Webshop.Models.Blocks
{
    [ContentType(DisplayName = "ListingBlock", GUID = "1581919e-9c54-4165-a989-b81c6bcb0bb4", Description = "")]
    public class ListingBlock : BlockData
    {
       [Display(
            GroupName = SystemTabNames.Content,
            Order = 100)]
       public virtual string Heading { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 200)]
        public virtual PageReference RootPage { get; set; }

    }
}