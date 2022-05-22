using System;
using System.Collections.Generic;

namespace VisualFinal.Models.Database
{
    public partial class HorseRelative
    {
        public string HorseName { get; set; } = null!;
        public string? Mum { get; set; }
        public string? Dad { get; set; }

        public virtual Horse HorseNameNavigation { get; set; } = null!;
    }
}
