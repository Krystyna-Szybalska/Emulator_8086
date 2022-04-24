using System.Windows;

namespace Emulator_8086
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        MainViewModel MainViewModel { get; set; } = new MainViewModel();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = MainViewModel;
            this.Closed += (sender, args) => Application.Current.Shutdown();
        }
        private void MoveButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            MainViewModel.RegisterParameters.Ax = MainViewModel.RegisterParameters.Bx;
        }        

        private void XCHGButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            MainViewModel.RegisterParameters.Ax = null;
            MainViewModel.RegisterParameters.Bx = null;
            MainViewModel.RegisterParameters.Cx = null;
            MainViewModel.RegisterParameters.Dx = null;
        }
    }
}
