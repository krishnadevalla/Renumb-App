using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace renumb
{
    public sealed partial class final : Page
    {

        int flag = 0, score = 0;
        public final()
        {
            this.InitializeComponent();
            
        }

        void fin_Tick(object sender, object e)
        {
            if (flag==0)
            {
                drim.Begin();
                flag = 1;
            }
            else
            {
                drim.AutoReverse = true;
                flag = 0;
            }
            
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            score = (int)e.Parameter;

        }
        private void Page_Loaded_1(object sender, RoutedEventArgs e)
        {
            drim.Begin();
            drim.Completed += drim_Completed;
            sub.Begin();
            sub.Completed += sub_Completed;
            result.Text = "Your score is :" + score.ToString();
        }

        void drim_Completed(object sender, object e)
        {
            
            if(resbtn.Visibility.Equals(Visibility.Collapsed))
            drim.Begin();
            else
            {
                drim.Stop();
            }
        }

        void sub_Completed(object sender, object e)
        {
           
            drim.Stop();
            resbtn.Visibility = Visibility.Visible;
        }

        private void resbtn_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            res.Text = score.ToString();
        	gridshow.Visibility=Visibility.Visible;
        }

        private void _try_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(prilee));
        }
    }
}
