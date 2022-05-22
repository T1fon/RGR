using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualFinal.Models
{
    public class Query
    {
        public Query(string n = "", string d = "")
        {
            Name = n;
            Description = d;
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public DynamicTab BindedTab { get; set; }
    }
}
