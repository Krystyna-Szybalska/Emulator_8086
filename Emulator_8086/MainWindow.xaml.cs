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
            string fromRegister = FromRegisterComboBox.Text;
            string toRegister = ToRegisterComboBox.Text;
            
            switch (fromRegister, toRegister)
            {
                case ("AX", "AX"):
                    break;                
                case ("AX", "BX"):
                    MainViewModel.RegisterParameters.Bx = MainViewModel.RegisterParameters.Ax;
                    break;                
                case ("AX", "CX"):
                    MainViewModel.RegisterParameters.Cx = MainViewModel.RegisterParameters.Ax;
                    break;                
                case ("AX", "DX"):
                    MainViewModel.RegisterParameters.Dx = MainViewModel.RegisterParameters.Ax;
                    break;
                case ("BX", "AX"):
                    MainViewModel.RegisterParameters.Ax = MainViewModel.RegisterParameters.Bx;
                    break;                
                case ("BX", "BX"):
                    break;                
                case ("BX", "CX"):
                    MainViewModel.RegisterParameters.Cx = MainViewModel.RegisterParameters.Bx;
                    break;                
                case ("BX", "DX"):
                    MainViewModel.RegisterParameters.Dx = MainViewModel.RegisterParameters.Bx;
                    break;
                case ("CX", "AX"):
                    MainViewModel.RegisterParameters.Ax = MainViewModel.RegisterParameters.Cx;
                    break;                
                case ("CX", "BX"):
                    MainViewModel.RegisterParameters.Bx = MainViewModel.RegisterParameters.Cx;
                    break;                
                case ("CX", "CX"):
                    break;                
                case ("CX", "DX"):
                    MainViewModel.RegisterParameters.Dx = MainViewModel.RegisterParameters.Cx;
                    break;
                case ("DX", "AX"):
                    MainViewModel.RegisterParameters.Ax = MainViewModel.RegisterParameters.Dx;
                    break;                
                case ("DX", "BX"):
                    MainViewModel.RegisterParameters.Bx = MainViewModel.RegisterParameters.Dx;
                    break;                
                case ("DX", "CX"):
                    MainViewModel.RegisterParameters.Cx = MainViewModel.RegisterParameters.Dx;
                    break;                
                case ("DX", "DX"):
                    break;
            }
        }        

        private void XCHGButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            string firstRegister = FirstRegisterComboBox.Text;
            string secondRegister = SecondRegisterComboBox.Text;

            switch (firstRegister, secondRegister)
            {
                case ("AX", "AX"):
                    break;                
                case ("AX", "BX"):
                    (MainViewModel.RegisterParameters.Ax, MainViewModel.RegisterParameters.Bx) = (MainViewModel.RegisterParameters.Bx, MainViewModel.RegisterParameters.Ax);
                    break;                
                case ("AX", "CX"):
                    (MainViewModel.RegisterParameters.Ax, MainViewModel.RegisterParameters.Cx) = (MainViewModel.RegisterParameters.Cx, MainViewModel.RegisterParameters.Ax);
                    break;                
                case ("AX", "DX"):
                    (MainViewModel.RegisterParameters.Ax, MainViewModel.RegisterParameters.Dx) = (MainViewModel.RegisterParameters.Dx, MainViewModel.RegisterParameters.Ax);
                    break;
                case ("BX", "AX"):
                    (MainViewModel.RegisterParameters.Bx, MainViewModel.RegisterParameters.Ax) = (MainViewModel.RegisterParameters.Ax, MainViewModel.RegisterParameters.Bx);
                    break;                
                case ("BX", "BX"):
                    break;                
                case ("BX", "CX"):
                    (MainViewModel.RegisterParameters.Bx, MainViewModel.RegisterParameters.Cx) = (MainViewModel.RegisterParameters.Cx, MainViewModel.RegisterParameters.Bx);
                    break;                
                case ("BX", "DX"):
                    (MainViewModel.RegisterParameters.Bx, MainViewModel.RegisterParameters.Dx) = (MainViewModel.RegisterParameters.Dx, MainViewModel.RegisterParameters.Bx);
                    break;
                case ("CX", "AX"):
                    (MainViewModel.RegisterParameters.Cx, MainViewModel.RegisterParameters.Ax) = (MainViewModel.RegisterParameters.Ax, MainViewModel.RegisterParameters.Cx);
                    break;                
                case ("CX", "BX"):
                    (MainViewModel.RegisterParameters.Cx, MainViewModel.RegisterParameters.Bx) = (MainViewModel.RegisterParameters.Bx, MainViewModel.RegisterParameters.Cx);
                    break;                
                case ("CX", "CX"):
                    break;                
                case ("CX", "DX"):
                    (MainViewModel.RegisterParameters.Cx, MainViewModel.RegisterParameters.Dx) = (MainViewModel.RegisterParameters.Dx, MainViewModel.RegisterParameters.Cx);
                    break;
                case ("DX", "AX"):
                    (MainViewModel.RegisterParameters.Dx, MainViewModel.RegisterParameters.Ax) = (MainViewModel.RegisterParameters.Ax, MainViewModel.RegisterParameters.Dx);
                    break;                
                case ("DX", "BX"):
                    (MainViewModel.RegisterParameters.Dx, MainViewModel.RegisterParameters.Bx) = (MainViewModel.RegisterParameters.Bx, MainViewModel.RegisterParameters.Dx);
                    break;                
                case ("DX", "CX"):
                    (MainViewModel.RegisterParameters.Dx, MainViewModel.RegisterParameters.Cx) = (MainViewModel.RegisterParameters.Cx,MainViewModel.RegisterParameters.Dx);
                    break;                
                case ("DX", "DX"):
                    break;
            }
        }
    }
}
