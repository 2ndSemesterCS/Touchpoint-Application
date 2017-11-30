using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using TouchpointApp.Views.Undervisningssted;
using TouchpointApp.Views.Serie;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace TouchpointApp.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AdminView : Page
    {
        public AdminView()
        {
            this.InitializeComponent();
        }

        private void KursistViewClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views.KursistView), null);
        }

        private void KursusViewClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views.KursusView), null);
        }

        private void SerieViewClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SerieView), null);
        }

        private void UnderviserViewClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Views.UnderviserView), null);
        }

        private void UndervisningsstedViewClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UndervisningsstedView), null);
        }

        private void BackToMainPage(object sender, RoutedEventArgs e)
        {
            Frame.GoBack() ;
        }
    }
}
