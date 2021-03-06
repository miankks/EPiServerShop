﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using EPiServer.Core;

namespace Webshop.Models.ViewModels
{
    public class ListingBlockModel
    {
        public virtual string Heading { get; set; }
        public virtual IEnumerable<PageData> Items { get; set; }
    }
}