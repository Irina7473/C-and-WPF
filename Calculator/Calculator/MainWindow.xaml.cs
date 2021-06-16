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

        string InputNumber1 = "";
        string InputNumber2 = "";
        double resultNumber = 0;        
        int operation=0;
                
        private void Button_Digit_Click(object sender, RoutedEventArgs e)
        {
            string digit = "";
            var symbol = (Button)sender;
            foreach (char d in symbol.Name)
                    if (char.IsDigit(d)) digit = Convert.ToString(d);
                       
            TextBox_Input.Text += digit;
            if (operation == 0)
            {
                TextBlock_Result.Text = "";
                InputNumber1 += digit;
            }
            else InputNumber2 += digit;
        }
                
        private void Button_Comma_Click(object sender, RoutedEventArgs e)
        {
            TextBox_Input.Text += (string)Button_Comma.Content;
            if (InputNumber1 != "") InputNumber1 += (string)Button_Comma.Content;
            else InputNumber2 += (string)Button_Comma.Content;
        }

        private void Button_Clear_Click(object sender, RoutedEventArgs e)
        {
            TextBox_Input.Text = "";
            TextBlock_Result.Text = "";
            InputNumber1 = "";
            InputNumber2 = "";
            resultNumber = 0;
            operation = 0;
        }

        //Работает неправильно, стирает только на экране
        private void Button_Delete_Click(object sender, RoutedEventArgs e)
        {
            TextBox_Input.Text=TextBox_Input.Text.Remove(TextBox_Input.Text.Length-1);
            if (InputNumber1 != "") InputNumber1 = InputNumber1.Remove(InputNumber1.Length - 1);
            else if (InputNumber2 != "") InputNumber2 = InputNumber2.Remove(InputNumber2.Length - 1);
                 else
                 {
                InputNumber1 = resultNumber.ToString();                
                resultNumber = 0;
                 }            
        }

        private void Button_Plus_Click(object sender, RoutedEventArgs e)
        {
            var symbol= (string)Button_Plus.Content;
            arithmeticOperations(symbol, operation);            
            operation = 1;
        }

        private void Button_Minus_Click(object sender, RoutedEventArgs e)
        {
            var symbol = (string)Button_Minus.Content;
            if (InputNumber1 == "") TextBox_Input.Text += symbol;
            arithmeticOperations(symbol, operation);            
            operation = 2;
        }

        private void Button_Multiplication_Click(object sender, RoutedEventArgs e)
        {
            var symbol = (string)Button_Multiplication.Content;
            arithmeticOperations(symbol, operation);
            operation = 3;
        }

        private void Button_Division_Click(object sender, RoutedEventArgs e)
        {
            var symbol = (string)Button_Division.Content;
            arithmeticOperations(symbol, operation);
            operation = 4;
        }

        private void arithmeticOperations (string symbol, int operatoin)
        {
            if (InputNumber1 != "")
            {
                TextBox_Input.Text += symbol;
                resultNumber = Double.Parse(InputNumber1);
                InputNumber1 = "";                
            }
            else if (InputNumber2 != "")
            {
                TextBox_Input.Text += symbol;
                resultNumber = tempResult(resultNumber, InputNumber2, operation);
                InputNumber2 = "";                
            }
        }

        private double tempResult(double resultNumber, string InputNumber2, int operation)
        {
            switch (operation)
            {
                case 1:
                    resultNumber += Double.Parse(InputNumber2);
                    break;
                case 2:
                    resultNumber -= Double.Parse(InputNumber2);
                    break;
                case 3:
                    resultNumber *= Double.Parse(InputNumber2);
                    break;
                case 4:
                    if (Double.Parse(InputNumber2) != 0) resultNumber /= Double.Parse(InputNumber2);
                    else TextBlock_Result.Text = "ошибка";
                    break;
                case 0:
                    break;
            }            
            
            TextBlock_Result.Text = resultNumber.ToString();
            return resultNumber;
        }

        private void Button_Result_Click(object sender, RoutedEventArgs e)
        {
            if (InputNumber2 != "") TextBlock_Result.Text = tempResult(resultNumber, InputNumber2, operation).ToString();
            else if (InputNumber1 != "") TextBlock_Result.Text = InputNumber1;
                 else TextBlock_Result.Text= resultNumber.ToString();
            
            InputNumber1 = "";
            InputNumber2 = "";
            resultNumber = 0;
            operation = 0;
            TextBox_Input.Text = "";
        }
    }
}
