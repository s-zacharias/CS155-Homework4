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
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Part1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int weight, height, BMI;

            // collect weight and height from user
            weight = Int32.Parse(Weight.Text);
            height = Int32.Parse(Height.Text);

            // calculate BMI
            BMI = (weight * 720) / (height * height);

            // display message with BMI

            if (BMI < 15)
            {
                bmiDisplay.Background = Brushes.Blue;
                MessageBox.Show("Your BMI is " + BMI);
            } else if (BMI >= 15 && BMI <= 25)
            {
                bmiDisplay.Background = Brushes.Green;
                MessageBox.Show("Your BMI is " + BMI);
            } else
            {
                bmiDisplay.Background = Brushes.Yellow;
                MessageBox.Show("Your BMI is " + BMI);
            }
            


        }
    }
}
