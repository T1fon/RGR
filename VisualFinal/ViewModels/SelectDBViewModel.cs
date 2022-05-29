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
    public class SelectDBViewModel : ViewModelBase
    {
        public SelectDBViewModel(MainWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
            ButtonChangeTable = ReactiveCommand.Create<MyTab, Unit>((tab) =>
            {
                SelectedTab = tab;
                //SelectedFields.Clear();
                return Unit.Default;
            });
            /* ButtonChangeSELECT = ReactiveCommand.Create<string, Unit>((str) =>
             {
                 if (SelectedFields.Contains(str))
                     SelectedFields.Remove(str);
                 else SelectedFields.Add(str);
                 return Unit.Default;
             });*/
        }
        public MainWindowViewModel? MainContext { get; set; }
        MyTab selectedTab;
        public MyTab SelectedTab
        {
            get { return selectedTab; }
            set { this.RaiseAndSetIfChanged(ref selectedTab, value); }
        }
        /*
        List<string> selectedFields = new();
        public List<string> SelectedFields
        {
            get { return selectedFields; }
            set { this.RaiseAndSetIfChanged(ref selectedFields, value); }
        }*/
        string where = @"";
        public string Where
        {
            get { return where; }
            set { this.RaiseAndSetIfChanged(ref where, value); }
        }
        public ReactiveCommand<MyTab, Unit> ButtonChangeTable { get; }
        //public ReactiveCommand<string, Unit> ButtonChangeSELECT { get; }
    }
}
