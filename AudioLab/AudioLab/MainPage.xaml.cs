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

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace AudioLab
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void NavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            if (args.IsSettingsInvoked)
            {
                ContentFrame.Navigate(typeof(SettingPage));
            }
            else
            {
                //find NavigationViewItem with Content that equals InvokedItem
               var item = sender.MenuItems.OfType<NavigationViewItem>().First(x => (string)x.Content == (string)args.InvokedItem);
                NavView_Navigate(item as NavigationViewItem);
            }
        }

        private void NavView_Navigate(NavigationViewItem item)
        {
            switch (item.Tag)
            {
                case "home":
                    ContentFrame.Navigate(typeof(HomePage));
                    break;

                case "apps":
                    //ContentFrame.Navigate(typeof(AppsPage));
                    break;

                case "games":
                    //ContentFrame.Navigate(typeof(GamesPage));
                    break;

                case "music":
                    //ContentFrame.Navigate(typeof(MusicPage));
                    break;

                case "content":
                    //ContentFrame.Navigate(typeof(MyContentPage));
                    break;
            }
        }

        private void MenuFlyoutItem_Click_Plain(object sender, RoutedEventArgs e)
        {
            string str = "fsdafds";
        }

        private void MenuFlyoutItem_Click_Rich(object sender, RoutedEventArgs e)
        {

        }
    }
}
