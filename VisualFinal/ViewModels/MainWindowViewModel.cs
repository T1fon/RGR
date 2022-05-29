using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using ReactiveUI;
using System.Linq;
using System.Reactive.Linq;
using VisualFinal.Models;
using VisualFinal.Models.Database;
using VisualFinal.Models.StaticTabs;

namespace VisualFinal.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            CreateContext();
            CreateTabs();
            CreateQueries();
            Content = Fv = new FirstViewModel(this);
            Sv = new SecondViewModel(this);
        }
        ViewModelBase content;
        public ViewModelBase Content
        {
            get { return content; }
            set { this.RaiseAndSetIfChanged(ref content, value); }
        }
        public void Change()
        {
            if (Content == Fv)
                Content = Sv;
            else if (Content == Sv)
                Content = Fv;
            else throw new InvalidOperationException();
        }

        ObservableCollection<MyTab> tabs;
        public ObservableCollection<MyTab> Tabs
        {
            get { return tabs; }
            set { this.RaiseAndSetIfChanged(ref tabs, value); }
        }

        ObservableCollection<Query> queries;
        public ObservableCollection<Query> Queries
        {
            get { return queries; }
            set { this.RaiseAndSetIfChanged(ref queries, value); }
        }

        public FirstViewModel Fv { get; }
        public SecondViewModel Sv { get; }

        datbaseContext data;

        public datbaseContext Data
        {
            get { return data; }
            set { this.RaiseAndSetIfChanged(ref data, value); }
        }
        private void CreateContext()
        {
            Data = new datbaseContext();
        }

        private void CreateTabs()
        {
            Tabs = new ObservableCollection<MyTab>();
            Tabs.Add(new HorseTab("Horse", Data.Horses));
            Tabs.Add(new HorseRelativesTab("Horse Relatives", Data.HorseRelatives));
            Tabs.Add(new JokeyTab("Jokey", Data.Jockeys));
            Tabs.Add(new RaceTab("Race", Data.Races));
            Tabs.Add(new ResultTab("Result", Data.Results));
            Tabs.Add(new BidTab("Bid", Data.Bids));
            Tabs.Add(new BidderTab("Bidder", Data.Bidders));
        }
        private void CreateQueries()
        {
            Queries = new ObservableCollection<Query>();
        }
    }
}
