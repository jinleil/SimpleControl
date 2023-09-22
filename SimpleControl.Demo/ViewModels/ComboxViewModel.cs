using Prism.Common;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleControl.Demo.ViewModels
{
    internal class ComboxViewModel : BindableBase, INavigationAware
    {
        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            _items.Add("项目1");
            _items.Add("项目2");
            _items.Add("项目3");
            _items.Add("项目4");
        }

        private ObservableCollection<string> _items = new ObservableCollection<string>();

        public ObservableCollection<string> Items
        {
            get { return _items; }
            set { _items = value; RaisePropertyChanged(); }
        }
    }
}