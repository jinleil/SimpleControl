using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleControl.Demo.ViewModels
{
    class MainViewModel
    {
        private readonly IRegionManager regionManager;

        public MainViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
            Controls = new List<string>
            {
                "Settings",
                "Button",
                "ToggleButton",
                "ListBox",
                "ComBox",
                "ProgressBar",
            };
        }

        public List<string> Controls { get; set; }

        private string selectedItem;

        public string SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
                regionManager.RequestNavigate("MainRegion", selectedItem);
            }
        }

    }
}
