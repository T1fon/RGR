using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualFinal.ViewModels
{
    public class JoinDBViewModel : ViewModelBase
    {
        public JoinDBViewModel(MainWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
        }
        public MainWindowViewModel? MainContext { get; set; }
    }
}
