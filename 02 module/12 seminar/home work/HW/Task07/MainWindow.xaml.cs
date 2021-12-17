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

namespace Task07
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            polyline.Points = new PointCollection();
            polyline.Points.Clear();
        }

        private void clickHandler(object sender, RoutedEventArgs e)
        {
            polyline.Points.Clear();
        }

        private void sliderH_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            polyline.Points.Add(new Point(sliderH.Value, 260 - sliderV.Value));
        }

        private void sliderV_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            sliderH_ValueChanged(sender, e);
        }
    }
}
