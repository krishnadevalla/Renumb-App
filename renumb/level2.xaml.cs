using System;
using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;

namespace renumb
{
    public sealed partial class level2 : Page
    {
        private DispatcherTimer snow = new DispatcherTimer();
        DispatcherTimer time = new DispatcherTimer();
        Queue<int> qel2 = new Queue<int>(50);
        Queue<int> afterQ = new Queue<int>(50);
        int l2starttimemin, l2starttimesec, l2endtimemin, l2endtimesec;
        int findnum = 0;
        int over = 1;
        int score=0;
        int score1 = 0;
        public level2()
        {
            this.InitializeComponent();
            time.Interval = new TimeSpan(0, 0, 1);
            time.Tick += time_Tick;
        }

        void time_Tick(object sender, object e)
        {
            score++;
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            score1 = (int)e.Parameter;
            snow.Interval = new TimeSpan(0, 0, 30);
            snow.Tick += snow_Tick;
            snow.Start();
            snowfall1.Begin();
            snowfall1.AutoReverse = false;
            settextl2();
            afterQ.Clear();
            time.Start();
        }
        void snow_Tick(object sender, object e)
        {
            snowfall1.Begin();            
        }
        private void settextl2()
        {
            int index = 0, i = 0;
            qel2.Clear();
            Random rml2 = new Random();
            do
            {
                i = rml2.Next(50) + 1;
                if (!qel2.Contains(i))
                {
                    qel2.Enqueue(i);
                    index++;
                }
            } while (index < 50);

            l_1.Text = qel2.Dequeue().ToString();

            l_2.Text = qel2.Dequeue().ToString();

            l_3.Text = qel2.Dequeue().ToString();

            l_4.Text = qel2.Dequeue().ToString();

            l_5.Text = qel2.Dequeue().ToString();

            l_6.Text = qel2.Dequeue().ToString();

            l_7.Text = qel2.Dequeue().ToString();

            l_8.Text = qel2.Dequeue().ToString();

            l_9.Text = qel2.Dequeue().ToString();

            l_10.Text = qel2.Dequeue().ToString();

            l_11.Text = qel2.Dequeue().ToString();

            l_12.Text = qel2.Dequeue().ToString();

            l_13.Text = qel2.Dequeue().ToString();

            l_14.Text = qel2.Dequeue().ToString();

            l_15.Text = qel2.Dequeue().ToString();

            l_16.Text = qel2.Dequeue().ToString();

            l_17.Text = qel2.Dequeue().ToString();

            l_18.Text = qel2.Dequeue().ToString();

            l_19.Text = qel2.Dequeue().ToString();

            l_20.Text = qel2.Dequeue().ToString();

            l_21.Text = qel2.Dequeue().ToString();

            l_22.Text = qel2.Dequeue().ToString();

            l_23.Text = qel2.Dequeue().ToString();

            l_24.Text = qel2.Dequeue().ToString();

            l_25.Text = qel2.Dequeue().ToString();

            l_26.Text = qel2.Dequeue().ToString();

            l_27.Text = qel2.Dequeue().ToString();

            l_28.Text = qel2.Dequeue().ToString();

            l_29.Text = qel2.Dequeue().ToString();

            l_30.Text = qel2.Dequeue().ToString();

            l_31.Text = qel2.Dequeue().ToString();

            l_32.Text = qel2.Dequeue().ToString();

            l_33.Text = qel2.Dequeue().ToString();
            l_34.Text = qel2.Dequeue().ToString();
            l_35.Text = qel2.Dequeue().ToString();

            l_36.Text = qel2.Dequeue().ToString();

            l_37.Text = qel2.Dequeue().ToString();

            l_38.Text = qel2.Dequeue().ToString();

            l_39.Text = qel2.Dequeue().ToString();

            l_40.Text = qel2.Dequeue().ToString();

            l_41.Text = qel2.Dequeue().ToString();

            l_42.Text = qel2.Dequeue().ToString();

            l_43.Text = qel2.Dequeue().ToString();

            l_44.Text = qel2.Dequeue().ToString();

            l_45.Text = qel2.Dequeue().ToString();

            l_46.Text = qel2.Dequeue().ToString();

            l_47.Text = qel2.Dequeue().ToString();

            l_48.Text = qel2.Dequeue().ToString();

            l_49.Text = qel2.Dequeue().ToString();

            l_50.Text = qel2.Dequeue().ToString();



        }
        private void displaynum()
        {
            Random ch = new Random();
          a:  findnum = ch.Next(50) + 1;
            if (!afterQ.Contains(findnum))
            {
                number.Text = findnum.ToString();
                afterQ.Enqueue(findnum);
            }
            else
            {
                goto a;
            }

        }
        private bool checkfunl2(string p)
        {
            if (p == findnum.ToString())
            {
                
                correct.Play();
                displaynum();
                over++;
                if (over==50)
                {
                    snow.Stop();
                    time.Stop();
                    totaltime.Text = score.ToString() + " Seconds";
                    if (score < 50)
                    {
                        score = 300;
                    }
                    else if (score>50&&score<100)
                    {
                        score = 250;
                    }
                    else if (score>100&&score<200)
                    {
                        score = 189;
                    }
                    else if (score>200)
                    {
                        score = 139;
                    }

                    timegrid.Visibility = Visibility.Visible;
                }
                return true;
            }
            else
                return false;
        }
        private void l_1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_1.Text))
            {
                l_1.Opacity = 0;
                               
            }


        }
        private void l_2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_2.Text))
            {
                l_2.Opacity = 0;
                
            }
        }

        private void l_3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_3.Text))
            {
                l_3.Opacity = 0;
               
            }
        }

        private void l_4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_4.Text))
            {
                l_4.Opacity = 0;
               
               
            }
        }

        private void l_5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_5.Text))
            {
                l_5.Opacity = 0;
                
                
            }
        }

        private void l_6_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_6.Text))
            {
                l_6.Opacity = 0;
            }
        }

        private void l_7_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_7.Text))
            {
                l_7.Opacity = 0;
            }
        }

        private void l_8_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_8.Text))
            {
                l_8.Opacity = 0;
            }
        }

        private void l_9_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_9.Text))
            {
                l_9.Opacity = 0;
            }
        }

        private void l_10_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_10.Text))
            {
                l_10.Opacity = 0;
            }
        }

        private void l_11_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_11.Text))
            {
                l_11.Opacity = 0;
            }
        }

        private void l_12_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_12.Text))
            {
                l_12.Opacity = 0;
            }
        }

        private void l_13_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_13.Text))
            {
                l_13.Opacity = 0;
            }
        }
            
        private void l_14_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_14.Text))
            {
                l_14.Opacity = 0;
            }
        }

        private void l_15_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_15.Text))
            {
                l_15.Opacity = 0;
            }
        }

        private void l_16_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_16.Text))
            {
                l_16.Opacity = 0;
            }
        }

        private void l_17_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_17.Text))
            {
                l_17.Opacity = 0;
            }
        }

        private void l_18_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_18.Text))
            {
                l_18.Opacity = 0;
            }
        }

        private void l_19_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_19.Text))
            {
                l_19.Opacity = 0;
            }
        }

        private void l_20_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_20.Text))
            {
                l_20.Opacity = 0;
            }
        }

        private void l_21_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_21.Text))
            {
                l_21.Opacity = 0;
            }
        }

        private void l_22_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_22.Text))
            {
                l_22.Opacity = 0;
            }
        }

        private void l_23_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_23.Text))
            {
                l_23.Opacity = 0;
            }
        }

        private void l_24_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_24.Text))
            {
                l_24.Opacity = 0;
            }
        }

        private void l_25_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_25.Text))
            {
                l_25.Opacity = 0;
            }
        }

       

        private void l_26_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_26.Text))
            {
                l_26.Opacity = 0;
            }
        }

        private void l_27_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_27.Text))
            {
                l_27.Opacity = 0;
            }
        }

        private void l_28_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_28.Text))
            {
                l_28.Opacity = 0;
            }
        }

        private void l_29_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_29.Text))
            {
                l_29.Opacity = 0;
            }
        }

        private void l_30_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_30.Text))
            {
                l_30.Opacity = 0;
            }
        }

        private void l_31_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_31.Text))
            {
                l_31.Opacity = 0;
            }
        }

        private void l_32_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_32.Text))
            {
                l_32.Opacity = 0;
            }
        }

        private void l_33_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_33.Text))
            {
                l_33.Opacity = 0;
            }
        }

        private void l_34_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_34.Text))
            {
                l_34.Opacity = 0;
            }
        }

        private void l_35_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_35.Text))
            {
                l_35.Opacity = 0;
            }
        }

        private void l_36_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_36.Text))
            {
                l_36.Opacity = 0;
            }
        }

        private void l_37_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_37.Text))
            {
                l_37.Opacity = 0;
            }
        }

        private void l_38_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_38.Text))
            {
                l_38.Opacity = 0;
            }
        }

        private void l_39_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_39.Text))
            {
                l_39.Opacity = 0;
            }
        }

        private void l_40_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_40.Text))
            {
                l_40.Opacity = 0;
            }
        }

        private void l_41_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_41.Text))
            {
                l_41.Opacity = 0;
            }
        }

        private void l_42_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_42.Text))
            {
                l_42.Opacity = 0;
            }
        }

        private void l_43_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_43.Text))
            {
                l_43.Opacity = 0;
            }
        }

        private void l_44_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_44.Text))
            {
                l_44.Opacity = 0;
            }
        }

        private void l_45_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_45.Text))
            {
                l_45.Opacity = 0;
            }
        }

        private void l_46_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_46.Text))
            {
                l_46.Opacity = 0;
            }
        }

        private void l_47_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_47.Text))
            {
                l_47.Opacity = 0;
            }
        }

        private void l_48_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_48.Text))
            {
                l_48.Opacity = 0;
            }
        }

        private void l_49_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_49.Text))
            {
                l_49.Opacity = 0;
            }
        }

        private void l_50_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfunl2(l_50.Text))
            {
                l_50.Opacity = 0;
            }
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            help.Visibility = Visibility.Collapsed;
            l2starttimemin = DateTime.Now.Minute;
            l2starttimesec = DateTime.Now.Second;
            displaynum();
        }

        private void retry_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(level2));
        }

        private void nl_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(asmdinstructions), (int)(score + score1));
        }
    }
}
