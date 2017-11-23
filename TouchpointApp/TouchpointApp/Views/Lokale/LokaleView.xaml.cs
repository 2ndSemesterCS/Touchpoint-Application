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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace TouchpointApp.Views.Lokale
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LokaleView : Page
    {
        public LokaleView()
        {
            this.InitializeComponent();
        }

        private void OpretLokaleViewClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(OpretLokaleView), null);
        }

        private void RedigerLokaleViewClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RedigerLokaleView), null);
        }

        private void SletLokaleViewClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SletLokaleView), null);
        }

        private void BackToAdminView(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();
        }

    }
}
