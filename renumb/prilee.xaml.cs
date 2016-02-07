using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Threading;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace renumb
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class prilee : Page
    {
        private DispatcherTimer dt = new DispatcherTimer();
        public prilee()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void Page_Loaded_1(object sender, RoutedEventArgs e)
        {
            dt.Interval = new TimeSpan(0, 0, 3);
            
            dt.Tick += dt_Tick;
            dt.Start();
            playmusic.Play();
        }

        void dt_Tick(object sender, object e)
        {
           this.Frame.Navigate(typeof(MainPage));
            dt.Stop();

        }
    }
}
