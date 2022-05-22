using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualFinal.ViewModels.StaticTableCreateRowViewModels
{
    public class RaceViewModel : ViewModelBase
    {
        public RaceViewModel(MainWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
            Race = new VisualFinal.Models.Database.Race();
        }
        public VisualFinal.Models.Database.Race Race { get; set; }
        public MainWindowViewModel? MainContext { get; set; }
    }
}
