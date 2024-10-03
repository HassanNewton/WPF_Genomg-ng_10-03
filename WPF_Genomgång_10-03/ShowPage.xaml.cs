using System.Windows.Controls;

namespace WPF_Genomgång_10_03
{
    /// <summary>
    /// Interaction logic for ShowPage.xaml
    /// </summary>
    public partial class ShowPage : Page
    {   //Lagt till en parameter name
        public ShowPage(string Name)
        {
            InitializeComponent();
            txtBlockShow.Text = $"Välkommen, {Name}";
        }
    }
}
