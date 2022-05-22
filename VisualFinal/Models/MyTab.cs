using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace VisualFinal.Models
{
    public class MyTab
    {
        public MyTab(string h = "", List<string>? dataColumns = null)
        {
            Header = h;
            DataColumns = dataColumns;
        }
        public string Header { get; set; }
        public bool ButtonVisible { get; set; }
        public List<string>? DataColumns { get; set; }
    }
}
