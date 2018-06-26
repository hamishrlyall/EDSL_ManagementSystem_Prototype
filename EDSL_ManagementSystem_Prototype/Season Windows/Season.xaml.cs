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

namespace EDSL_ManagementSystem_Prototype
{
    /// <summary>
    /// Interaction logic for Season.xaml
    /// </summary>
    public partial class Season : Page
    {
        public Season()
        {
            InitializeComponent();
        }

        private void SetupSeasonButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new SeasonCreator());
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
            this.NavigationService.Navigate(new SeasonCreator());
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

        private void ManageLeagueButton_Click(object sender, RoutedEventArgs e)
        {
            if (LeagueListBox.Text == "EDSL")
            {
                this.NavigationService.Navigate(new LeagueEditor());
            }
            else
            {
                MessageBox.Show("No League selected.");
            }
        }

        private void SetLeagueButton_Click(object sender, RoutedEventArgs e)
        {
            if(LeagueListBox.Text == "EDSL")
            {
                MessageBox.Show("League Set!");
            }
            else
            {
                MessageBox.Show("No League selected.");
            }
        }

        private void SetDivisionButton_Click(object sender, RoutedEventArgs e)
        {
            if(LeagueListBox.Text == "EDSL" && DivisionListBox.Text == "Gold")
            {
                MessageBox.Show("Division Set!");
            }
            else if (LeagueListBox.Text == "EDSL" && DivisionListBox.Text == "Blue")
            {
                MessageBox.Show("Division Set!");
            }
            else if (LeagueListBox.Text == "EDSL" && DivisionListBox.Text == "Red")
            {
                MessageBox.Show("Division Set!");
            }
            else
            {
                MessageBox.Show("No League/Division selected.");
            }

        }
        private void ManageDivisionButton_Click(object sender, RoutedEventArgs e)
        {
            if (LeagueListBox.Text == "EDSL" && DivisionListBox.Text == "Gold")
            {
                this.NavigationService.Navigate(new DivisionEditor());
            }
            else if (LeagueListBox.Text == "EDSL" && DivisionListBox.Text == "Blue")
            {
                this.NavigationService.Navigate(new DivisionEditor());
            }
            else if (LeagueListBox.Text == "EDSL" && DivisionListBox.Text == "Red")
            {
                this.NavigationService.Navigate(new DivisionEditor());
            }
            else
            {
                MessageBox.Show("No League/Division selected.");
            }
        }
    }
}
