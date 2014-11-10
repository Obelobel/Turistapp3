using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Controls;
using App5.Model;
using App5.Viewmodel;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238
using App5.Model;
using App5.Viewmodel;

namespace App5.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DetailedPage : Page
    {
        public DetailedPage()
        {
            this.InitializeComponent();
        }

        private void menu_button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof (KommentarerTest));
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof (MainPage));
        }
    }
}