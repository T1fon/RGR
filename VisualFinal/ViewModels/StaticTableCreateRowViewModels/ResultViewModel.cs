using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualFinal.ViewModels.StaticTableCreateRowViewModels
{
    public class ResultViewModel : ViewModelBase
    {
        public ResultViewModel(MainWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
            Result = new VisualFinal.Models.Database.Result();
        }
        public VisualFinal.Models.Database.Result Result { get; set; }
        public MainWindowViewModel? MainContext { get; set; }
    }
}
