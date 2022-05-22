using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualFinal.ViewModels.StaticTableCreateRowViewModels
{
    public class HorseViewModel : ViewModelBase
    {
        public HorseViewModel(MainWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
            Horse = new VisualFinal.Models.Database.Horse();
        }
        public VisualFinal.Models.Database.Horse Horse { get; set; }
        public MainWindowViewModel? MainContext { get; set; }
    }
}
