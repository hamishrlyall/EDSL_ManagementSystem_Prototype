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

namespace EDSL_ManagementSystem_Prototype.Results_Windows
{
    /// <summary>
    /// Interaction logic for ViewLadder.xaml
    /// </summary>
    public partial class ViewLadder : Page
    {
        public class ViewItem
        {
            public int Pos { get; set; }
            public string Team { get; set; }
            public int Played { get; set; }
            public string PontDiff { get; set; }
            public int Wins { get; set; }
            public int Losses { get; set; }
            public int Drawn { get; set; }
            public int For { get; set; }
            public int Against { get; set; }

        }
        private void GoldDivisionLadder()
        {
            DataGrid GoldLadderDataGrid = new DataGrid();
            DataGridTextColumn c1 = new DataGridTextColumn();
            c1.Header = "Pos";
            c1.Binding = new Binding("Pos");
            c1.Width = 50;
            GoldLadderDataGrid.Columns.Add(c1);
            DataGridTextColumn c2 = new DataGridTextColumn();
            c2.Header = "Team";
            c2.Binding = new Binding("Team");
            c2.Width = 200;
            GoldLadderDataGrid.Columns.Add(c2);
            DataGridTextColumn c3 = new DataGridTextColumn();
            c3.Header = "Played";
            c3.Binding = new Binding("Played");
            c3.Width = 50;
            GoldLadderDataGrid.Columns.Add(c3);
            DataGridTextColumn c4 = new DataGridTextColumn();
            c4.Header = "PointDiff";
            c4.Binding = new Binding("PointDiff");
            c4.Width = 50;
            GoldLadderDataGrid.Columns.Add(c4);
            DataGridTextColumn c5 = new DataGridTextColumn();
            c5.Header = "Wins";
            c5.Binding = new Binding("Wins");
            c5.Width = 50;
            GoldLadderDataGrid.Columns.Add(c5);
            DataGridTextColumn c6 = new DataGridTextColumn();
            c6.Header = "Losses";
            c6.Binding = new Binding("Losses");
            c6.Width = 50;
            GoldLadderDataGrid.Columns.Add(c6);
            DataGridTextColumn c7 = new DataGridTextColumn();
            c7.Header = "Drawn";
            c7.Binding = new Binding("Drawn");
            c7.Width = 50;
            GoldLadderDataGrid.Columns.Add(c7);
            DataGridTextColumn c8 = new DataGridTextColumn();
            c8.Header = "For";
            c8.Binding = new Binding("For");
            c8.Width = 50;
            GoldLadderDataGrid.Columns.Add(c8);
            DataGridTextColumn c9 = new DataGridTextColumn();
            c9.Header = "Against";
            c9.Binding = new Binding("Against");
            c9.Width = 50;
            GoldLadderDataGrid.Columns.Add(c9);
            GoldLadderDataGrid.Items.Add(new ViewItem() { Pos = 1, Team = "Mount Waverley Gold", Played = 3, PontDiff = "5", Wins = 3, Losses = 0, Drawn = 0, For = 5, Against = 0 });
            GoldLadderDataGrid.Items.Add(new ViewItem() { Pos = 2, Team = "Scoresby Gold", Played = 3, PontDiff = "2", Wins = 3, Losses = 0, Drawn = 0, For = 3, Against = 1});
            GoldLadderDataGrid.Items.Add(new ViewItem() { Pos = 3, Team = "Wonga Park Gold", Played = 3, PontDiff = "1", Wins = 2, Losses = 1, Drawn = 0, For = 4, Against = 3 });
            GoldLadderDataGrid.Items.Add(new ViewItem() { Pos = 4, Team = "Wantirna Gold", Played = 3, PontDiff = "2", Wins = 2, Losses = 1, Drawn = 0, For = 3, Against = 1 });
            GoldLadderDataGrid.Items.Add(new ViewItem() { Pos = 5, Team = "Mitcham Gold", Played = 3, PontDiff = "1", Wins = 1, Losses = 1, Drawn = 1, For = 4, Against = 3 });
            GoldLadderDataGrid.Items.Add(new ViewItem() { Pos = 6, Team = "Lilydale Gold", Played = 3, PontDiff = "-1", Wins = 1, Losses = 1, Drawn = 1,  For = 3, Against = 4 });
            GoldLadderDataGrid.Items.Add(new ViewItem() { Pos = 7, Team = "Belgrave Gold", Played = 3, PontDiff = "-2", Wins = 1, Losses = 2, Drawn = 0, For = 2, Against = 4 });
            GoldLadderDataGrid.Items.Add(new ViewItem() { Pos = 8, Team = "Ringwood Gold", Played = 3, PontDiff = "-2", Wins = 1, Losses = 2, Drawn = 0, For = 1, Against = 3 });
            GoldLadderDataGrid.Items.Add(new ViewItem() { Pos = 9, Team = "Beaconsfield Upper Gold", Played = 3, PontDiff = "-4", Wins = 0, Losses = 2, Drawn = 1, For = 1, Against = 5 });
            GoldLadderDataGrid.Items.Add(new ViewItem() { Pos = 10, Team = "Mount Evlyn Gold", Played = 3, PontDiff = "-7", Wins = 0, Losses = 2, Drawn = 1, For = 0, Against = 7 });
            LadderGrid.Children.Add(GoldLadderDataGrid);
        }
        public ViewLadder()
        {
            InitializeComponent();
            GoldDivisionLadder();
        }

        private void ResultsButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Results());
        }

        private void SeasonButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Season());
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

        private void ClubsButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Clubs());
        }


    }
}
