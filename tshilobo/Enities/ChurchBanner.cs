using System;
using System.Collections.Generic;

namespace tshilobo.Enities
{
    public partial class ChurchBanner
    {
        public int BannerId { get; set; }
        public string BannnerName { get; set; }
        public int ChurchId { get; set; }
        public byte[] BannerContent { get; set; }
        public bool IsActive { get; set; }

        public Church Church { get; set; }
    }
}
