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
            Steve.Strokes.Clear();
        }

        private void Blue_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Yellow_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Black_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
