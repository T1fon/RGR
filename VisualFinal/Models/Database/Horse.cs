using System;
using System.Collections.Generic;

namespace VisualFinal.Models.Database
{
    public partial class Horse
    {
        public Horse()
        {
            Bids = new HashSet<Bid>();
            Results = new HashSet<Result>();
        }

        public string HorseName { get; set; } = null!;
        public string Sex { get; set; } = null!;
        public long NumOfWining { get; set; }
        public long NumOfLosing { get; set; }

        public virtual HorseRelative HorseRelative { get; set; } = null!;
        public virtual Jockey Jockey { get; set; } = null!;
        public virtual ICollection<Bid> Bids { get; set; }
        public virtual ICollection<Result> Results { get; set; }
    }
}
