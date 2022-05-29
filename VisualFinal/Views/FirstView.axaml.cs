using Avalonia;
using Avalonia.Interactivity;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using VisualFinal.Models;
using VisualFinal.Models.StaticTabs;
using Microsoft.EntityFrameworkCore;
using VisualFinal.ViewModels;
using VisualFinal.ViewModels.StaticTableCreateRowViewModels;
using VisualFinal.Views.StaticTableCreateRowViews;
using VisualFinal.Models.Database;

namespace VisualFinal.Views
{
    public partial class FirstView : UserControl
    {
        public FirstView()
        {
            InitializeComponent();
            this.Find<DataGrid>("DataTable").AutoGeneratingColumn += dataGrid_AutoGeneratingColumn;
            this.FindControl<TabControl>("DataTabs").SelectionChanged += tabControl_SelectionChanged;
            this.FindControl<Button>("CreateNew").Click += button_CreateNew_Click;
            this.FindControl<Button>("Delete").Click += button_Delete_Click;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
        private void changeDataGridItems()
        {
            object? selectedTab;
            selectedTab = this.FindControl<TabControl>("DataTabs").SelectedItem;
            if (selectedTab != null)
            {
                if (selectedTab is DynamicTab)
                {
                    var selectedItems = (selectedTab as DynamicTab).ObjectList;
                    if (selectedItems != null)
                        this.Find<DataGrid>("DataTable").Items = selectedItems;
                }
                else
                {
                    if (selectedTab is BidTab)
                    {
                        var selectedItems = (selectedTab as BidTab).DBS;
                        if (selectedItems != null)
                            this.Find<DataGrid>("DataTable").Items = selectedItems;
                    }
                    else if (selectedTab is BidderTab)
                    {
                        var selectedItems = (selectedTab as BidderTab).DBS;
                        if (selectedItems != null)
                            this.Find<DataGrid>("DataTable").Items = selectedItems;
                    }
                    else if (selectedTab is HorseRelativesTab)
                    {
                        var selectedItems = (selectedTab as HorseRelativesTab).DBS;
                        if (selectedItems != null)
                            this.Find<DataGrid>("DataTable").Items = selectedItems;
                    }
                    else if (selectedTab is HorseTab)
                    {
                        var selectedItems = (selectedTab as HorseTab).DBS;
                        if (selectedItems != null)
                            this.Find<DataGrid>("DataTable").Items = selectedItems;
                    }
                    else if (selectedTab is ResultTab)
                    {
                        var selectedItems = (selectedTab as ResultTab).DBS;
                        if (selectedItems != null)
                            this.Find<DataGrid>("DataTable").Items = selectedItems;
                    }
                    else if (selectedTab is RaceTab)
                    {
                        var selectedItems = (selectedTab as RaceTab).DBS;
                        if (selectedItems != null)
                            this.Find<DataGrid>("DataTable").Items = selectedItems;
                    }
                    else if (selectedTab is JokeyTab)
                    {
                        var selectedItems = (selectedTab as JokeyTab).DBS;
                        if (selectedItems != null)
                            this.Find<DataGrid>("DataTable").Items = selectedItems;
                    }
                    else throw new System.ArgumentException();
                }
            }
        }
        private void refreshDataGridItems()
        {
            this.Find<DataGrid>("DataTable").Items = null;
            changeDataGridItems();
        }
        private void tabControl_SelectionChanged(object? sender,
           SelectionChangedEventArgs e)
        {
            changeDataGridItems();
        }
        private void dataGrid_AutoGeneratingColumn(object? sender,
        DataGridAutoGeneratingColumnEventArgs e)
        {
            var tab = (this.FindControl<TabControl>("DataTabs").SelectedItem as MyTab);
            if (!tab.DataColumns.Contains(e.Column.Header.ToString()))
                e.Column.IsVisible = false;
        }

        async private void button_CreateNew_Click(object? sender, RoutedEventArgs e)
        {
            object? selectedTab;
            selectedTab = this.FindControl<TabControl>("DataTabs").SelectedItem;
            Window window;
            if (selectedTab != null)
            {
                if (selectedTab is BidTab)
                {
                    window = new BidView((this.DataContext as FirstViewModel).MainContext);
                }
                else if (selectedTab is BidderTab)
                {
                    window = new BidderView((this.DataContext as FirstViewModel).MainContext);
                }
                else if (selectedTab is HorseRelativesTab)
                {
                    window = new HorseRelativesView((this.DataContext as FirstViewModel).MainContext);
                }
                else if (selectedTab is HorseTab)
                {
                    window = new HorseView((this.DataContext as FirstViewModel).MainContext);
                }
                else if (selectedTab is ResultTab)
                {
                    window = new ResultView((this.DataContext as FirstViewModel).MainContext);
                }
                else if (selectedTab is RaceTab)
                {
                    window = new RaceView((this.DataContext as FirstViewModel).MainContext);
                }
                else if (selectedTab is JokeyTab)
                {
                    window = new JokeyView((this.DataContext as FirstViewModel).MainContext);
                }
                else throw new System.ArgumentException();
                await window.ShowDialog((Window)this.VisualRoot);
                refreshDataGridItems();
            }
        }
        private void button_Delete_Click(object? sender, RoutedEventArgs e)
        {
            object? selectedTab;
            selectedTab = this.FindControl<TabControl>("DataTabs").SelectedItem;
            var dgItem = this.Find<DataGrid>("DataTable").SelectedItem;
            if (selectedTab != null && dgItem != null)
            {
                if (selectedTab is BidTab)
                {
                    (selectedTab as BidTab).DBS.Remove(dgItem as Bid);
                }
                else if (selectedTab is BidderTab)
                {

                    (selectedTab as BidderTab).DBS.Remove(dgItem as Bidder);
                }
                else if (selectedTab is HorseRelativesTab)
                {

                    (selectedTab as HorseRelativesTab).DBS.Remove(dgItem as HorseRelative);
                }
                else if (selectedTab is HorseTab)
                {

                    (selectedTab as HorseTab).DBS.Remove(dgItem as Horse);
                }
                else if (selectedTab is ResultTab)
                {

                    (selectedTab as ResultTab).DBS.Remove(dgItem as Result);
                }
                else if (selectedTab is RaceTab)
                {

                    (selectedTab as RaceTab).DBS.Remove(dgItem as Race);
                }
                else if (selectedTab is JokeyTab)
                {

                    (selectedTab as JokeyTab).DBS.Remove(dgItem as Jockey);
                }
                else throw new System.ArgumentException();
                (this.DataContext as FirstViewModel).MainContext.Data.SaveChanges();
                refreshDataGridItems();
            }
        }
    }
}