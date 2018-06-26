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

namespace EDSL_ManagementSystem_Prototype
{
    /// <summary>
    /// Interaction logic for Results.xaml
    /// </summary>
    public partial class Results : Page
    {
        public class ResultsItem
        {
            public string HomeTeam { get; set; }
            public string AwayTeam { get; set; }
            public string HomeScore { get; set; }
            public string AwayScore { get; set; }
        }
        private void GoldDivisionRound1ScoringDG()
        {
            DataGrid GoldRound1ResultsDataGrid = new DataGrid();
            DataGridTextColumn c1 = new DataGridTextColumn();
            c1.Header = "HomeTeam";
            c1.Binding = new Binding("HomeTeam");
            c1.Width = 100;
            GoldRound1ResultsDataGrid.Columns.Add(c1);
            DataGridTextColumn c2 = new DataGridTextColumn();
            c2.Header = "HomeTeam";
            c2.Binding = new Binding("HomeTeam");
            c2.Width = 100;
            GoldRound1ResultsDataGrid.Columns.Add(c2);
            DataGridTextColumn c3 = new DataGridTextColumn();
            c3.Header = "HomeScore";
            c3.Binding = new Binding("HomeScore");
            c3.Width = 100;
            GoldRound1ResultsDataGrid.Columns.Add(c3);
            DataGridTextColumn c4 = new DataGridTextColumn();
            c4.Header = "AwayScore";
            c4.Binding = new Binding("HomeScore");
            c4.Width = 100;
            GoldRound1ResultsDataGrid.Columns.Add(c4);
            GoldRound1ResultsDataGrid.Items.Add(new ResultsItem() { HomeTeam = "Wantirna Gold", AwayTeam = "Mount Waverley Gold", HomeScore = "" , AwayScore = ""});
            GoldRound1ResultsDataGrid.Items.Add(new ResultsItem() { HomeTeam = "Scoresby Gold", AwayTeam = "Mitcham Gold", HomeScore = "", AwayScore = "" });
            GoldRound1ResultsDataGrid.Items.Add(new ResultsItem() { HomeTeam = "RingWood Gold", AwayTeam = "Wonga Park Gold", HomeScore = "", AwayScore = "" });
            GoldRound1ResultsDataGrid.Items.Add(new ResultsItem() { HomeTeam = "Mount Evelyn Gold", AwayTeam = "LilyDale Gold", HomeScore = "", AwayScore = "" });
            GoldRound1ResultsDataGrid.Items.Add(new ResultsItem() { HomeTeam = "Belgrave Gold", AwayTeam = "Beaconsfield Upper Gold", HomeScore = "", AwayScore = "" });
            Results_Grid.Children.Add(GoldRound1ResultsDataGrid);
        }
        private void GoldDivisionRound1list()
        {
            ListBox GoldResultsList = new ListBox();
            ListBoxItem Game1 = new ListBoxItem();
            ListBoxItem Game2 = new ListBoxItem();
            ListBoxItem Game3 = new ListBoxItem();
            ListBoxItem Game4 = new ListBoxItem();
            ListBoxItem Game5 = new ListBoxItem();
            Game1.Content = "Wantirna Gold v Mount Waverley Gold";
            Game2.Content = "Scoresby Gold v Mitcham Gold";
            Game3.Content = "Ringwood Gold v Wonga Park Gold";
            Game4.Content = "Mount Evelyn Gold v LilyDale Gold";
            Game5.Content = "Belgrave Gold v Beaconsfield Upper Gold";
            GoldResultsList.Items.Add(Game1);
            GoldResultsList.Items.Add(Game2);
            GoldResultsList.Items.Add(Game3);
            GoldResultsList.Items.Add(Game4);
            GoldResultsList.Items.Add(Game5);
            Results_Grid.Children.Add(GoldResultsList);
        }
        private void GoldDivisionRound2list()
        {
            ListBox GoldResultsList = new ListBox();
            ListBoxItem Game1 = new ListBoxItem();
            ListBoxItem Game2 = new ListBoxItem();
            ListBoxItem Game3 = new ListBoxItem();
            ListBoxItem Game4 = new ListBoxItem();
            ListBoxItem Game5 = new ListBoxItem();
            Game1.Content = "Scoresby Gold v Mount Waverley Gold";
            Game2.Content = "Wantirna Gold v Mitcham Gold";
            Game3.Content = "Beaconsfield Upper Gold v Wonga Park Gold";
            Game4.Content = "Mount Evelyn Gold v Belgrave Gold";
            Game5.Content = "LilyDale Gold v Ringwood Gold";
            GoldResultsList.Items.Add(Game1);
            GoldResultsList.Items.Add(Game2);
            GoldResultsList.Items.Add(Game3);
            GoldResultsList.Items.Add(Game4);
            GoldResultsList.Items.Add(Game5);
            Results_Grid.Children.Add(GoldResultsList);
        }
        private void GoldDivisionRound3list()
        {
            ListBox GoldResultsList = new ListBox();
            ListBoxItem Game1 = new ListBoxItem();
            ListBoxItem Game2 = new ListBoxItem();
            ListBoxItem Game3 = new ListBoxItem();
            ListBoxItem Game4 = new ListBoxItem();
            ListBoxItem Game5 = new ListBoxItem();
            Game1.Content = "Beaconsfield Upper Gold v Mitcham Gold";
            Game2.Content = "Mount Evelyn Gold v Mount Waverley Gold";
            Game3.Content = "Scoresby Gold v LilyDale Gold";
            Game4.Content = "Wantirna Gold v Belgrave Gold";
            Game5.Content = "Wonga Park Gold v Ringwood Gold";
            GoldResultsList.Items.Add(Game1);
            GoldResultsList.Items.Add(Game2);
            GoldResultsList.Items.Add(Game3);
            GoldResultsList.Items.Add(Game4);
            GoldResultsList.Items.Add(Game5);
            Results_Grid.Children.Add(GoldResultsList);
        }
        private void BlueDivisionRound1List()
        {
            ListBox BlueResultsList = new ListBox();
            ListBoxItem Game1 = new ListBoxItem();
            ListBoxItem Game2 = new ListBoxItem();
            ListBoxItem Game3 = new ListBoxItem();
            ListBoxItem Game4 = new ListBoxItem();
            ListBoxItem Game5 = new ListBoxItem();
            Game1.Content = "Wantirna Blue v Mount Waverley Blue";
            Game2.Content = "Scoresby Blue v Mitcham Blue";
            Game3.Content = "Ringwood Blue v Wonga Park Blue";
            Game4.Content = "Mount Evelyn Blue v LilyDale Blue";
            Game5.Content = "Belgrave Blue v Beaconsfield Upper Blue";
            BlueResultsList.Items.Add(Game1);
            BlueResultsList.Items.Add(Game2);
            BlueResultsList.Items.Add(Game3);
            BlueResultsList.Items.Add(Game4);
            BlueResultsList.Items.Add(Game5);
            Results_Grid.Children.Add(BlueResultsList);
        }
        private void BlueDivisionRound2list()
        {
            ListBox BlueResultsList = new ListBox();
            ListBoxItem Game1 = new ListBoxItem();
            ListBoxItem Game2 = new ListBoxItem();
            ListBoxItem Game3 = new ListBoxItem();
            ListBoxItem Game4 = new ListBoxItem();
            ListBoxItem Game5 = new ListBoxItem();
            Game1.Content = "Scoresby Blue v Mount Waverley Blue";
            Game2.Content = "Wantirna Blue v Mitcham Blue";
            Game3.Content = "Beaconsfield Upper Blue v Wonga Park Blue";
            Game4.Content = "Mount Evelyn Blue v Belgrave Blue";
            Game5.Content = "LilyDale Blue v Ringwood Blue";
            BlueResultsList.Items.Add(Game1);
            BlueResultsList.Items.Add(Game2);
            BlueResultsList.Items.Add(Game3);
            BlueResultsList.Items.Add(Game4);
            BlueResultsList.Items.Add(Game5);
            Results_Grid.Children.Add(BlueResultsList);
        }
        private void BlueDivisionRound3list()
        {
            ListBox BlueResultsList = new ListBox();
            ListBoxItem Game1 = new ListBoxItem();
            ListBoxItem Game2 = new ListBoxItem();
            ListBoxItem Game3 = new ListBoxItem();
            ListBoxItem Game4 = new ListBoxItem();
            ListBoxItem Game5 = new ListBoxItem();
            Game1.Content = "Beaconsfield Upper Blue v Mitcham Blue";
            Game2.Content = "Mount Evelyn Blue v Mount Waverley Blue";
            Game3.Content = "Scoresby Blue v LilyDale Blue";
            Game4.Content = "Wantirna Blue v Belgrave Blue";
            Game5.Content = "Wonga Park Blue v Ringwood Blue";
            BlueResultsList.Items.Add(Game1);
            BlueResultsList.Items.Add(Game2);
            BlueResultsList.Items.Add(Game3);
            BlueResultsList.Items.Add(Game4);
            BlueResultsList.Items.Add(Game5);
            Results_Grid.Children.Add(BlueResultsList);
        }
        private void RedDivisionRound1list()
        {
            ListBox RedResultsList = new ListBox();
            ListBoxItem Game1 = new ListBoxItem();
            ListBoxItem Game2 = new ListBoxItem();
            ListBoxItem Game3 = new ListBoxItem();
            ListBoxItem Game4 = new ListBoxItem();
            ListBoxItem Game5 = new ListBoxItem();
            Game1.Content = "Wantirna Red v Mount Waverley Red";
            Game2.Content = "Scoresby Red v Mitcham Red";
            Game3.Content = "Ringwood Red v Wonga Park Red";
            Game4.Content = "Mount Evelyn Red v LilyDale Red";
            Game5.Content = "Belgrave Red v Beaconsfield Upper Red";
            RedResultsList.Items.Add(Game1);
            RedResultsList.Items.Add(Game2);
            RedResultsList.Items.Add(Game3);
            RedResultsList.Items.Add(Game4);
            RedResultsList.Items.Add(Game5);
            Results_Grid.Children.Add(RedResultsList);
        }
        private void RedDivisionRound2list()
        {
            ListBox RedResultsList = new ListBox();
            ListBoxItem Game1 = new ListBoxItem();
            ListBoxItem Game2 = new ListBoxItem();
            ListBoxItem Game3 = new ListBoxItem();
            ListBoxItem Game4 = new ListBoxItem();
            ListBoxItem Game5 = new ListBoxItem();
            Game1.Content = "Scoresby Red v Mount Waverley Red";
            Game2.Content = "Wantirna Blue v Mitcham Red";
            Game3.Content = "Beaconsfield Upper Red v Wonga Park Red";
            Game4.Content = "Mount Evelyn Red v Belgrave Red";
            Game5.Content = "LilyDale Red v Ringwood Red";
            RedResultsList.Items.Add(Game1);
            RedResultsList.Items.Add(Game2);
            RedResultsList.Items.Add(Game3);
            RedResultsList.Items.Add(Game4);
            RedResultsList.Items.Add(Game5);
            Results_Grid.Children.Add(RedResultsList);
        }
        private void RedDivisionRound3list()
        {
            ListBox RedResultsList = new ListBox();
            ListBoxItem Game1 = new ListBoxItem();
            ListBoxItem Game2 = new ListBoxItem();
            ListBoxItem Game3 = new ListBoxItem();
            ListBoxItem Game4 = new ListBoxItem();
            ListBoxItem Game5 = new ListBoxItem();
            Game1.Content = "Beaconsfield Upper Red v Mitcham Red";
            Game2.Content = "Mount Evelyn Red v Mount Waverley Red";
            Game3.Content = "Scoresby Red v LilyDale Red";
            Game4.Content = "Wantirna Red v Belgrave Red";
            Game5.Content = "Wonga Park Red v Ringwood Red";
            RedResultsList.Items.Add(Game1);
            RedResultsList.Items.Add(Game2);
            RedResultsList.Items.Add(Game3);
            RedResultsList.Items.Add(Game4);
            RedResultsList.Items.Add(Game5);
            Results_Grid.Children.Add(RedResultsList);
        }
        public Results()
        {
            InitializeComponent();
            //GoldDivisionRound1list();
        }

        private void ResultsButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Results());
        }

        private void ClubsButton_Click(object sender, RoutedEventArgs e)
        {

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

        private void FindRoundButton_Click(object sender, RoutedEventArgs e)
        {
            if (DivisionBox.Text == "Gold" && RoundBox.Text == "Round 1")
            {
                GoldDivisionRound1list();
            }
            else if (DivisionBox.Text == "Gold" && RoundBox.Text == "Round 2")
            {
                GoldDivisionRound2list();
            }
            else if (DivisionBox.Text == "Gold" && RoundBox.Text == "Round 3")
            {
                GoldDivisionRound3list();
            }
            else if (DivisionBox.Text == "Blue" && RoundBox.Text == "Round 1")
            {
                BlueDivisionRound1List();
            }
            else if (DivisionBox.Text == "Blue" && RoundBox.Text == "Round 2")
            {
                BlueDivisionRound2list();
            }
            else if (DivisionBox.Text == "Blue" && RoundBox.Text == "Round 3")
            {
                BlueDivisionRound3list();
            }
            else if (DivisionBox.Text == "Red" && RoundBox.Text == "Round 1")
            {
                RedDivisionRound1list();
            }
            else if (DivisionBox.Text == "Red" && RoundBox.Text == "Round 2")
            {
                RedDivisionRound2list();
            }
            else if (DivisionBox.Text == "Red" && RoundBox.Text == "Round 3")
            {
                RedDivisionRound3list();
            }
        }
        private void UpdateLadderButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ladder Calculated! Click View Ladder.");
        }

        private void ViewLadderButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new ViewLadder());
        }

    }
}
