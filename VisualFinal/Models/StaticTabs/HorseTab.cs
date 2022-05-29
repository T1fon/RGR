using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VisualFinal.Models.Database;

namespace VisualFinal.Models.StaticTabs
{
    public class HorseTab : StaticTab
    {
        public HorseTab(string h = "", DbSet<Horse>? dBS = null) : base(h)
        {
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("HorseName");
            DataColumns.Add("Sex");
            DataColumns.Add("NumOfWining");
            DataColumns.Add("NumOfLosing");
            ObjectList = DBS.ToList<object>();
        }

        new public DbSet<Horse>? DBS { get; set; }
    }
}
