using Prism.DryIoc;
using Prism.Ioc;
using SimpleControl.Demo.ViewModels;
using SimpleControl.Demo.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SimpleControl.Demo
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainView>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<SettingsView, SettingsViewModel>("Settings");
            containerRegistry.RegisterForNavigation<ButtonView, ButtonViewModel>("Button");
            containerRegistry.RegisterForNavigation<ListBoxView, ListBoxViewModel>("ListBox");
            containerRegistry.RegisterForNavigation<ToggleButtonView, ToggleButtonViewModel>("ToggleButton");
            containerRegistry.RegisterForNavigation<ProgressBarView, ProgressBarViewModel>("ProgressBar");
            
        }
    }
}
