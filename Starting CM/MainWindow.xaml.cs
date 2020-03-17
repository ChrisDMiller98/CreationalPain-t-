using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Starting_CM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Steve.Strokes.Clear();
        }

        private void Red_Click(object sender, RoutedEventArgs e)
        {
            Steve.DefaultDrawingAttributes.Color = Colors.Red;
        }

        private void Blue_Click(object sender, RoutedEventArgs e)
        {
            Steve.DefaultDrawingAttributes.Color = Colors.Blue;
        }

        private void Yellow_Click(object sender, RoutedEventArgs e)
        {
            Steve.DefaultDrawingAttributes.Color = Colors.Yellow;
        }

        private void Black_Click(object sender, RoutedEventArgs e)
        {
            Steve.DefaultDrawingAttributes.Color = Colors.Black;
        }

        private void Small_Click(object sender, RoutedEventArgs e)
        {
            Steve.DefaultDrawingAttributes.Width = 2;
            Steve.DefaultDrawingAttributes.Height = 2;
        }

        private void Medium_Click(object sender, RoutedEventArgs e)
        {
            Steve.DefaultDrawingAttributes.Width = 5;
            Steve.DefaultDrawingAttributes.Height = 5;
        }

        private void Large_Click(object sender, RoutedEventArgs e)
        {
            Steve.DefaultDrawingAttributes.Width = 10;
            Steve.DefaultDrawingAttributes.Height = 10;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SizeUp_Click(object sender, RoutedEventArgs e)
        {
            Steve.DefaultDrawingAttributes.Width++;
            Steve.DefaultDrawingAttributes.Height++;
        }

        private void SizeDown_Click(object sender, RoutedEventArgs e)
        {
            Steve.DefaultDrawingAttributes.Width--;
            Steve.DefaultDrawingAttributes.Height--;
        }

        private void Fill_Click(object sender, RoutedEventArgs e)
        {
            Steve.DefaultDrawingAttributes.Width = 1000;
            Steve.DefaultDrawingAttributes.Height = 1000;
        }

        private void White_Click(object sender, RoutedEventArgs e)
        {
            Steve.DefaultDrawingAttributes.Color = Colors.White;
        }

        private void Gray_Click(object sender, RoutedEventArgs e)
        {
            Steve.DefaultDrawingAttributes.Color = Colors.Gray;
        }

        private void Green_Click(object sender, RoutedEventArgs e)
        {
            Steve.DefaultDrawingAttributes.Color = Colors.Green;
        }

        private void Orange_Click(object sender, RoutedEventArgs e)
        {
            Steve.DefaultDrawingAttributes.Color = Colors.Orange;
        }

        private void Purple_Click(object sender, RoutedEventArgs e)
        {
            Steve.DefaultDrawingAttributes.Color = Colors.Purple;
        }

        private void Pink_Click(object sender, RoutedEventArgs e)
        {
            Steve.DefaultDrawingAttributes.Color = Colors.Pink;
        }

        private void Brown_Click(object sender, RoutedEventArgs e)
        {
            Steve.DefaultDrawingAttributes.Color = Colors.Brown;
        }
    }
}
