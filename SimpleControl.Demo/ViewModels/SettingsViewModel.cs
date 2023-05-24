using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace SimpleControl.Demo.ViewModels
{
    public class SettingsViewModel : INavigationAware
    {
        private List<string> primaryColor;

        public List<string> PrimaryColor
        {
            get { return primaryColor; }
            set
            {
                primaryColor = value;
            }
        }

        private List<string> sencondaryColor;

        public List<string> SencondaryColor
        {
            get { return sencondaryColor; }
            set { sencondaryColor = value; }
        }

        private List<string> activateColor;

        public List<string> ActivateColor
        {
            get { return activateColor; }
            set { activateColor = value; }
        }

        private List<string> backgroundColor;

        public List<string> BackgroundColor
        {
            get { return backgroundColor; }
            set { backgroundColor = value; }
        }

        private List<string> foregroundColor;

        public List<string> ForegroundColor
        {
            get { return foregroundColor; }
            set { foregroundColor = value; }
        }


        public SettingsViewModel()
        {
            primaryColor = new List<string> { "#0000FF", "#FFDAB9", "#CD5C5C" , "#CD5C5C" };
            sencondaryColor = new List<string> { "#CD5C5C", "#CD5C5C", "#CD5C5C","#CD5C5C" };
            activateColor = new List<string> { "#7A67EE", "#7A67EE" , "#7A67EE", "#7A67EE" };
            backgroundColor = new List<string> { "#7A67EE", "#7A67EE" , "#7A67EE", "#7A67EE" };
            foregroundColor = new List<string> { "#FFFFFF", "#FFFFFF" , "#FFFFFF" };
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {

        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {

        }
    }
}
