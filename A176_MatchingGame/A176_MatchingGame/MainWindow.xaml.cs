using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace A176_MatchingGame
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        Button first;
        Button second;
        DispatcherTimer myTimer = new DispatcherTimer();
        int matched = 0;
        int[] rnd = new int[16];
        public MainWindow()
        {
            InitializeComponent();
            BoardSet();
            myTimer.Interval = new TimeSpan(0, 0, 0, 0, 750); //750sec.
            myTimer.Tick += MyTimer_Tick;
        }

        private void BoardSet() //Reset 16 Buttons
        {
            for (int i = 0; i < 16; i++)
            {
                Button c = new Button();
                c.Background = Brushes.White;
                c.Margin = new Thickness(10);
                c.Content = MakeImage("../../Images/check.png");
                c.Tag = TagSet(); //Setting picture index
                c.Click += C_Click;
                board.Children.Add(c);
            }
        }

        private Image MakeImage(string v) //v is path of image file
        {
            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri(v, UriKind.Relative);
            bi.EndInit();
            Image myImage = new Image();
            myImage.Margin = new Thickness(10);
            myImage.Stretch = Stretch.Fill;
            myImage.Source = bi;
            return myImage;
        }

        private int TagSet() //create i = 0~15, return i%8
        {
            int i;
            Random r = new Random();
            while (true)
            {
                i = r.Next(16); //0~15
                if (rnd[i] == 0)
                {
                    rnd[i] = 1;
                    break;
                }
            }
            return i % 8; //tag 0~7, show 8 pics.
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;

            string[] icon = { "ichigo", "lemon", "mogwa", "pear", "apple", "watermellon", "pineapple", "grape" };
            btn.Content = MakeImage("../../Images/" + icon[(int)btn.Tag] + ".png");

            if (first == null)
            {
                first = btn;
                return;
            }
            second = btn;

            if ((int)first.Tag == (int)second.Tag)
            {
                first = null;
                second = null;
                matched += 2;
                if (matched >= 16)
                {
                    MessageBoxResult res = MessageBox.Show("成功！もう一回プレイしますか？", "Success", MessageBoxButton.YesNo);
                    if (res == MessageBoxResult.Yes)
                        NewGame();
                    else
                        Close();
                }
            }
            else
            {
                myTimer.Start();
            }
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            myTimer.Stop();
            first.Content = MakeImage("../../Images/check.png");
            second.Content = MakeImage("../../Images/check.png");
            first = null;
            second = null;
        }

        private void NewGame()
        {
            for (int i = 0; i < 16; i++)
                rnd[i] = 0;
            board.Children.Clear();
            BoardSet();
            matched = 0;
        }
    }
}

