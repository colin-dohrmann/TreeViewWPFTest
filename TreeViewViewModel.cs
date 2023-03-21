using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewTest
{
    public class TreeViewViewModel : ViewModelBase
    {
        public ObservableCollection<Page> Pages { get; set; }

        public TreeViewViewModel()
        {
            Pages = new ObservableCollection<Page>
            {
                new Page(1, "Page 1"),
                new Page(2, "Page 2"),
                new Page(3, "Page 3"),
                new Page(4, "Page 4"),
            };
            OnPropertyChanged(nameof(Pages));

        }
    }
}
