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

namespace Csharp_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string input;
        string operand1;
        string operand2;
        string operation;
        public MainWindow()
        {
            InitializeComponent();
        }

        // 1st Row of Buttons

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
             UserInput.Text = "";
        }

        private void btnSign_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sign button clicked, add functionalty");
        }

        private void btnMod_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Mod button clicked, add functionalty");
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (UserInput.Text != "")
            {
                input = UserInput.Text;
                UserInput.Text = input.Remove(input.Length - 1);
            }
            else
            {
                MessageBox.Show("Text cleared");
            }
        }

        // 2nd Row of Buttons

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if(UserInput.Text == "Enter Equation")
            {
                UserInput.Text = "7";
            }
            else
            {
                UserInput.AppendText("7");
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (UserInput.Text == "Enter Equation")
            {
                UserInput.Text = "8";
            }
            else
            {
                UserInput.AppendText("8");
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (UserInput.Text == "Enter Equation")
            {
                UserInput.Text = "9";
            }
            else
            {
                UserInput.AppendText("9");
            }
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            if (UserInput.Text == "Enter Equation")
            {
                UserInput.Text = "/";
            }
            else
            {
                UserInput.AppendText("/");
            }
            operation = "/";
        }

        // 3rd Row of Buttons
        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (UserInput.Text == "Enter Equation")
            {
                UserInput.Text = "4";
            }
            else
            {
                UserInput.AppendText("4");
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (UserInput.Text == "Enter Equation")
            {
                UserInput.Text = "5";
            }
            else
            {
                UserInput.AppendText("5");
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (UserInput.Text == "Enter Equation")
            {
                UserInput.Text = "6";
            }
            else
            {
                UserInput.AppendText("6");
            }
        }

        private void btnMul_Click(object sender, RoutedEventArgs e)
        {
            if (UserInput.Text == "Enter Equation")
            {
                UserInput.Text = "*";
            }
            else
            {
                UserInput.AppendText("*");
            }
            operation = "*";
        }

        // 4th Row of buttons

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (UserInput.Text == "Enter Equation")
            {
                UserInput.Text = "1";
            }
            else
            {
                UserInput.AppendText("1");
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (UserInput.Text == "Enter Equation")
            {
                UserInput.Text = "2";
            }
            else
            {
                UserInput.AppendText("2");
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (UserInput.Text == "Enter Equation")
            {
                UserInput.Text = "3";
            }
            else
            {
                UserInput.AppendText("3");
            }
        }

        private void btnSub_Click(object sender, RoutedEventArgs e)
        {
            if (UserInput.Text == "Enter Equation")
            {
                UserInput.Text = "-";
            }
            else
            {
                UserInput.AppendText("-");
            }
            operation = "-";
        }

        // 5th Row of buttons

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (UserInput.Text == "Enter Equation")
            {
                UserInput.Text = "0";
            }
            else
            {
                UserInput.AppendText("0");
            }
        }

        private void btnPoint_Click(object sender, RoutedEventArgs e)
        {
            if (UserInput.Text == "Enter Equation")
            {
                UserInput.Text = ".";
            }
            else
            {
                UserInput.AppendText(".");
            }
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            operand2 = UserInput.Text;
            double num1, num2, result;
            double.TryParse(operand2.Substring(0,operand2.IndexOf(operation)), out num1);
            double.TryParse(operand2.Substring(operand2.IndexOf(operation) + 1), out num2);
            if (operation == "+") 
            {
                result = num1 + num2;
                UserInput.Text = result.ToString();
            }

            if (operation == "-")
            {
                result = num1 - num2;
                UserInput.Text = result.ToString();
            }

            if (operation == "*")
            {
                result = num1 * num2;
                UserInput.Text = result.ToString();
            }

            if (operation == "/")
            {
                result = num1 / num2;
                UserInput.Text = result.ToString();
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (UserInput.Text == "Enter Equation")
            {
                UserInput.Text = "+";
            }
            else
            {
                UserInput.AppendText("+");
            }
            operation = "+";
        }
    }
}
