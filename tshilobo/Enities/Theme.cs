using System;
using System.Collections.Generic;

namespace tshilobo.Enities
{
    public partial class Theme
    {
        public int ThemeId { get; set; }
        public int ChurchId { get; set; }
        public DateTime DateCreated { get; set; }
        public string YearTheme { get; set; }
        public string CreatorId { get; set; }

        public Church Church { get; set; }
        public User Creator { get; set; }
    }
}
