using System;
using System.Collections.Generic;

namespace VisualFinal.Models.Database
{
    public partial class Result
    {
        public string HorseName { get; set; } = null!;
        public long RaceNumber { get; set; }
        public string? Backlog { get; set; }
        public string? AgeWeight { get; set; }

        public virtual Horse HorseNameNavigation { get; set; } = null!;
        public virtual Race RaceNumberNavigation { get; set; } = null!;
    }
}
