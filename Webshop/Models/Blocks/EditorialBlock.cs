using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Webshop.Models.Blocks
{
    [ContentType(DisplayName = "EditorialBlock", GUID = "51457955-51ac-4b6d-a2ea-81513cba39db", Description = "")]
    public class EditorialBlock : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Name",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }


    }
}