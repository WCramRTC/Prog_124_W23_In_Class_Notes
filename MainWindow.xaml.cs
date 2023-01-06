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

namespace Lecture_2
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

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            string firstValue = tbASValue1.Text;
            string secondValue = tbASValue2.Text;
            lbAS.Content = "+";

            // Try parse parses a value
            // Returns true or false
            // If true, assigns the value to our double variable
            // If false, doesn't crash
            double value1 = 0;
            bool val1IsANumber = double.TryParse(firstValue, out value1);

            double value2 = 0;
            bool val2IsANumber = double.TryParse(secondValue, out value2);

            // lbas
            // Content
            
            // If either number is invalid - this code runs
            if(!(val1IsANumber && val2IsANumber))
            {
                MessageBox.Show("Please enter valid numbers");
                return;
            }

            double sum = value1 + value2;
            tbASResult.Text = sum.ToString();

            
            //if(val1IsANumber && val2IsANumber)
            //{
            //    double sum = value1 + value2;
            //    tbASResult.Text = sum.ToString();
                
            //}
            //else
            //{
            //    MessageBox.Show("Please enter valid numbers");

            //}

        }

        private void btSubtract_Click(object sender, RoutedEventArgs e)
        {
            string firstValue = tbASValue1.Text;
            string secondValue = tbASValue2.Text;
            lbAS.Content = "-";

            // Try parse parses a value
            // Returns true or false
            // If true, assigns the value to our double variable
            // If false, doesn't crash
            double value1 = 0;
            bool val1IsANumber = double.TryParse(firstValue, out value1);

            double value2 = 0;
            bool val2IsANumber = double.TryParse(secondValue, out value2);

            // lbas
            // Content

            // If either number is invalid - this code runs
            if (!(val1IsANumber && val2IsANumber))
            {
                MessageBox.Show("Please enter valid numbers");
                return;
            }

            double sum = value1 - value2;
            tbASResult.Text = sum.ToString();
        }
    }
}
