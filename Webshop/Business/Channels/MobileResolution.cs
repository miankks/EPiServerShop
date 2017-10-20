using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Web;

namespace Webshop.Business.Channels
{
    public class IphoneMobileResolution : IDisplayResolution
    {
        public string Id => this.GetType().FullName;

        public string Name => "Mobile";

        public int Width => 480;

        public int Height => 320;
    }
    public class SamsungMobileResolution : IDisplayResolution
    {
        public string Id => this.GetType().FullName;

        public string Name => "Samsung";

        public int Width => 800;

        public int Height => 600;
    }

    public class SonyMobileResolution : IDisplayResolution
    {
        public string Id => this.GetType().FullName;

        public string Name => "Sony";

        public int Width => 900;

        public int Height => 750;
    }
}