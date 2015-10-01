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
    public partial class powierzchnia : PhoneApplicationPage
    {
        public powierzchnia()
        {
            InitializeComponent();
        }

        private void Convertbutton1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double cm2Value = double.Parse(textBox1.Text);
                double cal2Value = (cm2Value * 0.16);
                textBlock3.Text = cal2Value.ToString();
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