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
using System.Windows.Shapes;

namespace EDSL_ManagementSystem_Prototype
{
    /// <summary>
    /// Interaction logic for Division_Editor.xaml
    /// </summary>
    public partial class Division_Editor : Page
    {
        public Division_Editor()
        {
            InitializeComponent();
        }

        private void ResultsButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Results());
        }

        private void SeasonButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Season());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Clubs());
        }

        private void TeamsButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Teams());
        }

        private void PlayersButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Players());
        }

        private void ReportsButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Reports());
        }
    }
}
