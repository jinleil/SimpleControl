using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SimpleControl.Demo.Views
{
    /// <summary>
    /// SettingsView.xaml 的交互逻辑
    /// </summary>
    public partial class SettingsView : UserControl
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

        public SettingsView()
        {
            InitializeComponent();

            primaryColor = new List<string> { "#0000FF", "#FFDAB9", "#CD5C5C", "#8A2BE2" };
            sencondaryColor = new List<string> { "#FFE4E1", "#87CEEB", "#87CEEB", "#90EE90" };
            activateColor = new List<string> { "#7A67EE", "#FFA500", "#EE3B3B", "#FFFF00" };
            backgroundColor = new List<string> { "#9C9C9C", "#EED2EE", "#7A378B", "#7A67EE" };
            foregroundColor = new List<string> { "#EE0000", "#1C1C1C", "#90EE90" };

            Combox_PrimaryColor.ItemsSource = PrimaryColor;
            Combox_PrimaryColor.SelectionChanged += PrimaryColor_Selected;

            this.Combox_SecondaryColor.ItemsSource = SencondaryColor;
            this.Combox_SecondaryColor.SelectionChanged += SencondaryColor_Selected;

            this.Combox_ActivateColor.ItemsSource = ActivateColor;
            this.Combox_ActivateColor.SelectionChanged += ActivateColor_Selected;

            this.Combox_BackgroundColor.ItemsSource = BackgroundColor;
            this.Combox_BackgroundColor.SelectionChanged += BackgroundColor_Selected;

            this.Combox_ForegroundColor.ItemsSource = ForegroundColor;
            this.Combox_ForegroundColor.SelectionChanged += ForegroundColor_Selected;
        }

        private void PrimaryColor_Selected(object sender, RoutedEventArgs e)
        {
            var selectedItem = (e.Source as ComboBox).SelectedItem.ToString();
            string simpleControl = AppDomain.CurrentDomain.BaseDirectory + "SimpleControl.dll";
            var assembly = Assembly.LoadFile(simpleControl);
            var resourceName = assembly.GetName().Name + ".g";
            ResourceManager resourceManager = new ResourceManager(resourceName, assembly);
            var resourceSet = resourceManager.GetResourceSet(CultureInfo.CurrentCulture, true, true);
            

            this.Resources.Remove("PrimaryColor");
            this.Resources.Add("PrimaryColor", new SolidColorBrush((Color)ColorConverter.ConvertFromString(selectedItem)));
        }
        private void SencondaryColor_Selected(object sender, RoutedEventArgs e)
        {
            var selectedItem = (e.Source as ComboBox).SelectedItem.ToString();
            this.Resources["SecondaryColor"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString(selectedItem));
        }
        private void ActivateColor_Selected(object sender, RoutedEventArgs e)
        {
            var selectedItem = (e.Source as ComboBox).SelectedItem.ToString();
            this.Resources["ActivateColor"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString(selectedItem));
        }
        private void BackgroundColor_Selected(object sender, RoutedEventArgs e)
        {
            var selectedItem = (e.Source as ComboBox).SelectedItem.ToString();
            this.Resources["BackgroundColor"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString(selectedItem));
        }
        private void ForegroundColor_Selected(object sender, RoutedEventArgs e)
        {
            var selectedItem = (e.Source as ComboBox).SelectedItem.ToString();
            this.Resources["ForegroundColor"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString(selectedItem));
        }
    }
}
