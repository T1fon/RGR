using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ReactiveUI;
using System.Reactive;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualFinal.Models;

namespace VisualFinal.ViewModels
{
    public class GroupDBViewModel : ViewModelBase
    {
        public GroupDBViewModel(MainWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
            ButtonChangeTable = ReactiveCommand.Create<MyTab, Unit>((tab) =>
            {
                SelectedTab = tab;
                SelectedField = "";
                return Unit.Default;
            });
            ButtonChangeGROUPBY = ReactiveCommand.Create<string, Unit>((str) =>
            {
                SelectedField = str;
                return Unit.Default;
            });
        }
        public MainWindowViewModel? MainContext { get; set; }
        MyTab selectedTab;
        public MyTab SelectedTab
        {
            get { return selectedTab; }
            set { this.RaiseAndSetIfChanged(ref selectedTab, value); }
        }
        string selectedField;
        public string SelectedField
        {
            get { return selectedField; }
            set { this.RaiseAndSetIfChanged(ref selectedField, value); }
        }
        public ReactiveCommand<MyTab, Unit> ButtonChangeTable { get; }
        public ReactiveCommand<string, Unit> ButtonChangeGROUPBY { get; }
    }
}
