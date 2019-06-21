using System;
using System.Collections.Generic;

namespace tshilobo.Enities
{
    public partial class Denomination
    {
        public Denomination()
        {
            Church = new HashSet<Church>();
        }

        public int DenominationId { get; set; }
        public string Denomination1 { get; set; }

        public ICollection<Church> Church { get; set; }
    }
}
