using System;
using System.Collections.Generic;

namespace VisualFinal.Models.Database
{
    public partial class Race
    {
        public Race()
        {
            Bids = new HashSet<Bid>();
            Results = new HashSet<Result>();
        }

        public long RaceNumber { get; set; }
        public string? TipeRace { get; set; }
        public string? Date { get; set; }
        public string? TimeRace { get; set; }

        public virtual ICollection<Bid> Bids { get; set; }
        public virtual ICollection<Result> Results { get; set; }
    }
}
