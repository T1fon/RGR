using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VisualFinal.Models.Database;

namespace VisualFinal.ViewModels.StaticTableCreateRowViewModels
{
    public class JokeyViewModel : ViewModelBase
    {
        public JokeyViewModel(MainWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
            Jockey = new VisualFinal.Models.Database.Jockey();
        }
        public VisualFinal.Models.Database.Jockey Jockey { get; set; }
        public MainWindowViewModel? MainContext { get; set; }
    }
}
