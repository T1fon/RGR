using System;
using System.Collections.Generic;

namespace VisualFinal.Models.Database
{
    public partial class Bidder
    {
        public Bidder()
        {
            Bids = new HashSet<Bid>();
        }

        public string BidderName { get; set; } = null!;
        public string? Horses { get; set; }
        public double Success { get; set; }

        public virtual ICollection<Bid> Bids { get; set; }
    }
}
