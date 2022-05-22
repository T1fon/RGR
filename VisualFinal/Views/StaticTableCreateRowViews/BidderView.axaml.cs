using Avalonia;
using Avalonia.Interactivity;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using VisualFinal.ViewModels.StaticTableCreateRowViewModels;
using VisualFinal.ViewModels;

namespace VisualFinal.Views.StaticTableCreateRowViews
{
    public partial class BidderView : Window
    {
        public BidderView()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            this.FindControl<Button>("Confirm").Click += button_Confirm_Click;
            this.FindControl<Button>("Cancel").Click += button_Cancel_Click;
        }
        public BidderView(MainWindowViewModel? mainContext) : this()
        {
            this.DataContext = new BidderViewModel(mainContext);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void button_Confirm_Click(object? sender, RoutedEventArgs e)
        {
            var dc = (this.DataContext as BidderViewModel);
            dc.MainContext.Data.Bidders.Add(dc.Bidder);
            dc.MainContext.Data.SaveChanges();
            this.Close();
        }
        private void button_Cancel_Click(object? sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
