using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReactiveUI;
using System.Reactive;
using VisualFinal.Models;

namespace VisualFinal.ViewModels
{
    public class SecondViewModel : ViewModelBase
    {
        public SecondViewModel(MainWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
        }
        public MainWindowViewModel? MainContext { get; set; }
    }
}
