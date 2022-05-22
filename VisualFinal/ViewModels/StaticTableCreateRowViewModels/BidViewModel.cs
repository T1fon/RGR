using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualFinal.ViewModels.StaticTableCreateRowViewModels
{
    public class BidViewModel : ViewModelBase
    {
        public BidViewModel(MainWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
            Bid = new VisualFinal.Models.Database.Bid();
        }
        public VisualFinal.Models.Database.Bid Bid { get; set; }
        public MainWindowViewModel? MainContext { get; set; }
    }
}
