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
    public partial class predkosc : PhoneApplicationPage
    {
        public predkosc()
        {
            InitializeComponent();
        }

        private void Convertbutton1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double kmhValue = double.Parse(textBox1.Text);
                double mphValue = (kmhValue * 0.62);
                textBlock3.Text = mphValue.ToString();
            }
            catch (Exception)
            {
                if (textBox1.Text == "")
                    MessageBox.Show("Chciałoby się ;)");
                else
                    MessageBox.Show("Proszę wprowadzić LICZBĘ");
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            textBlock3.Text = "";
        }
    }
}