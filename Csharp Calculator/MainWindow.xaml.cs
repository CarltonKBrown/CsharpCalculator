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
        string equation;
        string operation = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        // 1st Row of Buttons

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            if(Result_txt.Text == "" && Display.Text == "" || Result_txt.Text == "Enter Equation")
            {
                MessageBox.Show("Screen already cleared.");
            }
            else
            {
                Display.Text = "";
                Result_txt.Text = "";
                operation = "";
            }
        }

        private void btnSign_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sign button clicked, add functionalty");
        }

        private void btnMod_Click(object sender, RoutedEventArgs e)
        {
            if (operation != "")
            {
                MessageBox.Show("Operator already present");
            }

            if (Result_txt.Text == "Enter Equation" && operation == "")
            {
                Result_txt.Text = "%";
                operation = "%";
            }
            if (operation == "" && Result_txt.Text != "UNDEFINED")
            {
                Result_txt.AppendText("%");
                operation = "%";
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            string res = Result_txt.Text;
            if (Result_txt.Text == "UNDEFINED")
            {
                Display.Text = "";
                Result_txt.Text = "";
                operation = "";
            }

            if (!Result_txt.Text.Contains("+") && !Result_txt.Text.Contains("-") && !Result_txt.Text.Contains("*") && !Result_txt.Text.Contains("/") && !equation.Contains("%"))
            {
                operation = "";
            }

            if (Result_txt.Text != "")
            {
                input = Result_txt.Text;
                this.Result_txt.Text = input.Remove(input.Length - 1);
              
            }
            else
            {
                MessageBox.Show("Text cleared");
                operation = "";
            }

            
        }

        // 2nd Row of Buttons

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if(Result_txt.Text == "Enter Equation" || Result_txt.Text == "UNDEFINED")
            {
                Result_txt.Text = "7";
            }
            else
            {
                Result_txt.AppendText("7");
            }
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (Result_txt.Text == "Enter Equation" || Result_txt.Text == "UNDEFINED")
            {
                Result_txt.Text = "8";
            }
            else
            {
                Result_txt.AppendText("8");
            }
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if(Result_txt.Text == "Enter Equation" || Result_txt.Text == "UNDEFINED")
            {
                Result_txt.Text = "9";
            }
            else
            {
                Result_txt.AppendText("9");
            }
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            if (operation != "")
            {
                MessageBox.Show("Operator already present");
            }

            if (Result_txt.Text == "Enter Equation" && operation == "")
            {
                Result_txt.Text = "/";
                operation = "/";
            }
            if (operation == "" && Result_txt.Text != "UNDEFINED")
            {
                Result_txt.AppendText("/");
                operation = "/";
            }
        }

        // 3rd Row of Buttons
        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if(Result_txt.Text == "Enter Equation" || Result_txt.Text == "UNDEFINED")
            {
                Result_txt.Text = "4";
            }
            else
            {
                Result_txt.AppendText("4");
            }
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if(Result_txt.Text == "Enter Equation" || Result_txt.Text == "UNDEFINED")
            {
                Result_txt.Text = "5";
            }
            else
            {
                Result_txt.AppendText("5");
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if(Result_txt.Text == "Enter Equation" || Result_txt.Text == "UNDEFINED")
            {
                Result_txt.Text = "6";
            }
            else
            {
                Result_txt.AppendText("6");
            }
        }

        private void btnMul_Click(object sender, RoutedEventArgs e)
        {
            if (operation != "")
            {
                MessageBox.Show("Operator already present");
            }

            if (Display.Text == "UNDEFINED")
            {
                MessageBox.Show("Please clear text");
            }

            if (Result_txt.Text == "Enter Equation" && operation == "")
            {
                Result_txt.Text = "*";
                operation = "*";
            }
            if (operation == "" && Result_txt.Text != "UNDEFINED")
            {
                Result_txt.AppendText("*");
                operation = "*";
            }

        }

        // 4th Row of buttons

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if(Result_txt.Text == "Enter Equation" || Result_txt.Text == "UNDEFINED")
            {
                Result_txt.Text = "1";
            }
            else
            {
                Result_txt.AppendText("1");
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if(Result_txt.Text == "Enter Equation" || Result_txt.Text == "UNDEFINED")
            {
                Result_txt.Text = "2";
            }
            else
            {
                Result_txt.AppendText("2");
            }
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if(Result_txt.Text == "Enter Equation" || Result_txt.Text == "UNDEFINED")
            {
                Result_txt.Text = "3";
            }
            else
            {
                Result_txt.AppendText("3");
            }
        }

        private void btnSub_Click(object sender, RoutedEventArgs e)
        {
            if (operation != "")
            {
                MessageBox.Show("Operator already present");
            }

            if (Result_txt.Text == "Enter Equation" && operation == "")
            {
                Result_txt.Text = "-";
                operation = "-";
            }
            if (operation == "" && Result_txt.Text != "UNDEFINED")
            {
                Result_txt.AppendText("-");
                operation = "-";
            }
        }

        // 5th Row of buttons

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if(Result_txt.Text == "Enter Equation" || Result_txt.Text == "UNDEFINED")
            {
                Result_txt.Text = "0";
            }
            else
            {
                Result_txt.AppendText("0");
            }
        }

        private void btnPoint_Click(object sender, RoutedEventArgs e)
        {
            if(Result_txt.Text == "Enter Equation" || Result_txt.Text == "UNDEFINED")
            {
                Result_txt.Text = ".";
            }
            else
            {
                Result_txt.AppendText(".");
            }
        }

        // Handles equal button click event
        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            equation = Result_txt.Text;

            double num1, num2, result;

            double.TryParse(equation.Substring(0,equation.IndexOf(operation)), out num1);

            if (!equation.Contains("+") && !equation.Contains("-") && !equation.Contains("*") && !equation.Contains("/") && !equation.Contains("%"))
            {
                MessageBox.Show("Operator not present!");
            }

            if (equation.Substring(equation.IndexOf(operation) + 1) == "")
            {
                double.TryParse(equation.Substring(0, equation.IndexOf(operation)), out num2);
            }
            else
            {
                double.TryParse(equation.Substring(equation.IndexOf(operation) + 1), out num2);
            }

            if (equation == "UNDEFINED")
            {
                MessageBox.Show("Result is Undefined, Please clear text");
            }

            if (operation == "+") 
            {
                result = num1 + num2;
                Display.Text = num1.ToString() + "+" + num2.ToString();
                Result_txt.Text = result.ToString();
            }

            if (operation == "-")
            {
                result = num1 - num2;
                Display.Text = num1.ToString() + "-" + num2.ToString();
                Result_txt.Text = result.ToString();
            }

            if (operation == "*")
            {
                result = num1 * num2;
                Display.Text = num1.ToString() + "*" + num2.ToString();
                Result_txt.Text = result.ToString();
            }

            if (operation == "/")
            {   
                if(num2 == 0)
                {
                    Result_txt.Text = "UNDEFINED";
                    Display.Text = equation;
                }else
                {
                    result = num1 / num2;
                    Display.Text = num1.ToString() + "/" + num2.ToString();
                    Result_txt.Text = result.ToString();
                }
                
            }

            if (operation == "%")
            {
                if (num2 == 0)
                {
                    Result_txt.Text = "UNDEFINED";
                    Display.Text = equation;
                }
                else
                {
                    result = num1 / num2;
                    Display.Text = num1.ToString() + "%" + num2.ToString();
                    Result_txt.Text = result.ToString();
                }

            }

            operation = "";
        }

        // Addition button click event
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (operation != "")
            {
                MessageBox.Show("Operator already present");
            }

            if (Result_txt.Text == "Enter Equation" && operation == "")
            {
                Result_txt.Text = "+";
                operation = "+";
            }
            if (operation == "" && Result_txt.Text != "UNDEFINED")
            {
                Result_txt.AppendText("+");
                operation = "+";
            }
        }

        // About click event
        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("\t        Created by:\n\t     Carlton Brown \n\n\t           Email:\n      CarltonkBrown94@gmail.com \n\n\t       Github:\n     https://github.com/CarltonKBrown");
            
        }
    }
}
