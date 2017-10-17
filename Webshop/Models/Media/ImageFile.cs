using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Webshop.Models.Media
{
    [ContentType(DisplayName = "ImageFile", GUID = "7c0998ce-455d-4b15-b0f1-afc424f680ca", Description = "")]
    /*[MediaDescriptor(ExtensionString = "pdf,doc,docx")]*/
    public class ImageFile : ImageData
    {
        public virtual string Description { get; set; }
    }
}