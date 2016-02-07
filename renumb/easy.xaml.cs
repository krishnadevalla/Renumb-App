using System;
using System.Collections.Generic;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace renumb
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class easy : Page
    {
        private DispatcherTimer _tick = new DispatcherTimer();
        private DispatcherTimer _animation = new DispatcherTimer();
        string pname = "";
        int timesec = 0;
        int over = 0;
        int dumsec = 60;
        int hitcount = 0;
        int dummin = 1;
        int textnum;
        double score = 0;
        int counthit = 0;
      //  Queue<int> myQ = new Queue<int>(50);
        Stack<int> myQ = new Stack<int>(50);
        Queue<int> qe = new Queue<int>(50);   
       
        public easy()
        {
            this.InitializeComponent();
            score = 0;
            
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            pname = e.Parameter as string;
            easymediatap.Stop();
            errormedia.Stop();
           

        }

        private void easypage_Loaded(object sender, RoutedEventArgs e)
        {
            
            var messageDialog = new Windows.UI.Popups.MessageDialog("Do you want to play the game", "Hi, Player");

           

            messageDialog.Commands.Add(new UICommand("Yes", (command) =>
            {

              
                
                settext();
                quebuff();
                cloudmovee.Begin();
                
                tickmedia.Play();
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
            _animation.Tick += _animation_Tick;
            _tick.Start();
            _animation.Start();
        }

        void _animation_Tick(object sender, object e)
        {
            cloudmovee.Begin();
        }

        void _tick_Tick(object sender, object e)
        {
            displaymin.Text = dummin.ToString();
            displaysec.Text = dumsec.ToString();
            dumsec--;
            if (counthit >= 7 && dumsec < 30 && dummin == 1)
            {
                score += 1;
                hitcount++;
                extrahit.Text = "Extra HIT " + hitcount;
            }
            else if (counthit >= 15 && dumsec < 13 && dummin == 1)
            {
                score += 3;
                hitcount++;
                extrahit.Text = "Extra HIT " + hitcount;
            }
            else if (counthit >= 15 && dumsec < 50 && dummin == 0)
            {
                score += 0.5;
                hitcount++;
                extrahit.Text = "Extra HIT " + hitcount;
            }
            else if (counthit >= 20 && dumsec < 30 && dummin == 0)
            {
                score += 0.5;
                hitcount++;
                extrahit.Text = "Extra HIT " + hitcount;
            }
            if (dumsec == 0 && dummin != 0)
            {
                dummin--;
                dumsec = 60;
            }
            else if (dumsec==-1&&dummin==0)
            {
                _tick.Stop();
                tickmedia.Stop();
                scorebordfall.Begin();
                hardgridtext.Text += "Game Over!! \n Score is " + score+"\n Extra hits are "+hitcount;
            }

           
            dispscore.Text = score.ToString();
            

        }

        private void quebuff()
        {
            myQ.Clear();
            
            for (int q = 50; q > 0; q--)
            {
                myQ.Push(q);
            }
        }

        private void settext()
        {
           int index=0,i=0;
           qe.Clear();
            Random rm = new Random();
            do
            {
                i = rm.Next(50) + 1;
                if (!qe.Contains(i))
                {
                    qe.Enqueue(i);
                    index++;
                }
            } while (index < 50);
           
            _1.Text =qe.Dequeue().ToString();
             
            _2.Text = qe.Dequeue().ToString();
             
            _3.Text = qe.Dequeue().ToString();
             
            _4.Text = qe.Dequeue().ToString();
             
            _5.Text = qe.Dequeue().ToString();
             
            _6.Text = qe.Dequeue().ToString();
             
            _7.Text = qe.Dequeue().ToString();
             
            _8.Text = qe.Dequeue().ToString();
             
            _9.Text = qe.Dequeue().ToString();
             
            _10.Text = qe.Dequeue().ToString();
             
            _11.Text = qe.Dequeue().ToString();
             
            _12.Text = qe.Dequeue().ToString();
             
            _13.Text = qe.Dequeue().ToString();
             
            _14.Text = qe.Dequeue().ToString();
             
            _15.Text = qe.Dequeue().ToString();
             
            _16.Text = qe.Dequeue().ToString();
             
            _17.Text = qe.Dequeue().ToString();
             
            _18.Text = qe.Dequeue().ToString();
             
            _19.Text = qe.Dequeue().ToString();
             
            _20.Text = qe.Dequeue().ToString();
             
            _21.Text = qe.Dequeue().ToString();
             
            _22.Text = qe.Dequeue().ToString();
             
            _23.Text = qe.Dequeue().ToString();
             
            _24.Text = qe.Dequeue().ToString();
             
            _25.Text = qe.Dequeue().ToString();
             
            _26.Text = qe.Dequeue().ToString();
             
            _27.Text = qe.Dequeue().ToString();
             
            _28.Text = qe.Dequeue().ToString();
             
            _29.Text = qe.Dequeue().ToString();
             
            _30.Text = qe.Dequeue().ToString();
             
            _31.Text = qe.Dequeue().ToString();
             
            _32.Text = qe.Dequeue().ToString();
           
            _33.Text = qe.Dequeue().ToString();
            _34.Text = qe.Dequeue().ToString();
            _35.Text = qe.Dequeue().ToString();
             
            _36.Text = qe.Dequeue().ToString();
             
            _37.Text = qe.Dequeue().ToString();
             
            _38.Text = qe.Dequeue().ToString();
             
            _39.Text = qe.Dequeue().ToString();
             
            _40.Text = qe.Dequeue().ToString();
                 
            _41.Text = qe.Dequeue().ToString();
             
            _42.Text = qe.Dequeue().ToString();
             
            _43.Text = qe.Dequeue().ToString();
             
            _44.Text = qe.Dequeue().ToString();
             
            _45.Text = qe.Dequeue().ToString();
             
            _46.Text = qe.Dequeue().ToString();
             
            _47.Text = qe.Dequeue().ToString();
             
            _48.Text = qe.Dequeue().ToString();
             
            _49.Text = qe.Dequeue().ToString();
             
            _50.Text = qe.Dequeue().ToString();
        
             

        }
        private void home_Tapped(object sender, TappedRoutedEventArgs e)
        {


            this.Frame.Navigate(typeof(game));

          


        }
       

        private bool checkfun(string txt)
        {
            textnum = myQ.Pop();
            if (txt == textnum.ToString())
            {
                easymediatap.Play();
                score += 10;
                lasthit.Text = txt;
                counthit++;
                if (counthit==50)
                {

                    scorebordfall.Begin();
                    hardgridtext.Text = "Congs!!";
                }
                dispscore.Text = score.ToString();
                return true;
                
            }
            else
            {
                errormedia.Play();
                myQ.Push(textnum);
                score -= 5;
                dispscore.Text = score.ToString();
                return false;
            } 
        }
        private void _1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_1.Text))
            {
                _1.Opacity = 0.5;
            }


        }
        private void _2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_2.Text))
            {
                _2.Opacity = 0.5;
            }   
        }

        private void _3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_3.Text))
            {                
                _3.Opacity = 0.5;
            }   
        }

        private void _4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_4.Text))
            {
                _4.Opacity = 0.5;
            }   
        }

        private void _5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_5.Text))
            {
                _5.Opacity = 0.5;
            }   
        }

        private void _6_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_6.Text))
            {
                _6.Opacity = 0.5;
            }   
        }

        private void _7_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_7.Text))
            {
                _7.Opacity = 0.5;
            }
        }

        private void _8_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_8.Text))
            {
                _8.Opacity = 0.5;
            }   
        }

        private void _9_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_9.Text))
            {
                _9.Opacity = 0.5;
            }   
        }

        private void _10_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_10.Text))
            {
                _10.Opacity = 0.5;
            }   
        }

        private void _11_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_11.Text))
            {
                _11.Opacity = 0.5;
            }   
        }

        private void _12_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_12.Text))
            {
                _12.Opacity = 0.5;
            }   
        }

        private void _13_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_13.Text))
            {
                _13.Opacity = 0.5;
            }   
        }

        private void reload_Tapped(object sender, TappedRoutedEventArgs e)
        {
            
                this.Frame.Navigate(typeof(easy));

        }

        private void reload_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            reload.Opacity = 0.5;
        }

        private void reload_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            reload.Opacity = 1;
        }

        private void home_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            home.Opacity = 0.5;
        }

        private void home_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            home.Opacity = 1;
        }

        private void replay_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(hard),score);
        }

        private void quit_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Exit();
        }

        private void _14_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_14.Text))
            {
                _14.Opacity = 0.5;
            }   
        }

        private void _15_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_15.Text))
            {
                _15.Opacity = 0.5;
            }   
        }

        private void _16_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_16.Text))
            {
                _16.Opacity = 0.5;
            }   
        }

        private void _17_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_17.Text))
            {
                _17.Opacity = 0.5;
            }
        }

        private void _18_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_18.Text))
            {
                _18.Opacity = 0.5;
            }
        }

        private void _19_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_19.Text))
            {
                _19.Opacity = 0.5;
            }
        }

        private void _20_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_20.Text))
            {
                _20.Opacity = 0.5;
            }
        }

        private void _21_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_21.Text))
            {
                _21.Opacity = 0.5;
            }
       }

        private void _22_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_22.Text))
            {
                _22.Opacity = 0.5;
            }   
        }

        private void _23_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_23.Text))
            {
                _23.Opacity = 0.5;
            }   
        }

        private void _24_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_24.Text))
            {
                _24.Opacity = 0.5;
            }   
        }

        private void _25_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_25.Text))
            {
                _25.Opacity = 0.5;
            }   
        }

        private void _26_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_26.Text))
            {
                _26.Opacity = 0.5;
            }   
        }

        private void _27_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_27.Text))
            {
                _27.Opacity = 0.5;
            }   
        }

        private void _28_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_28.Text))
            {
                _28.Opacity = 0.5;
            }   
        }

        private void _29_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_29.Text))
            {
                _29.Opacity = 0.5;
            }   
        }

        private void _30_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_30.Text))
            {
                _30.Opacity = 0.5;
            }   
        }

        private void _31_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_31.Text))
            {
                _31.Opacity = 0.5;
            }   
        }

        private void _32_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_32.Text))
            {
                _32.Opacity = 0.5;
            }   
        }

        private void _33_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_33.Text))
            {
                _33.Opacity = 0.5;
            }   
        }

        private void _34_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_34.Text))
            {
                _34.Opacity = 0.5;
            }   
        }

        private void _35_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_35.Text))
            {
                _35.Opacity = 0.5;
            }   
        }

        private void _36_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_36.Text))
            {
                _36.Opacity = 0.5;
            }   
        }

        private void _37_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_37.Text))
            {
                _37.Opacity = 0.5;
            }   
        }

        private void _38_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_38.Text))
            {
                _38.Opacity = 0.5;
            }   
        }

        private void _39_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_39.Text))
            {
                _39.Opacity = 0.5;
            }   
        }

        private void _40_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_40.Text))
            {
                _40.Opacity = 0.5;
            }   
        }

        private void _41_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_41.Text))
            {
                _41.Opacity = 0.5;
            }   
        }

        private void _42_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_42.Text))
            {
                _42.Opacity = 0.5;
            }   
        }

        private void _43_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_43.Text))
            {
                _43.Opacity = 0.5;
            }   
        }

        private void _44_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_44.Text))
            {
                _44.Opacity = 0.5;
            }   
        }

        private void _45_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_45.Text))
            {
                _45.Opacity = 0.5;
            }   
        }

        private void _46_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_46.Text))
            {
                _46.Opacity = 0.5;
            }   
        }

        private void _47_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_47.Text))
            {
                _47.Opacity = 0.5;
            }   
        }

        private void _48_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_48.Text))
            {
                _48.Opacity = 0.5;
            }   
        }

        private void _49_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_49.Text))
            {
                _49.Opacity = 0.5;
            }   
        }

        private void _50_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkfun(_50.Text))
            {
                _50.Opacity = 0.5;
            }   
        }

        private void quit_Click(object sender, TappedRoutedEventArgs e)
        {
            App.Current.Exit();
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(hardinstructions), (int)score);
        }

       

    }
}
