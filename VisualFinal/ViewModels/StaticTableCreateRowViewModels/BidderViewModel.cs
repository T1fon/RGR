using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualFinal.ViewModels.StaticTableCreateRowViewModels
{
    public class BidderViewModel : ViewModelBase
    {
        public BidderViewModel(MainWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
            Bidder = new VisualFinal.Models.Database.Bidder();
        }
        public VisualFinal.Models.Database.Bidder Bidder { get; set; }
        public MainWindowViewModel? MainContext { get; set; }
    }
}
