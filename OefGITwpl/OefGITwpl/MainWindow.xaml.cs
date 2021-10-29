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

namespace OefGITwpl
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

        private void Img1(object sender, MouseEventArgs e)
        {
            this.Background = Brushes.Red;
        }

        private void Img2(object sender, MouseEventArgs e)
        {
            this.Background = Brushes.Purple;
        }

        private void Img3(object sender, MouseEventArgs e)
        {
            this.Background = Brushes.Orange;
        }

        private void Img4(object sender, MouseEventArgs e)
        {
            this.Background = Brushes.Yellow;
        }
    }
}
