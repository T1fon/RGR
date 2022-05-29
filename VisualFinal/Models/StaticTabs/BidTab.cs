using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VisualFinal.Models.Database;

namespace VisualFinal.Models.StaticTabs
{
    public class BidTab : StaticTab
    {
        public BidTab(string h = "", DbSet<Bid>? dBS = null) : base(h)
        {
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("RaceNumber");
            DataColumns.Add("HorseName");
            DataColumns.Add("BidderName");
            DataColumns.Add("Incom");
            ObjectList = DBS.ToList<object>();
        }

        new public DbSet<Bid>? DBS { get; set; }
    }
}
