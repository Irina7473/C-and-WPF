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

        string InputString = "";

        private void Button_0_Click(object sender, RoutedEventArgs e)
        {
            TextBox_Input.Text += (string)Button_0.Content;
        }

        private void Button_1_Click(object sender, RoutedEventArgs e)
        {
            TextBox_Input.Text += (string)Button_1.Content;
        }

        private void Button_2_Click(object sender, RoutedEventArgs e)
        {
            TextBox_Input.Text += (string)Button_2.Content;
        }

        private void Button_3_Click(object sender, RoutedEventArgs e)
        {
            TextBox_Input.Text += (string)Button_3.Content;
        }

        private void Button_4_Click(object sender, RoutedEventArgs e)
        {
            TextBox_Input.Text += (string)Button_4.Content;
        }

        private void Button_5_Click(object sender, RoutedEventArgs e)
        {
            TextBox_Input.Text += (string)Button_5.Content;
        }

        private void Button_6_Click(object sender, RoutedEventArgs e)
        {
            TextBox_Input.Text += (string)Button_6.Content;
        }

        private void Button_7_Click(object sender, RoutedEventArgs e)
        {
            TextBox_Input.Text += (string)Button_7.Content;
        }

        private void Button_8_Click(object sender, RoutedEventArgs e)
        {
            TextBox_Input.Text += (string)Button_8.Content;
        }

        private void Button_9_Click(object sender, RoutedEventArgs e)
        {
            TextBox_Input.Text += (string)Button_9.Content;
        }

        private void Button_Clear_Click(object sender, RoutedEventArgs e)
        {
            TextBox_Input.Text = "";
        }

        private void Button_Delete_Click(object sender, RoutedEventArgs e)
        {
            TextBox_Input.Text=TextBox_Input.Text.Remove(TextBox_Input.Text.Length-1);
        }

        private void Button_Plus_Click(object sender, RoutedEventArgs e)
        {
            TextBox_Input.Text += (string)Button_Plus.Content;
        }

        private void Button_Minus_Click(object sender, RoutedEventArgs e)
        {
            TextBox_Input.Text += (string)Button_Minus.Content;
        }

        private void Button_Multiplication_Click(object sender, RoutedEventArgs e)
        {
            TextBox_Input.Text += (string)Button_Multiplication.Content;
        }

        private void Button_Division_Click(object sender, RoutedEventArgs e)
        {
            TextBox_Input.Text += (string)Button_Division.Content;
        }

        private void Button_Result_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
