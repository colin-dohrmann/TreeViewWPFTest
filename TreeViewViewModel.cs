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

        private Page _selectedPage;
        public Page SelectedPage
        {
            get { return _selectedPage; }
            set { _selectedPage = value; }
        }

        public TreeViewViewModel()
        {
            Pages = new ObservableCollection<Page>
            {
                new Page(1, "Page 1", new ObservableCollection<Page> {new Page(11, "Page 1.1"),
                new Page(12, "Page 1.2"),
                new Page(13, "Page 1.3"),
                new Page(14, "Page 1.4"),
                new Page(15, "Page 1.5"),}),
                new Page(2, "Page 2"),
                new Page(3, "Page 3"),
                new Page(4, "Page 4"),
            };
            SelectedPage = new Page(0, "null");
            OnPropertyChanged(nameof(Pages));
        }
    }
}
