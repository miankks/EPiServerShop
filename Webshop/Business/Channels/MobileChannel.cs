﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Web;

namespace Webshop.Business.Channels
{
    public class MobileChannel : DisplayChannel
    {
        public override string ChannelName => "Mobile";

        public override bool IsActive(HttpContextBase context)
        {
            return context.Request.Browser.IsMobileDevice;
        }

        public override string DisplayName => "Mobile";

        public override string ResolutionId => typeof(SamsungMobileResolution).FullName;
    }
}