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

namespace Calculator
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
        

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            int sum = 0;
            sum = Convert.ToInt32(v1.Text) + Convert.ToInt32(v2.Text);
            Answer.Text = sum.ToString();
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            
                int minus = 0;
                minus = Convert.ToInt32(v3.Text) - Convert.ToInt32(v4.Text);
                Answer2.Text = minus.ToString();
            

            
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            int multi = 0;
            multi = Convert.ToInt32(v5.Text) * Convert.ToInt32(v6.Text);
            Answer3.Text = multi.ToString();

        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int divison = 0;
                divison = Convert.ToInt32(v7.Text) / Convert.ToInt32(v8.Text);
                Answer4.Text = divison.ToString();
            }
            catch(Exception ex)
            {
                Answer4.Text = "can not divide by 0";
                //MessageBox.Show("can not divide by ZERO");
            }

        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            string concat = null;
            concat = v9.Text + v10.Text;
            Answer5.Text = concat.ToString();

        }
    }
}
