﻿using System;
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

namespace TouchpointApp.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class KursusView : Page
    {
        public KursusView()
        {
            this.InitializeComponent();
        }

        private void OpretKursusViewClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(OpretKursusView), null);
        }

        private void RedigerKursusViewClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RedigerKursusView), null);
        }

        private void SletKursusViewClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SletKursusView), null);
        }

        private void BackToAdminView(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();
        }
    }
}
