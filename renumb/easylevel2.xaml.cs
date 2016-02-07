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

namespace renumb
{
    
    public sealed partial class easylevel2 : Page
    {
        DispatcherTimer scoredt = new DispatcherTimer();
        string l1ins = "This is the first level. Remember the numbers on the grid then roll so that the numbers will be hidden. Test your brain by locating the exact places of the number in order";
        string l2ins = "This is the second level. Remember the numbers on the grid then roll so that the numbers will be hidden. Test your brain by locating the exact places of the number";
        Queue<int> que = new Queue<int>(4);
        Stack<int> que1 = new Stack<int>(4);
        Queue<int> quel2 = new Queue<int>(6);
        Stack<int> que1l2 = new Stack<int>(6);
        Queue<int> quel3 = new Queue<int>(9);
        Stack<int> que1l3 = new Stack<int>(9);
        int count = 0,count2=4,count22=6,count23=9,fincount=0,nextcount=0;
        int n,n1,n2,n3,n4,n5,n6,n7,n8,n9;
        int level = 0;
        int time=130;
        int score1=0;
        int score = 0;
        public easylevel2()
        {
            this.InitializeComponent();
            scoredt.Interval = new TimeSpan(0, 0, 1);
            scoredt.Tick+=scoredt_Tick;
            
        }
        void scoredt_Tick(object sender, object e)
        {
            time--;
            timeleft.Text = time.ToString();
            if (time == 0)
            {
                scoreboardfall.Begin();
            }
            
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
           // score1 = (int)e.Parameter;
            error.Stop();
            que.Clear();
            que1.Clear();           
            fun1();
            fun2();
            fun3();
            instructions.Text = l1ins;
            insgrid.Visibility = Visibility.Visible;
            scoredt.Start();
        }
        private void fun3()
        {
            Random re = new Random();
            count = 0;
            do
            {
                n = re.Next(9) + 1;
                if (!quel3.Contains(n))
                {
                    quel3.Enqueue(n);
                    count++;
                    que1l3.Push(count23);
                    count23--;
                }
            } while (count < 9);
            n9 = quel3.Dequeue();
            t9l3.Tag = t9l3.Text = n9.ToString();
            n1 = quel3.Dequeue();
            t1l3.Tag = t1l3.Text = n1.ToString();
            n2 = quel3.Dequeue();
            t2l3.Tag = t2l3.Text = n2.ToString();
            n3 = quel3.Dequeue();
            t3l3.Tag = t3l3.Text = n3.ToString();
            n4 = quel3.Dequeue();
            t4l3.Tag = t4l3.Text = n4.ToString();
            n5 = quel3.Dequeue();
            t5l3.Tag = t5l3.Text = n5.ToString();
            n6 = quel3.Dequeue();
            t6l3.Tag = t6l3.Text = n6.ToString();
            n7 = quel3.Dequeue();
            t7l3.Tag = t7l3.Text = n7.ToString();
            n8 = quel3.Dequeue();
            t8l3.Tag = t8l3.Text = n8.ToString();            
        }

        private void fun2()
        {
            Random re = new Random();
            count = 0;
            do
            {
                n = re.Next(6) + 1;
                if (!quel2.Contains(n))
                {
                    quel2.Enqueue(n);
                    count++;
                    que1l2.Push(count22);
                    count22--;

                }
            } while (count < 6);

            n1 = quel2.Dequeue();
            t1l2.Tag = t1l2.Text = n1.ToString();

            n2 = quel2.Dequeue();
            t2l2.Tag = t2l2.Text = n2.ToString();

            n3 = quel2.Dequeue();
            t3l2.Tag = t3l2.Text = n3.ToString();

            n4 = quel2.Dequeue();
            t4l2.Tag = t4l2.Text = n4.ToString();

            n5 = quel2.Dequeue();
            t5l2.Tag = t5l2.Text = n5.ToString();

            n6 = quel2.Dequeue();
            t6l2.Tag = t6l2.Text = n6.ToString();
            
        }

        private void fun1()
        {
            Random re = new Random();
            count = 0;
            do
            {
                n = re.Next(4) + 1;
                if (!que.Contains(n))
                {
                    que.Enqueue(n);
                    count++;
                    que1.Push(count2);
                    count2--;

                }
            } while (count < 4);

            n1 = que.Dequeue();
            t1.Tag = t1.Text = n1.ToString();

            n2 = que.Dequeue();
            t2.Tag = t2.Text = n2.ToString();

            n3 = que.Dequeue();
            t3.Tag = t3.Text = n3.ToString();

            n4 = que.Dequeue();
            t4.Tag = t4.Text = n4.ToString();
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            rolldice.Begin();
            t1.Text = "-";
            t2.Text = "-";
            t3.Text = "-";
            t4.Text = "-";
          

        }
         private bool checkit2(string p1)
         {
             int q = que1l2.Pop();

             if (p1 == q.ToString())
             {
                 fincount++;
                 if (fincount == 6 && level == 1)
                 {
                     levelchange.Visibility = Visibility.Visible;
                  
                     
                     fincount = 0;
                     level++;
                 }
                 correctmedia.Play();
                 return true;
             }
             else
             {
                 que1l2.Push(q);
                 return false;
             }
         }
        private bool checkit3(string p1)
         {
                int q = que1l3.Pop();

             if (p1 == q.ToString())
             {
                 fincount++;
                 
                 correctmedia.Play();
                 popoff(fincount);
                 return true;
             }
             else
             {
                 que1l3.Push(q);
                 return false;
             }
    }
        void popoff(int fincount)
        {
            if (fincount == 9 && level == 2)
            {

                scoreboardfall.Begin();

            }
            else return;
        }
        private bool checkit(string p1)
        {
            int q = que1.Pop();

            if (p1 == q.ToString())
            {
                fincount++;
                if (fincount == 4&&level==0)
                {
                    levelchange.Visibility = Visibility.Visible;
                    instructions.Text = l2ins;
                    fincount = 0;
                    level++;
                }
                correctmedia.Play();
                return true;
            }
            else
            {
                que1.Push(q);
                return false;
            }
        }
        private void t4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkit(t4.Tag.ToString()))
            {
                t4.Text = t4.Tag.ToString();

                t4.Opacity = 0.5;
                
            }
            else
            {
                error.Play(); scoredt.Stop();    scoreboardfall.Begin(); easyl2gridtext.Text="Wrong";
            }
        }
        private void t3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkit(t3.Tag.ToString()))
            {
                t3.Text = t3.Tag.ToString();
                t3.Opacity = 0.5;
            }
            else
            {
                error.Play(); scoredt.Stop();    scoreboardfall.Begin(); easyl2gridtext.Text="Wrong";
            }
        }
        private void t2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkit(t2.Tag.ToString()))
            {
                t2.Text = t2.Tag.ToString();
                t2.Opacity = 0.5;
            }
            else
            {
                error.Play(); scoredt.Stop();    scoreboardfall.Begin(); easyl2gridtext.Text="Wrong";
            }
        }
        private void t1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkit(t1.Tag.ToString()))
            {
                t1.Text = t1.Tag.ToString();
                t1.Opacity = 0.5;
            }
            else
            {
                error.Play(); scoredt.Stop();    scoreboardfall.Begin(); easyl2gridtext.Text="Wrong";
            }
        }
        private void t4l2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkit2(t4l2.Tag.ToString()))
            {
                t4l2.Text = t4l2.Tag.ToString();

                t4l2.Opacity = 0.5;
            }
            else
            {
                error.Play(); scoredt.Stop();    scoreboardfall.Begin(); easyl2gridtext.Text="Wrong";
            }
        }
        private void t3l2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkit2(t3l2.Tag.ToString()))
            {
                t3l2.Text = t3l2.Tag.ToString();
                t3l2.Opacity = 0.5;
            }
            else
            {
                error.Play(); scoredt.Stop();    scoreboardfall.Begin(); easyl2gridtext.Text="Wrong";
            }
        }
        private void t2l2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkit2(t2l2.Tag.ToString()))
            {
                t2l2.Text = t2l2.Tag.ToString();
                t2l2.Opacity = 0.5;
            }
            else
            {
                error.Play(); scoredt.Stop();    scoreboardfall.Begin(); easyl2gridtext.Text="Wrong";
            }
        }
        private void t1l2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkit2(t1l2.Tag.ToString()))
            {
                t1l2.Text = t1l2.Tag.ToString();
                t1l2.Opacity = 0.5;
            }
            else
            {
                error.Play(); scoredt.Stop();    scoreboardfall.Begin(); easyl2gridtext.Text="Wrong";
            }
        }
        private void t5l2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkit2(t5l2.Tag.ToString()))
            {
                t5l2.Text = t5l2.Tag.ToString();
                t5l2.Opacity = 0.5;
            }
            else
            {
                error.Play(); scoredt.Stop();    scoreboardfall.Begin(); easyl2gridtext.Text="Wrong";
            }
        }
        private void t6l2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkit2(t6l2.Tag.ToString()))
            {
                t6l2.Text = t6l2.Tag.ToString();
                t6l2.Opacity = 0.5;
            }
            else
            {
                error.Play(); scoredt.Stop();    scoreboardfall.Begin(); easyl2gridtext.Text="Wrong";
            }
        }
        private void t4l3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkit3(t4l3.Tag.ToString()))
            {
                t4l3.Text = t4l3.Tag.ToString();
                nextcount++;
                t4l3.Opacity = 0.5;
            }
            else
            {
                error.Play(); scoredt.Stop();    scoreboardfall.Begin(); easyl2gridtext.Text="Wrong";
            }
        }
        private void t3l3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkit3(t3l3.Tag.ToString()))
            {
                nextcount++;
                t3l3.Text = t3l3.Tag.ToString();
                t3l3.Opacity = 0.5;
            }
            else
            {
                error.Play(); scoredt.Stop();    scoreboardfall.Begin(); easyl2gridtext.Text="Wrong";
            }
        }
        private void t2l3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkit3(t2l3.Tag.ToString()))
            {
                nextcount++;
                t2l3.Text = t2l3.Tag.ToString();
                t2l3.Opacity = 0.5;
            }
            else
            {
                error.Play(); scoredt.Stop();    scoreboardfall.Begin(); easyl2gridtext.Text="Wrong";
            }
        }
        private void t1l3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkit3(t1l3.Tag.ToString()))
            {
                nextcount++;
                t1l3.Text = t1l3.Tag.ToString();
                t1l3.Opacity = 0.5;
            }
            else
            {
                error.Play(); scoredt.Stop();    scoreboardfall.Begin(); easyl2gridtext.Text="Wrong";
            }
        }
        private void t5l3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkit3(t5l3.Tag.ToString()))
            {
                nextcount++;
                t5l3.Text = t5l3.Tag.ToString();
                t5l3.Opacity = 0.5;
            }
            else
            {
                error.Play(); scoredt.Stop();    scoreboardfall.Begin(); easyl2gridtext.Text="Wrong";
            }
        }
        private void t6l3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkit3(t6l3.Tag.ToString()))
            {
                nextcount++;
                t6l3.Text = t6l3.Tag.ToString();
                t6l3.Opacity = 0.5;
            }
            else
            {
                error.Play(); scoredt.Stop();    scoreboardfall.Begin(); easyl2gridtext.Text="Wrong";
            }
        }
        private void t7l3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkit3(t7l3.Tag.ToString()))
            {
                nextcount++;
                t7l3.Text = t7l3.Tag.ToString();
                t7l3.Opacity = 0.5;
            }
            else
            {
                error.Play(); scoredt.Stop();    scoreboardfall.Begin(); easyl2gridtext.Text="Wrong";
            }
        }
        private void t8l3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkit3(t8l3.Tag.ToString()))
            {
                nextcount++;
                t8l3.Text = t8l3.Tag.ToString();
                t8l3.Opacity = 0.5;
            }
            else
            {
                error.Play(); scoredt.Stop();    scoreboardfall.Begin(); easyl2gridtext.Text="Wrong";
            }
        }
        private void t9l3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (checkit3(t9l3.Tag.ToString()))
            {
                nextcount++;
                t9l3.Text = t9l3.Tag.ToString();
                t9l3.Opacity = 0.5;
            }
            else
            {
                error.Play(); scoredt.Stop();    scoreboardfall.Begin(); easyl2gridtext.Text="Wrong";
            }
        }
        private void Image_Tapped_2(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(game));
        }
        private void Image_Tapped_3(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(easylevel2),score1);
        }     
        private void easyl2replay_Click(object sender, RoutedEventArgs e)
        {
           this.Frame.Navigate(typeof(easylevel2),score1);
        }
               
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            rolldice2.Begin();
            t1l2.Text = "-";
            t2l2.Text = "-";
            t3l2.Text = "-";
            t4l2.Text = "-";
            t5l2.Text = "-";
            t6l2.Text = "-";
            //hide.Visibility = Visibility.Collapsed;
            
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            rolldice3.Begin();
            t1l3.Text = "-";
            t2l3.Text = "-";
            t3l3.Text = "-";
            t4l3.Text = "-";
            t5l3.Text = "-";
            t6l3.Text = "-";
            t7l3.Text = "-";
            t8l3.Text = "-";
            t9l3.Text = "-";
          
        }

        private void levelchange_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (level == 1)
            {
                levelchange.Visibility = Visibility.Collapsed;
                fincount = 0;
                level1start.Begin();
                score = 100;
                //hide.Visibility = Visibility.Visible;
                insgrid.Visibility = Visibility.Visible;
            }
            else if(level==2)
            {
                levelchange.Visibility = Visibility.Collapsed;
                fincount = 0;
                level2start.Begin();
                score += 200;
                //hide.Visibility = Visibility.Visible;
                
            }
        }

        private void gotit_Click(object sender, RoutedEventArgs e)
        {
            insgrid.Visibility = Visibility.Collapsed;
        }

        private void nextbtn_Click(object sender, RoutedEventArgs e)
        {
            score1 += score;
            this.Frame.Navigate(typeof(level2),(int) score1);
        }
    }
}

