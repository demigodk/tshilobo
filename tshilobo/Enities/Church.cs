using System;
using System.Collections.Generic;

namespace tshilobo.Enities
{
    public partial class Church
    {
        public Church()
        {
            ChurchBanner = new HashSet<ChurchBanner>();
            Theme = new HashSet<Theme>();
        }

        public int ChurchId { get; set; }
        public string ChurchCode { get; set; }
        public bool? HasBranches { get; set; }
        public bool? IsMainBranch { get; set; }
        public string MissionStatement { get; set; }
        public string ChurchName { get; set; }
        public DateTime? FoundingDate { get; set; }
        public string FounderName { get; set; }
        public string CreatorId { get; set; }
        public int? DenominationId { get; set; }
        public string VisionStatement { get; set; }
        public string Country { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string ChurchLeaderId { get; set; }
        public string MainBelief { get; set; }
        public int? MainBranchId { get; set; }

        public User ChurchLeader { get; set; }
        public User Creator { get; set; }
        public Denomination Denomination { get; set; }
        public ICollection<ChurchBanner> ChurchBanner { get; set; }
        public ICollection<Theme> Theme { get; set; }
    }
}
