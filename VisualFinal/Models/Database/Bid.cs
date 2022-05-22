using System;
using System.Collections.Generic;

namespace VisualFinal.Models.Database
{
    public partial class Bid
    {
        public long RaceNumber { get; set; }
        public string HorseName { get; set; } = null!;
        public string BidderName { get; set; } = null!;
        public double Incom { get; set; }

        public virtual Bidder BidderNameNavigation { get; set; } = null!;
        public virtual Horse HorseNameNavigation { get; set; } = null!;
        public virtual Race RaceNumberNavigation { get; set; } = null!;
    }
}
