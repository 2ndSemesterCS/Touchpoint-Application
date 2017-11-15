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

namespace TouchpointApp.Views.Undervisningssted
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class UndervisningsstedView : Page
    {
        public UndervisningsstedView()
        {
            this.InitializeComponent();
        }

        private void OpretUndervisningsstedViewClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(OpretUndervisningsstedView), null);
        }

        private void RedigerUndervisningsstedViewClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RedigerUndervisningsstedView), null);
        }

        private void SletUndervisningsstedViewClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SletUndervisningsstedView), null);
        }
        public void BackToAdminside(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AdminView), null);
        }
    }
}
