using Windows.UI.Xaml.Controls;

namespace TouchpointApp.Views
{
    public class PageWithBack
    {
        public static void GoBack(Page page)
        {
            page.Frame.Navigate(typeof(MainPage), null);
        }
    }
}