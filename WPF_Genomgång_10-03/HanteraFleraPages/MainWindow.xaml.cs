using System.Windows;

namespace WPF_Genomgång_10_03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NavigateToStart(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new StartPage());
        }

        private void NavigateToInformation(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new InformationPage());
        }

        private void NavigateToOmOss(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new OmossPage());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {   //Variabel som sparar värdet av det som matas in
            string Name = InputBox.Text;
            MainFrame.Navigate(new ShowPage(Name));
            //Skicka namnet till nästa page
        }
    }
}