using System;
using System.Collections.Generic;

namespace VisualFinal.Models.Database
{
    public partial class Jockey
    {
        public string HorseName { get; set; } = null!;
        public string Name { get; set; } = null!;
        public long NumberOfWining { get; set; }
        public long NumberOfLosing { get; set; }

        public virtual Horse HorseNameNavigation { get; set; } = null!;
    }
}
