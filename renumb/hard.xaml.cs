using System;
using System.Collections.Generic;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;


namespace renumb
{
    public sealed partial class hard : Page
    {
        private DispatcherTimer _tick = new DispatcherTimer();
        private DispatcherTimer _animation = new DispatcherTimer();
  
        int timesec = 0;
        int dumsec = 60;
        int hitcount = 0;
        int over = 0;
        int dummin = 4;
        int textnum;
        double score = 0;
        int score1;
        int counthit = 0;
        Stack<int> hMyQ = new Stack<int>(100);
        Queue<int>hqe = new Queue<int>(100);

        public hard()
        {
            this.InitializeComponent();
            score = 0;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            score1 = (int)e.Parameter;
            hardmediatap.Stop();
            harderrormedia.Stop();
            
        }
        private void hardpage_Loaded(object sender, RoutedEventArgs e)
        {
            var messageDialog = new Windows.UI.Popups.MessageDialog("Do you want to play Hard game", "Hi Player");



            messageDialog.Commands.Add(new UICommand("Yes", (command) =>
            {

                harddispname.Text = "Hi Player!";

                hardsettext();
                quebuff();


                hardtickmedia.Play();
                ticktime();


            }));

            messageDialog.Commands.Add(new UICommand("No", (command) =>
            {

                this.Frame.Navigate(typeof(game));

            }));
            messageDialog.DefaultCommandIndex = 1;
            messageDialog.ShowAsync();



        }

        private void ticktime()
        {
            _tick = new DispatcherTimer();
            _animation = new DispatcherTimer();
            _tick.Interval = new TimeSpan(0, 0, 0, 1, 0);
            _animation.Interval = new TimeSpan(0, 0, 55);
            _tick.Tick += _tick_Tick;
           
            _tick.Start();
            _animation.Start();
        }
        private void home_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(game));
        }

        private void _tick_Tick(object sender, object e)
        {
            harddisplaymin.Text = dummin.ToString();
            harddisplaysec.Text = dumsec.ToString();
            dumsec--;
            if (counthit >= 10 && dumsec < 15 && dummin == 4)
            {
                if (dumsec > 10)
                {
                    score += 3;
                    hitcount++;
                    hardextrahit.Text = "Extra HIT " + hitcount;
                }
            }
            else if (counthit >= 17 && dumsec < 45 && dummin == 3)
            {
                if(dumsec>30)
                {
                score += 3;
                hitcount++;
                hardextrahit.Text = "Extra HIT " + hitcount;
                }
            }
            else if (counthit >=29  && dumsec < 50 && dummin == 2)
            {
                if (dumsec > 35)
                {
                    score += 2;
                    hitcount++;
                    hardextrahit.Text = "Extra HIT " + hitcount;
                }
            }
            else if (counthit >= 40 && dumsec < 30 && dummin == 1)
            {
                if (dumsec>20)
                {
                    score += 2;
                    hitcount++;
                    hardextrahit.Text = "Extra HIT " + hitcount;
                }
                
            }
            else if (counthit >= 70 && dumsec < 30 && dummin ==00 )
            {
                if(dumsec>10)
                {
                score += 5;
                hitcount++;
                hardextrahit.Text = "Extra HIT " + hitcount;
                }    
            }
            if (dumsec == 0 && dummin != 0)
            {
                dummin--;
                dumsec = 60;
            }
            else if (dumsec == -1 && dummin == 0)
            {
                _tick.Stop();
                hardtickmedia.Stop();
                if (over == 0)
                {

                    
                    scorebordfall.Begin();
                }

            }


            harddispscore.Text = score.ToString();
            

        }

        private void quebuff()
        {
            hMyQ.Clear();

            for (int q = 100; q > 0; q--)
            {
                hMyQ.Push(q);
            }
        }

        private void hardsettext()
        {
            int index = 0, i = 0;
           hqe.Clear();
            Random rm = new Random();
            do
            {
                i = rm.Next(100) + 1;
                if (!hqe.Contains(i))
                {
                   hqe.Enqueue(i);
                    index++;
                }
            } while (index < 100);
            H_1.Text =hqe.Dequeue().ToString();

            H_2.Text =hqe.Dequeue().ToString();

            H_3.Text =hqe.Dequeue().ToString();

            H_4.Text =hqe.Dequeue().ToString();

            H_5.Text =hqe.Dequeue().ToString();

            H_6.Text =hqe.Dequeue().ToString();

            H_7.Text =hqe.Dequeue().ToString();

            H_8.Text =hqe.Dequeue().ToString();

            H_9.Text =hqe.Dequeue().ToString();

            H_10.Text =hqe.Dequeue().ToString();

            H_11.Text =hqe.Dequeue().ToString();

            H_12.Text =hqe.Dequeue().ToString();

            H_13.Text =hqe.Dequeue().ToString();

            H_14.Text =hqe.Dequeue().ToString();

            H_15.Text =hqe.Dequeue().ToString();

            H_16.Text =hqe.Dequeue().ToString();

            H_17.Text =hqe.Dequeue().ToString();

            H_18.Text =hqe.Dequeue().ToString();

            H_19.Text =hqe.Dequeue().ToString();

            H_20.Text =hqe.Dequeue().ToString();

            H_21.Text =hqe.Dequeue().ToString();

            H_22.Text =hqe.Dequeue().ToString();

            H_23.Text =hqe.Dequeue().ToString();

            H_24.Text =hqe.Dequeue().ToString();

            H_25.Text =hqe.Dequeue().ToString();

            H_26.Text =hqe.Dequeue().ToString();

            H_27.Text =hqe.Dequeue().ToString();

            H_28.Text =hqe.Dequeue().ToString();

            H_29.Text =hqe.Dequeue().ToString();

            H_30.Text =hqe.Dequeue().ToString();

            H_31.Text =hqe.Dequeue().ToString();

            H_32.Text =hqe.Dequeue().ToString();

            H_33.Text =hqe.Dequeue().ToString();
            H_34.Text =hqe.Dequeue().ToString();
            H_35.Text =hqe.Dequeue().ToString();

            H_36.Text =hqe.Dequeue().ToString();

            H_37.Text =hqe.Dequeue().ToString();

            H_38.Text =hqe.Dequeue().ToString();

            H_39.Text =hqe.Dequeue().ToString();

            H_40.Text =hqe.Dequeue().ToString();

            H_41.Text =hqe.Dequeue().ToString();

            H_42.Text =hqe.Dequeue().ToString();

            H_43.Text =hqe.Dequeue().ToString();

            H_44.Text =hqe.Dequeue().ToString();

            H_45.Text =hqe.Dequeue().ToString();

            H_46.Text =hqe.Dequeue().ToString();

            H_47.Text =hqe.Dequeue().ToString();

            H_48.Text =hqe.Dequeue().ToString();

            H_49.Text =hqe.Dequeue().ToString();

            H_50.Text =hqe.Dequeue().ToString();
            H_51.Text = hqe.Dequeue().ToString();

            H_52.Text = hqe.Dequeue().ToString();

            H_53.Text = hqe.Dequeue().ToString();

            H_54.Text = hqe.Dequeue().ToString();

            H_55.Text = hqe.Dequeue().ToString();

            H_56.Text = hqe.Dequeue().ToString();

            H_57.Text = hqe.Dequeue().ToString();

            H_58.Text = hqe.Dequeue().ToString();

            H_59.Text = hqe.Dequeue().ToString();

            H_60.Text = hqe.Dequeue().ToString();

            H_61.Text = hqe.Dequeue().ToString();

            H_62.Text = hqe.Dequeue().ToString();

            H_63.Text = hqe.Dequeue().ToString();

            H_64.Text = hqe.Dequeue().ToString();

            H_65.Text = hqe.Dequeue().ToString();

            H_66.Text = hqe.Dequeue().ToString();

            H_67.Text = hqe.Dequeue().ToString();

            H_68.Text = hqe.Dequeue().ToString();

            H_69.Text = hqe.Dequeue().ToString();

            H_70.Text = hqe.Dequeue().ToString();

            H_71.Text = hqe.Dequeue().ToString();

            H_72.Text = hqe.Dequeue().ToString();

            H_73.Text = hqe.Dequeue().ToString();

            H_74.Text = hqe.Dequeue().ToString();

            H_75.Text = hqe.Dequeue().ToString();

            H_76.Text = hqe.Dequeue().ToString();

            H_77.Text = hqe.Dequeue().ToString();

            H_78.Text = hqe.Dequeue().ToString();

            H_79.Text = hqe.Dequeue().ToString();

            H_80.Text = hqe.Dequeue().ToString();

            H_81.Text = hqe.Dequeue().ToString();

            H_82.Text = hqe.Dequeue().ToString();

            H_83.Text = hqe.Dequeue().ToString();
            H_84.Text = hqe.Dequeue().ToString();
            H_85.Text = hqe.Dequeue().ToString();

            H_86.Text = hqe.Dequeue().ToString();

            H_87.Text = hqe.Dequeue().ToString();

            H_88.Text = hqe.Dequeue().ToString();

            H_89.Text = hqe.Dequeue().ToString();

            H_90.Text = hqe.Dequeue().ToString();

            H_91.Text = hqe.Dequeue().ToString();

            H_92.Text = hqe.Dequeue().ToString();

            H_93.Text = hqe.Dequeue().ToString();

            H_94.Text = hqe.Dequeue().ToString();

            H_95.Text = hqe.Dequeue().ToString();

            H_96.Text = hqe.Dequeue().ToString();

            H_97.Text = hqe.Dequeue().ToString();

            H_98.Text = hqe.Dequeue().ToString();

            H_99.Text = hqe.Dequeue().ToString();

            H_100.Text = hqe.Dequeue().ToString();


        }



        private bool checkfun(string txt)
        {
            textnum = hMyQ.Pop();
            if (txt == textnum.ToString())
            {
                hardmediatap.Play();
                score += 10;
                hardlasthit.Text = txt;
                counthit++;
                if (counthit == 100)
                {
                    hardscoregrid.Visibility = Visibility.Visible;
                    hardgridtext.Text = "Congs!! Your score is "+score+"\n Extra hits are " + hitcount;
                    scorebordfall.Begin();
                    over = 1;
                }
                harddispscore.Text = score.ToString();
                return true;

            }
            else
            {
                harderrormedia.Play();
                hMyQ.Push(textnum);
                score -= 5;
                harddispscore.Text = score.ToString();
                return false;
            }

        }
        private void H_1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_1.Text))
            {
                H_1.Opacity = 0.3;
            }


        }


        private void H_2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_2.Text))
            {
                H_2.Opacity = 0.3;
            }
        }

        private void H_3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_3.Text))
            {
                H_3.Opacity = 0.3;
            }
        }

        private void H_4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_4.Text))
            {
                H_4.Opacity = 0.3;
            }
        }

        private void H_5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_5.Text))
            {
                H_5.Opacity = 0.3;
            }
        }

        private void H_6_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_6.Text))
            {
                H_6.Opacity = 0.3;
            }
        }

        private void H_7_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_7.Text))
            {
                H_7.Opacity = 0.3;
            }
        }

        private void _8_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_8.Text))
            {
                H_8.Opacity = 0.3;
            }
        }

        private void _9_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_9.Text))
            {
                H_9.Opacity = 0.3;
            }
        }

        private void H_10_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_10.Text))
            {
                H_10.Opacity = 0.3;
            }
        }

        private void H_11_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_11.Text))
            {
                H_11.Opacity = 0.3;
            }
        }

        private void H_12_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_12.Text))
            {
                H_12.Opacity = 0.3;
            }
        }

        private void H_13_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_13.Text))
            {
                H_13.Opacity = 0.3;
            }
        }

        private void reload_Tapped(object sender, TappedRoutedEventArgs e)
        {

            this.Frame.Navigate(typeof(hard),(int) score1);

        }

        private void reload_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            reload.Opacity = 0.3;
        }

        private void reload_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            reload.Opacity = 1;
        }

        private void home_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            home.Opacity = 0.3;
        }

        private void home_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            home.Opacity = 1;
        }

        private void replay_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(hard),(int) score1);
        }

        private void quit_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Exit();
        }

        private void H_14_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_14.Text))
            {
                H_14.Opacity = 0.3;
            }
        }

        private void H_15_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_15.Text))
            {
                H_15.Opacity = 0.3;
            }
        }

        private void H_16_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_16.Text))
            {
                H_16.Opacity = 0.3;
            }
        }

        private void H_17_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_17.Text))
            {
                H_17.Opacity = 0.3;
            }
        }

        private void H_18_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_18.Text))
            {
                H_18.Opacity = 0.3;
            }
        }

        private void H_19_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_19.Text))
            {
                H_19.Opacity = 0.3;
            }
        }

        private void H_20_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_20.Text))
            {
                H_20.Opacity = 0.3;
            }
        }

        private void H_21_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_21.Text))
            {
                H_21.Opacity = 0.3;
            }
        }

        private void H_22_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_22.Text))
            {
                H_22.Opacity = 0.3;
            }
        }

        private void H_23_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_23.Text))
            {
                H_23.Opacity = 0.3;
            }
        }

        private void H_24_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_24.Text))
            {
                H_24.Opacity = 0.3;
            }
        }

        private void H_25_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_25.Text))
            {
                H_25.Opacity = 0.3;
            }
        }

        private void H_26_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_26.Text))
            {
                H_26.Opacity = 0.3;
            }
        }

        private void H_27_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_27.Text))
            {
                H_27.Opacity = 0.3;
            }
        }

        private void H_28_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_28.Text))
            {
                H_28.Opacity = 0.3;
            }
        }

        private void H_29_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_29.Text))
            {
                H_29.Opacity = 0.3;
            }
        }

        private void H_30_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_30.Text))
            {
                H_30.Opacity = 0.3;
            }
        }

        private void H_31_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_31.Text))
            {
                H_31.Opacity = 0.3;
            }
        }

        private void H_32_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_32.Text))
            {
                H_32.Opacity = 0.3;
            }
        }

        private void H_33_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_33.Text))
            {
                H_33.Opacity = 0.3;
            }
        }

        private void H_34_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_34.Text))
            {
                H_34.Opacity = 0.3;
            }
        }

        private void H_35_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_35.Text))
            {
                H_35.Opacity = 0.3;
            }
        }

        private void H_36_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_36.Text))
            {
                H_36.Opacity = 0.3;
            }
        }

        private void H_37_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_37.Text))
            {
                H_37.Opacity = 0.3;
            }
        }

        private void H_38_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_38.Text))
            {
                H_38.Opacity = 0.3;
            }
        }

        private void H_39_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_39.Text))
            {
                H_39.Opacity = 0.3;
            }
        }

        private void H_40_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_40.Text))
            {
                H_40.Opacity = 0.3;
            }
        }

        private void H_41_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_41.Text))
            {
                H_41.Opacity = 0.3;
            }
        }

        private void H_42_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_42.Text))
            {
                H_42.Opacity = 0.3;
            }
        }

        private void H_43_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_43.Text))
            {
                H_43.Opacity = 0.3;
            }
        }

        private void H_44_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_44.Text))
            {
                H_44.Opacity = 0.3;
            }
        }

        private void H_45_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_45.Text))
            {
                H_45.Opacity = 0.3;
            }
        }

        private void H_46_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_46.Text))
            {
                H_46.Opacity = 0.3;
            }
        }

        private void H_47_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_47.Text))
            {
                H_47.Opacity = 0.3;
            }
        }

        private void H_48_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_48.Text))
            {
                H_48.Opacity = 0.3;
            }
        }

        private void H_49_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_49.Text))
            {
                H_49.Opacity = 0.3;
            }
        }

        private void H_50_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_50.Text))
            {
                H_50.Opacity = 0.3;
            }
        }

       
        private void H_100_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_100.Text))
            {
                H_100.Opacity = 0.3;
            }
        }

        private void H_99_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_99.Text))
            {
                H_99.Opacity = 0.3;
            }
        }

        private void H_98_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_98.Text))
            {
                H_98.Opacity = 0.3;
            }
        }

        private void H_97_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_97.Text))
            {
                H_97.Opacity = 0.3;
            }
        }

        private void H_96_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_96.Text))
            {
                H_96.Opacity = 0.3;
            }
        }

        private void H_95_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_95.Text))
            {
                H_95.Opacity = 0.3;
            }
        }

        private void H_94_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_94.Text))
            {
                H_94.Opacity = 0.3;
            }
        }

        private void H_93_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_93.Text))
            {
                H_93.Opacity = 0.3;
            }
        }

        private void H_92_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_92.Text))
            {
                H_92.Opacity = 0.3;
            }
        }

        private void H_91_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_91.Text))
            {
                H_91.Opacity = 0.3;
            }
        }

        private void H_90_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_90.Text))
            {
                H_90.Opacity = 0.3;
            }
        }

        private void H_89_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_89.Text))
            {
                H_89.Opacity = 0.3;
            }
        }

        private void H_88_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_88.Text))
            {
                H_88.Opacity = 0.3;
            }
        }

        private void H_87_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_87.Text))
            {
                H_87.Opacity = 0.3;
            }
        }

        private void H_86_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_86.Text))
            {
                H_86.Opacity = 0.3;
            }
        }

        private void H_85_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_85.Text))
            {
                H_85.Opacity = 0.3;
            }
        }

        private void H_84_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_84.Text))
            {
                H_84.Opacity = 0.3;
            }
        }

       
        private void H_83_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_83.Text))
            {
                H_83.Opacity = 0.3;
            }
        }

        private void H_82_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_82.Text))
            {
                H_82.Opacity = 0.3;
            }
        }

        private void H_81_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_81.Text))
            {
                H_81.Opacity = 0.3;
            }
        }

        private void H_80_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_80.Text))
            {
                H_80.Opacity = 0.3;
            }
        }

        private void H_79_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_79.Text))
            {
                H_79.Opacity = 0.3;
            }
        }

        private void H_78_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_78.Text))
            {
                H_78.Opacity = 0.3;
            }
        }

        private void H_77_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_77.Text))
            {
                H_77.Opacity = 0.3;
            }
        }

        private void H_76_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_76.Text))
            {
                H_76.Opacity = 0.3;
            }
        }

        private void H_75_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_75.Text))
            {
                H_75.Opacity = 0.3;
            }
        }

        private void H_74_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_74.Text))
            {
                H_74.Opacity = 0.3;
            }
        }

        private void H_73_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_73.Text))
            {
                H_73.Opacity = 0.3;
            }
        }

        private void H_72_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_72.Text))
            {
                H_72.Opacity = 0.3;
            }
        }

        private void H_71_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_71.Text))
            {
                H_71.Opacity = 0.3;
            }
        }

        private void H_70_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_70.Text))
            {
                H_70.Opacity = 0.3;
            }
        }

        private void H_69_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_69.Text))
            {
                H_69.Opacity = 0.3;
            }
        }

        private void H_68_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_68.Text))
            {
                H_68.Opacity = 0.3;
            }
        }

        private void H_67_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_67.Text))
            {
                H_67.Opacity = 0.3;
            }
        }

        private void H_66_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_66.Text))
            {
                H_66.Opacity = 0.3;
            }
        }

        private void H_65_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_65.Text))
            {
                H_65.Opacity = 0.3;
            }
        }

        private void H_64_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_64.Text))
            {
                H_64.Opacity = 0.3;
            }
        }

        private void H_63_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_63.Text))
            {
                H_63.Opacity = 0.3;
            }

        }

        private void H_62_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_62.Text))
            {
                H_62.Opacity = 0.3;
            }

        }

        private void H_61_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_61.Text))
            {
                H_61.Opacity = 0.3;
            }
        }

        private void H_60_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_60.Text))
            {
                H_60.Opacity = 0.3;
            }

        }

        private void H_59_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_59.Text))
            {
                H_59.Opacity = 0.3;
            }

        }

        private void H_58_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_58.Text))
            {
                H_58.Opacity = 0.3;
            }

        }

        private void H_57_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_57.Text))
            {
                H_57.Opacity = 0.3;
            }
        }

        private void H_56_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_56.Text))
            {
                H_56.Opacity = 0.3;
            }
        }

        private void H_55_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_55.Text))
            {
                H_55.Opacity = 0.3;
            }
        }

        private void H_54_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_54.Text))
            {
                H_54.Opacity = 0.3;
            }
        }

        private void H_53_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_53.Text))
            {
                H_53.Opacity = 0.3;
            }
        }

        private void H_52_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_52.Text))
            {
                H_52.Opacity = 0.3;
            }
        }

        private void H_51_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_51.Text))
            {
                H_51.Opacity = 0.3;
            }

        }

        private void H_9_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_9.Text))
            {
                H_9.Opacity = 0.3;
            }
        }

        private void H_8_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(H_8.Text))
            {
                H_8.Opacity = 0.3;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            score = (int)score +(int) score1;

            this.Frame.Navigate(typeof(level2),(int)score);
        }

    }
}
      

