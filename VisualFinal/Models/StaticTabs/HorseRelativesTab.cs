using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VisualFinal.Models.Database;

namespace VisualFinal.Models.StaticTabs
{
    public class HorseRelativesTab : StaticTab
    {
        public HorseRelativesTab(string h = "", DbSet<HorseRelative>? dBS = null) : base(h)
        {
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("HorseName");
            DataColumns.Add("Mum");
            DataColumns.Add("Dad");
            ObjectList = DBS.ToList<object>();
        }

        new public DbSet<HorseRelative>? DBS { get; set; }
    }
}
