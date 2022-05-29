using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VisualFinal.Models.Database;

namespace VisualFinal.Models.StaticTabs
{
    public class ResultTab : StaticTab
    {
        public ResultTab(string h = "", DbSet<Result>? dBS = null) : base(h)
        {
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("HorseName");
            DataColumns.Add("RaceNumber");
            DataColumns.Add("Backlog");
            DataColumns.Add("Age/Weight");
            ObjectList = DBS.ToList<object>();
        }

        new public DbSet<Result>? DBS { get; set; }
    }
}
