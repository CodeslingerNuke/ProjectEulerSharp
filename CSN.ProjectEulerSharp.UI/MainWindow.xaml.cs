using CSN.ProjectEulerSharp.UI.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace CSN.ProjectEulerSharp.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ucDetailsTab DetailsTab { get; set; }

        private ucOverviewTab OverviewTab { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            InitializeTabs();
        }

        private void MI_Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void InitializeTabs()
        {
            DetailsTab = new ucDetailsTab();
            OverviewTab = new ucOverviewTab();

            tabDetails.Content = DetailsTab;
            tabOverview.Content = OverviewTab;
        }
    }
}
