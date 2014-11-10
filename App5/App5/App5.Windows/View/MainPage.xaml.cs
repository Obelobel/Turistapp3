// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238
using Windows.UI.Xaml.Controls;
using App5.Model;
using App5.Viewmodel;

namespace App5.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            
        }

        MainViewModel viewmodel = new MainViewModel();

        private void bones_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            MainViewModel.SelectedRestaurant = viewmodel.Restauranter.Restaurants[0];
            this.Frame.Navigate(typeof (DetailedPage));
        }

        private void jensen_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            MainViewModel.SelectedRestaurant = viewmodel.Restauranter.Restaurants[1];
            this.Frame.Navigate(typeof (DetailedPage));
        }
    }
}