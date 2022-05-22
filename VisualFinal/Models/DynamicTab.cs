using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualFinal.Models
{
    public class DynamicTab : MyTab
    {
        public DynamicTab(string h = "", List<object>? db = null, List<string>? dc = null) : base(h, dc)
        {
            ButtonVisible = true;
            BindedList = db;
        }
        public Query BindedQuery { get; set; }
        public List<object>? BindedList { get; set; }
    }
}
