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
    }
}
