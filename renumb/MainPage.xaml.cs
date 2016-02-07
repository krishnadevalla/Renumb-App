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
using System.Diagnostics;
using System.Runtime.InteropServices;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace renumb
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private DispatcherTimer dt = new DispatcherTimer();
        public MainPage()
        {
            this.InitializeComponent();
           
                dt.Interval = new TimeSpan(0, 0, 0,3,50);
               
                dt.Tick += dt_Tick;
                
            
        }

        void dt_Tick(object sender, object e)
        {
            this.Frame.Navigate(typeof(game));
            dt.Stop();
            
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            openmedia.Play();
           

        }

        private void enter_Tapped(object sender, TappedRoutedEventArgs e)
        {

            name.Begin();
            dt.Start();
            name.Begin();
          
            

           
        }
    }
}
