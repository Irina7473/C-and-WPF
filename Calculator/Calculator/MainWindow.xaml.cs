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

        string InputNumber1 = " ";
        string InputNumber2 = " ";
        int number1, number2, result;
        int operation;
        
        enum Operation {plus, minus, multiplication, division};

        private void Button_0_Click(object sender, RoutedEventArgs e)
        {
            TextBox_Input.Text += (string)Button_0.Content;
            if (InputNumber1 != "") InputNumber1 += (string)Button_0.Content;
            else InputNumber2 += (string)Button_0.Content;
            //TextBlock_Result.Text = InputNumber1;
            //TextBlock_Result.Text = InputNumber2;
        }

        private void Button_1_Click(object sender, RoutedEventArgs e)
        {
            TextBox_Input.Text += (string)Button_1.Content;
            if (InputNumber1 != "") InputNumber1 += (string)Button_1.Content;
            else InputNumber2 += (string)Button_1.Content;
            //TextBlock_Result.Text = InputNumber1;
            //TextBlock_Result.Text = InputNumber2;
        }

        private void Button_2_Click(object sender, RoutedEventArgs e)
        {
            TextBox_Input.Text += (string)Button_2.Content;
            if (InputNumber1 !="") InputNumber1 += (string)Button_2.Content;
            else InputNumber2 += (string)Button_2.Content;
            //TextBlock_Result.Text = InputNumber1;
            //TextBlock_Result.Text = InputNumber2;
        }

        private void Button_3_Click(object sender, RoutedEventArgs e)
        {
            TextBox_Input.Text += (string)Button_3.Content;
            if (InputNumber1 != "") InputNumber1 += (string)Button_3.Content;
            else InputNumber2 += (string)Button_3.Content;
        }

        private void Button_4_Click(object sender, RoutedEventArgs e)
        {
            TextBox_Input.Text += (string)Button_4.Content;
            if (InputNumber1 != "") InputNumber1 += (string)Button_4.Content;
            else InputNumber2 += (string)Button_4.Content;
        }

        private void Button_5_Click(object sender, RoutedEventArgs e)
        {
            TextBox_Input.Text += (string)Button_5.Content;
            if (InputNumber1 != "") InputNumber1 += (string)Button_5.Content;
            else InputNumber2 += (string)Button_5.Content;
        }

        private void Button_6_Click(object sender, RoutedEventArgs e)
        {
            TextBox_Input.Text += (string)Button_6.Content;
            if (InputNumber1 != "") InputNumber1 += (string)Button_6.Content;
            else InputNumber2 += (string)Button_6.Content;
        }

        private void Button_7_Click(object sender, RoutedEventArgs e)
        {
            TextBox_Input.Text += (string)Button_7.Content;
            if (InputNumber1 != "") InputNumber1 += (string)Button_7.Content;
            else InputNumber2 += (string)Button_7.Content;
        }

        private void Button_8_Click(object sender, RoutedEventArgs e)
        {
            TextBox_Input.Text += (string)Button_8.Content;
            if (InputNumber1 != "") InputNumber1 += (string)Button_8.Content;
            else InputNumber2 += (string)Button_8.Content;
        }

        private void Button_9_Click(object sender, RoutedEventArgs e)
        {
            TextBox_Input.Text += (string)Button_9.Content;
            if (InputNumber1 != "") InputNumber1 += (string)Button_9.Content;
            else InputNumber2 += (string)Button_9.Content;
        }

        private void Button_Clear_Click(object sender, RoutedEventArgs e)
        {
            TextBox_Input.Text = "";
            TextBlock_Result.Text = "";
        }

        private void Button_Delete_Click(object sender, RoutedEventArgs e)
        {
            TextBox_Input.Text=TextBox_Input.Text.Remove(TextBox_Input.Text.Length-1);
        }

        private void Button_Plus_Click(object sender, RoutedEventArgs e)
        {
            TextBox_Input.Text += (string)Button_Plus.Content;
            number1 = Int32.Parse(InputNumber1);
            InputNumber1 = "";
            operation = 1;
            
        }

        private void Button_Minus_Click(object sender, RoutedEventArgs e)
        {
            TextBox_Input.Text += (string)Button_Minus.Content;
            number1 = Int32.Parse(InputNumber1);
            InputNumber1 = "";
            operation = 2;
        }

        private void Button_Multiplication_Click(object sender, RoutedEventArgs e)
        {
            TextBox_Input.Text += (string)Button_Multiplication.Content;
            number1 = Int32.Parse(InputNumber1);
            InputNumber1 = "";
            operation = 3;
        }

        private void Button_Division_Click(object sender, RoutedEventArgs e)
        {
            TextBox_Input.Text += (string)Button_Division.Content;
            number1 = Int32.Parse(InputNumber1);
            InputNumber1 = "";
            operation = 4;
        }

        private void Button_Result_Click(object sender, RoutedEventArgs e)
        {
            
            number2 = Int32.Parse(InputNumber2);
            InputNumber2 = "";
            switch (operation)
            {
                case 1: 
                    result=number1 + number2;
                    break;
                case 2:
                    result = number1 - number2;
                    break;
                case 3:
                    result = number1 * number2;
                    break;
                case 4:
                    result = number1 / number2;
                    break;
                case 0:
                    result = 0;
                    break;
            }
            TextBlock_Result.Text = result.ToString();
            operation = 0;
            InputNumber1 = "0";


        }

    }
}
