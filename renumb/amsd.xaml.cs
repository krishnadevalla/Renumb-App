using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;


namespace renumb
{
    
    public sealed partial class amsd : Page
    {
        int f, s, r,count=0,signnum,time=0;
        int score = 40;
        int score1 = 0;
        int[] array=new int[20];
        DispatcherTimer dt = new DispatcherTimer();
        public amsd()
        {
            this.InitializeComponent();
            dt.Interval = new TimeSpan(0, 0, 1);
            dt.Tick += dt_Tick;
        }

        void dt_Tick(object sender, object e)
        {
            time++;
        }

        
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            score1 = (int)e.Parameter;
            
        }

        private void Grid_Loaded_1(object sender, RoutedEventArgs e)
        {
            
           
        }
        public void loadtext()
        {
           
            count++;
            Random sign = new Random();
            signnum = sign.Next(1, 4);
            a:Random rm = new Random();
            if (signnum==3)
            {
                f=rm.Next(1,50);
                s = rm.Next(1, 50);
                fnum.Text = f.ToString();
                snum.Text = s.ToString();
                signtxt.Text = "*";
                r = f * s;
                goto b;
            }
            
            f = rm.Next(100, 1000);
            s = rm.Next(100, 1000);
            if (f>s)
            {
                fnum.Text = f.ToString();
                snum.Text = s.ToString();
            }
            else
            {
                goto a;
            }
            if (signnum == 1)
            {
                signtxt.Text = "+";
                r = f + s;
            }
            else if (signnum == 2)
            {
                signtxt.Text = "-";
                r = f - s;
            }

        b: ;
        }

       
        private void go_Click(object sender, RoutedEventArgs e)
        {
            if (res.Text != "")
            {
                if (res.Text==r.ToString())
                {
                    if (count<=10)
                    {
                        notify.Text = "Great Job";
                        score += 40;
                        res.Text = "";
                        loadtext();
                    }
                    else if(count>2)
                    {
                        next_grid.Visibility = Visibility.Visible;
                        notify.Text = "You took " + time.ToString() + " seconds"; 
                    }
                   
                }
                 
                else
                {
                    notify.Text = "Missed";
                    count++;
                    res.Text = "";
                    loadtext();
                }
            }
        }

        private void Page_Loaded_1(object sender, RoutedEventArgs e)
        {
           
            loadtext();
            dt.Start();
            
        }

        private void final_btn_Click(object sender, RoutedEventArgs e)
        {
            score1 += score;
            this.Frame.Navigate(typeof(final),(int)score1);
        }
    }
}
