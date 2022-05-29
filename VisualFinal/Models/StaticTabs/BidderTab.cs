using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VisualFinal.Models.Database;

namespace VisualFinal.Models.StaticTabs
{
    public class BidderTab : StaticTab
    {
        public BidderTab(string h = "", DbSet<Bidder>? dBS = null) : base(h)
        {
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("BidderName");
            DataColumns.Add("Horses");
            DataColumns.Add("Success");
            ObjectList = DBS.ToList<object>();
        }

        new public DbSet<Bidder>? DBS { get; set; }
    }
}
