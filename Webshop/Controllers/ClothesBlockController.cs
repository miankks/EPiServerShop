using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using Webshop.Models.Blocks;

namespace Webshop.Controllers
{
    public class ClothesBlockController : BlockController<ClothesBlock>
    {
        public override ActionResult Index(ClothesBlock currentBlock)
        {
            return PartialView(currentBlock);
        }
    }
}
