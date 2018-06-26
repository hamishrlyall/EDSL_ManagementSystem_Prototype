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
using EDSL_ManagementSystem_Prototype.Results_Windows;
using EDSL_ManagementSystem_Prototype.Season_Windows;
using EDSL_ManagementSystem_Prototype.Season_Windows.Season_Creator;

namespace EDSL_ManagementSystem_Prototype.Season_Windows
{
    /// <summary>
    /// Interaction logic for SeasonCreator.xaml
    /// </summary>
    public partial class SeasonCreator : Page
    {
        public SeasonCreator()
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

        private void CreateDrawButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Draw Created! Click View Draw.");
        }

        private void ViewDrawButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ViewDraw());
        }
    }
}
