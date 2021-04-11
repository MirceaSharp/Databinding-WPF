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

namespace Databinding_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cmbFill.Items.Add("Red");
            cmbFill.Items.Add("Blue");
            cmbFill.Items.Add("Green");
            cmbFill.Items.Add("Peru");
           
            cmbColor.Items.Add("Blue");
            cmbColor.Items.Add("Yellow");
            cmbColor.Items.Add("Purple");
            cmbColor.Items.Add("MediumAquamarine");
            


        }

        private void SliderFrame_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
           
            Ellipse.StrokeThickness = SliderFrame.Value;
        }
    }
}
