using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualFinal.ViewModels.StaticTableCreateRowViewModels
{
    public class HorseRelativesViewModel : ViewModelBase
    {
        public HorseRelativesViewModel(MainWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
            HorseRelatives = new VisualFinal.Models.Database.HorseRelative();
        }
        public VisualFinal.Models.Database.HorseRelative HorseRelatives { get; set; }
        public MainWindowViewModel? MainContext { get; set; }
    }
}
