using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VisualFinal.Models
{
    public class StaticTab : MyTab
    {
        public StaticTab(string h = "", List<string>? dc = null) : base(h, dc)
        {
            ButtonVisible = false;
        }
        public DbSet<object>? DBS { get; set; }
    }
}
