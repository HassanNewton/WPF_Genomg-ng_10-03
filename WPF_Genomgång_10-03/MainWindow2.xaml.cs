using System.Windows;

namespace WPF_Genomgång_10_03
{
    /// <summary>
    /// Interaction logic for MainWindow2.xaml
    /// </summary>
    public partial class MainWindow2 : Window
    {
        public MainWindow2()
        {
            InitializeComponent();
        }

        private void OpenWelcomeWindow(object sender, RoutedEventArgs e)
        {
            //Skapar en ny instans av fönstret
            WelcomeWindow welcomeWindow = new WelcomeWindow();
            welcomeWindow.Show();
        }

        private void OpenInfoWindow(object sender, RoutedEventArgs e)
        {
            //Skapar en ny instans av fönstret
            InfoWindow infoWindow = new InfoWindow();
            infoWindow.Show();
        }
    }
}
