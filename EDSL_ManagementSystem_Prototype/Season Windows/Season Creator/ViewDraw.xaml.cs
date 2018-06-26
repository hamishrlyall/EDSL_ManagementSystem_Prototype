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
using EDSL_ManagementSystem_Prototype.Properties;
using EDSL_ManagementSystem_Prototype.Season_Windows;
using EDSL_ManagementSystem_Prototype.Results_Windows;

namespace EDSL_ManagementSystem_Prototype.Season_Windows.Season_Creator
{
    /// <summary>
    /// Interaction logic for ViewDraw.xaml
    /// </summary>
    public partial class ViewDraw : Page
    {
        public class Item
        {
            public string HomeTeam { get; set; }
            public string AwayTeam { get; set; }
            public int Round { get; set; }
        }
        private void addcolumn1()
        {
            DataGrid DrawDataGrid = new DataGrid();
            DataGridTextColumn c1 = new DataGridTextColumn();
            c1.Header = "HomeTeam";
            c1.Binding = new Binding("HomeTeam");
            c1.Width = 100;
            DrawDataGrid.Columns.Add(c1);
            DataGridTextColumn c2 = new DataGridTextColumn();
            c2.Header = "AwayTeam";
            c2.Binding = new Binding("AwayTeam");
            c2.Width = 100;
            DrawDataGrid.Columns.Add(c2);
            DataGridTextColumn c3 = new DataGridTextColumn();
            c3.Header = "Round";
            c3.Binding = new Binding("Round");
            c3.Width = 100;
            DrawDataGrid.Columns.Add(c3);

            DrawDataGrid.Items.Add(new Item() { HomeTeam = "Wantirna Gold", AwayTeam = "Mount Waverley Gold", Round = 1 });
            DrawDataGrid.Items.Add(new Item() { HomeTeam = "Scoresby Gold", AwayTeam = "Mitcham Gold", Round = 1 });
            DrawDataGrid.Items.Add(new Item() { HomeTeam = "RingWood Gold", AwayTeam = "Wonga Park Gold", Round = 1 });
            DrawDataGrid.Items.Add(new Item() { HomeTeam = "Mount Evelyn Gold", AwayTeam = "LilyDale Gold", Round = 1 });
            DrawDataGrid.Items.Add(new Item() { HomeTeam = "Belgrave Gold", AwayTeam = "Beaconsfield Upper Gold", Round = 1 });
            grid1.Children.Add(DrawDataGrid);

        }
        public ViewDraw()
        {
            InitializeComponent();
            addcolumn1();
           

        }
        private void ResultsButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Results());
        }

        private void SeasonButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Season());
        }

        private void ClubsButton_Click(object sender, RoutedEventArgs e)
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
