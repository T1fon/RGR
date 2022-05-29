using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VisualFinal.Models.Database;

namespace VisualFinal.Models.StaticTabs
{
    public class RaceTab : StaticTab
    {
        public RaceTab(string h = "", DbSet<Race>? dBS = null) : base(h)
        {
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("RaceNumber");
            DataColumns.Add("TipeRace");
            DataColumns.Add("Date");
            DataColumns.Add("TimeRace");
            ObjectList = DBS.ToList<object>();
        }

        new public DbSet<Race>? DBS { get; set; }
    }
}
