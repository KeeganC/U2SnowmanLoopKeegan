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

namespace U2SnowmanLoopKeegan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SolidColorBrush whiteBrush = new SolidColorBrush();
            SolidColorBrush blackBrush = new SolidColorBrush();
            whiteBrush.Color = Color.FromArgb(140, 255, 255, 255);
            blackBrush.Color = Color.FromArgb(255, 0, 0, 0);

            Rectangle hatTop = new Rectangle();
            hatTop.Height = 120;
            hatTop.Width = 100;
            hatTop.Fill = blackBrush;
            hatTop.Stroke = Brushes.MediumPurple;
            hatTop.StrokeThickness = 5;
            Canvas.SetLeft(hatTop, 300);
            Canvas.Children.Add(hatTop);

            Rectangle hatBrim = new Rectangle();
            hatBrim.Height = 30;
            hatBrim.Width = 200;
            hatBrim.Fill = blackBrush;
            hatBrim.Stroke = Brushes.MediumPurple;
            hatBrim.StrokeThickness = 5;
            Canvas.SetLeft(hatBrim, 250);
            Canvas.SetTop(hatBrim, 120);
            Canvas.Children.Add(hatBrim);
        }

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush whiteBrush = new SolidColorBrush();
            SolidColorBrush blackBrush = new SolidColorBrush();
            whiteBrush.Color = Color.FromArgb(140, 255, 255, 255);
            blackBrush.Color = Color.FromArgb(255, 0, 0, 0);

            string requestedNumberOfBalls = txbHowManyBalls.Text;
            int reqNumBalls = new int();
            int.TryParse(requestedNumberOfBalls, out reqNumBalls);
            int numBalls = 0;
            int counter = 0;

            int ballTop = 150;

            if (reqNumBalls >= 6)
            {
                MessageBox.Show("Too many balls");
            }
            else
            {
                while (numBalls != reqNumBalls)
                {
                    counter++;
                    numBalls++;

                    int ballHeight = 100;
                    int ballWidth = 100;

                    Ellipse ball1 = new Ellipse();
                    ball1.Height = ballHeight * counter;
                    ball1.Width = ballWidth * counter;
                    ball1.Fill = whiteBrush;
                    ball1.Stroke = Brushes.MediumPurple;
                    ball1.StrokeThickness = 5;

                    Canvas.SetLeft(ball1, 300 - 50 * (counter - 1));
                    Canvas.SetTop(ball1, ballTop);
                    Canvas.Children.Add(ball1);

                    ballTop = ballTop + (int)ball1.Height;

                    MessageBox.Show(counter.ToString());
                }
            }
        }
    }
}
