using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace PhoneApp1
{
    public partial class dlugosc : PhoneApplicationPage
    {
        public dlugosc()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Convertbutton1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double metrValue = double.Parse(textBox1.Text);
                double centymetrValue = (metrValue*100);
                textBlock3.Text = centymetrValue.ToString();
            }
            catch (Exception)
            {
                if (textBox1.Text == "")
                    MessageBox.Show("Chciałoby się ;)");
                else
                    MessageBox.Show("Proszę wprowadzić LICZBĘ");
            }
        }

        private void Resetbutton2_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            textBlock3.Text = "";
        }
    }
}