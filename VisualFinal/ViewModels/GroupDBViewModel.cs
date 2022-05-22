using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualFinal.ViewModels
{
    public class GroupDBViewModel : ViewModelBase
    {
        public GroupDBViewModel(MainWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
        }
        public MainWindowViewModel? MainContext { get; set; }
    }
}
