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
using Library.Views; // Adding Reference
using Library.Utils; // Adding Reference


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Library
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Loaded += MainPage_Loaded;
        }

        private async void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            //Frame.Navigate(typeof(Login));

            // Load the local Accounts List before navigating to the UserSelection page
            await AccountHelper.LoadAccountListAsync();
            Frame.Navigate(typeof(UserSelection));

        }

        //private void btnPlay_Click(object sender, RoutedEventArgs e)
        //{
        //    media.Play();
        //}

        //private void btnPause_Click(object sender, RoutedEventArgs e)
        //{
        //    media.Pause();
        //}

        //private void btnStop_Click(object sender, RoutedEventArgs e)
        //{
        //    media.Stop();
        //}

        //private void btnBooks_Click(object sender, RoutedEventArgs e)
        //{
        //    this.Frame.Navigate(typeof(Books));
        //}
    }
}
