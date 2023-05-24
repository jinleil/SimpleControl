using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleControl.Demo.ViewModels
{
    public class ProgressBarViewModel: BindableBase, INavigationAware
    {
        private double procent;

        public double Procent
        {
            get { return procent; }
            set { procent = value; RaisePropertyChanged(); }
        }

        public ProgressBarViewModel()
        {
            Task.Run(() =>
            {
                while (true)
                {
                    Thread.Sleep(200);
                    
                    if (Procent < 1)
                    {
                        Procent += 0.01;
                    }
                    else
                    {
                        Procent = 0.01;
                    }
                }
            });
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
