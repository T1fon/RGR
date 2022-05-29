using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VisualFinal.Models.Database;

namespace VisualFinal.Models.StaticTabs
{
    public class JokeyTab : StaticTab
    {
        public JokeyTab(string h = "", DbSet<Jockey>? dBS = null) : base(h)
        {
            DBS = dBS;
            DataColumns = new List<string>();
            DataColumns.Add("HorseName");
            DataColumns.Add("Name");
            DataColumns.Add("NumberOfWining");
            DataColumns.Add("NumberOfLosing");
            ObjectList = DBS.ToList<object>();
        }

        new public DbSet<Jockey>? DBS { get; set; }
    }
}
