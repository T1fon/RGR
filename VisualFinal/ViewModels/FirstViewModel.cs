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
    public class FirstViewModel : ViewModelBase
    {
        public FirstViewModel(MainWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
            ButtonDeleteTab = ReactiveCommand.Create<MyTab, Unit>((tab) =>
            {
                MainContext.Tabs.Remove(tab);
                return Unit.Default;
            });
        }
        public ReactiveCommand<MyTab, Unit> ButtonDeleteTab { get; }

        public MainWindowViewModel? MainContext { get; set; }
    }
}