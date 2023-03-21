using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewTest
{
    public class Page : ViewModelBase
    {
        private int _pageId;
        private string _pageName;
        [AllowNull] private ObservableCollection<Page> _subPages;
        public int PageId
        {
            get { return _pageId; }
            set { _pageId = value; OnPropertyChanged(nameof(PageId)); }
        }
        public string PageName
        {
            get { return _pageName; }
            set { _pageName = value; OnPropertyChanged(nameof(PageName)); }
        }

        public ObservableCollection<Page> SubPages
        {
            get { return _subPages; }
            set { _subPages = value; OnPropertyChanged(nameof(SubPages)); }
        }

        public Page(int pageId, string pageName, ObservableCollection<Page> subPages)
        {
            PageId = pageId;
            PageName = pageName;
            SubPages = subPages;
        }
        public Page(int pageId, string pageName)
        {
            PageId = pageId;
            PageName = pageName;
            _subPages = null;
        }
    }
}
