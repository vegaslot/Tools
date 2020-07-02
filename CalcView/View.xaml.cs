using Calculator;
using System.Windows;

namespace CalcView
{
    /// <summary>
    /// Interaction logic for View.xaml
    /// </summary>
    public partial class View : Window
    {
        public View()
        {
            InitializeComponent();
        }

        private void Win_Click(object sender, RoutedEventArgs e)
        {
            var vm = this.DataContext as ViewModel;
            vm.Win();
        }

        private void Lose_Click(object sender, RoutedEventArgs e)
        {
            var vm = this.DataContext as ViewModel;
            vm.Lose();
        }
        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            var vm = this.DataContext as ViewModel;
            vm.Reset();
        }

        private void mc2_Click(object sender, RoutedEventArgs e)
        {
            var vm = this.DataContext as ViewModel;
            vm.Calcurator = new MonteCalro2();
        }

        private void mc3_Click(object sender, RoutedEventArgs e)
        {
            var vm = this.DataContext as ViewModel;
            vm.Calcurator = new MonteCalro3();
        }

        private void cg_Click(object sender, RoutedEventArgs e)
        {
            var vm = this.DataContext as ViewModel;
            vm.Calcurator = new ChampionGame();
        }
    }
}
