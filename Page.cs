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
        private bool _isSelected;
        private string _pageName;
        [AllowNull] private ObservableCollection<Page> _subPages;
        public bool IsSelected
        {
            get { return _isSelected; }
            set { _isSelected = value; OnSelectionChanged(); }
        }
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
        private static void OnSelectionChanged()
        {
            Console.WriteLine("Selection Changed");
            //Hier Eventing um ViewModel bescheit zu sagen
            //Und sehr böse, weil direkt auf Model binden
            //Besser ein TreeViewItem ViewModel bauen und irgendwie mit Interfaces spezifizieren 
        }
    }
}
