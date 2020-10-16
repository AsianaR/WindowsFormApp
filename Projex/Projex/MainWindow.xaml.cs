using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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

namespace Projex
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MediaPlayer mplayer = new MediaPlayer();
        private Point? _movePoint1;
        private Point? _movePoint2;
        private Point? _movePoint3;
        string[,] PictureContent =   {{ "1.wmf", "2.wmf", "3.wmf" },
                        { "4.wmf", "5.wmf", "6.wmf" },
                        { "7.wmf", "8.wmf", "9.wmf" },
                        { "10.wmf", "11.wmf", "12.wmf" } };
        string[,] FieldContent = {{ "Car", "Sunrise", "Apple" },
                        { "Wolf", "DarkSouls", "Tiger" },
                         { "Impostor","Basketball","Time" },
                        { "Forest", "Village", "Office" }};
        int check1, check2, check3;
        public int score = 0, i=0;
        int k=4;
        int[,] check = {
          {1,2,3},
          {1,2,3},
          {1,2,3},
          {1,2,3}
        };
                       
        public MainWindow()
        {
            InitializeComponent();
            TimerInit();
            SetCanvasPosition();

        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            Results();
        }

        private void Results()
        {
            check1 = 0;
            check2 = 0;
            check3 = 0;
            checkAnswear();
            if (check1 == 0 || check2 == 0 || check3 == 0)
            {
                MessageBox.Show("Field is empty");
            }
            else
            {
                Scoring();
                Update();
            }
        }

        private void SetCanvasPosition()
        {
            mplayer.Open(new Uri("pack://C:,,,Users/Home/source/repos/Projex/Resources/Applause.wav"));
            mplayer.Play();
            Canvas.SetLeft(FirstField, -285);
            Canvas.SetTop(FirstField, -337);
            Canvas.SetLeft(SecondField, -40);
            Canvas.SetTop(SecondField, -337);
            Canvas.SetLeft(ThirdField, 217);
            Canvas.SetTop(ThirdField, -337);

        }

        private void FirstPicture_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            _movePoint1 = e.GetPosition(FirstPicture);
            FirstPicture.CaptureMouse();
        }

        private void FirstPicture_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (_movePoint1 == null)
                return;
            var p = e.GetPosition(this) - (Vector)_movePoint1.Value;
            Canvas.SetLeft(FirstPicture, p.X);
            Canvas.SetTop(FirstPicture, p.Y);
        }

        private void FirstPicture_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            _movePoint1 = null;
            FirstPicture.ReleaseMouseCapture();
        }

        private void SecondPicture_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            _movePoint2 = e.GetPosition(SecondPicture);
            SecondPicture.CaptureMouse();
        }

        private void SecondPicture_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (_movePoint2 == null)
                return;
            var p = e.GetPosition(this) - (Vector)_movePoint2.Value; ;
            Canvas.SetLeft(SecondPicture, p.X);
            Canvas.SetTop(SecondPicture, p.Y);
        }

        private void SecondPicture_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            _movePoint2 = null;
            SecondPicture.ReleaseMouseCapture();
        }

        private void ThirdPicture_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            _movePoint3 = e.GetPosition(ThirdPicture);
            ThirdPicture.CaptureMouse();
        }

        private void ThirdPicture_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (_movePoint3 == null)
                return;
            var p = e.GetPosition(this);
            Canvas.SetLeft(ThirdPicture, p.X - _movePoint3.Value.X);
            Canvas.SetTop(ThirdPicture, p.Y - _movePoint3.Value.Y);
        }

        private void ThirdPicture_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            _movePoint3 = null;
            ThirdPicture.ReleaseMouseCapture();
        }

        private void checkAnswear()
        {
            if (isPictureInside(FirstPicture, FirstField))
                check1 = 1;
            if (isPictureInside(FirstPicture, SecondField))
                check1 = 2;
            if (isPictureInside(FirstPicture, ThirdField))
                check1 = 3;

            if (isPictureInside(SecondPicture, FirstField))
                check2 = 1;
            if (isPictureInside(SecondPicture, SecondField))
                check2 = 2;
            if (isPictureInside(SecondPicture, ThirdField))
                check2 = 3;

            if (isPictureInside(ThirdPicture, FirstField))
                check3 = 1;
            if (isPictureInside(ThirdPicture, SecondField))
                check3 = 2;
            if (isPictureInside(ThirdPicture, ThirdField))
                check3 = 3;
        }

        static bool isPictureInside(Ellipse image, Canvas field)
        {
            if (Canvas.GetLeft(image) >= Canvas.GetLeft(field) && Canvas.GetLeft(image) + image.Width <= Canvas.GetLeft(field) + field.Width && Canvas.GetTop(image) >= Canvas.GetTop(field) && Canvas.GetTop(image) + image.Height <= Canvas.GetTop(field) + field.Height)
            {
                return true;
            }
            else return false;
        }

        public void Update()
        {
            string path = "C:/Users/Home/source/repos/Projex/Resources/";

            

            FieldName1.Content = FieldContent[i, 0];
            FieldName2.Content = FieldContent[i, 1];
            FieldName3.Content = FieldContent[i, 2];
            

        }
        public void Scoring()
        {
          
                if (check[i, 0] == check1 && check[i, 1] == check2 && check[i, 2] == check3)
                {
                    score = score + 3;
                    mplayer.Play();
                }
            
            FinalScoring();
        
        }

        public void FinalScoring()
        {
           /* if (i < 3)
              i++;
            else
            {*/
                score = (score*100)/k;
                MessageBox.Show("Your score is - " + (score) + " " + "points");

                Close();
            //}
        }

        System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        private void TimerInit()
        {
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 1);
            dispatcherTimer.Start();
            
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            TimeProgressBar.Value += 1;
            if (TimeProgressBar.Value == TimeProgressBar.Maximum)
                Results();
        }


    }
}
