using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string value = ((Button)sender).Content.ToString();
            if (GlobalHistory.AnswerHistory.Count > 0 && InOutTextBox.Text == GlobalHistory.AnswerHistory.Last() && !(value == "+" || value == "-" || value == "*" || value == "/"))
            {
                InOutTextBox.Text = value;
            } else if (InOutTextBox.Text.Contains("!"))
            {
                return;
            } else if (value == ".")
            {
                if (InOutTextBox.Text.Length == 0)
                {
                    InOutTextBox.Text = "0.";
                    return;
                }
                if (InOutTextBox.Text.Contains("."))
                {
                    if (InOutTextBox.Text.Substring(InOutTextBox.Text.LastIndexOfAny(new char[] { '+', '-', '*', '/', '!' }) + 1).Contains("."))
                    {
                        return;
                    }
                }
                InOutTextBox.Text = InOutTextBox.Text + value;
            }
            else if (value == "0" && InOutTextBox.Text == "0")
            {
                return;
            }
            else if (InOutTextBox.Text == "0" && value != ".")
            {
                InOutTextBox.Text = value;
            } else if (InOutTextBox.Text == "" && value == "-")
            {
                InOutTextBox.Text = "⁻";
            } else if (InOutTextBox.Text == "" && (value == "+" || value == "*" || value == "/"))
            {
                if (GlobalHistory.AnswerHistory.Count == 0)
                {
                    return;
                }
                InOutTextBox.Text = GlobalHistory.AnswerHistory.Last() + value;
            }
            else if ((value == "+" || value == "-" || value == "*" || value == "/") && (InOutTextBox.Text.Substring(InOutTextBox.Text.Length - 1) == "+" || InOutTextBox.Text.Substring(InOutTextBox.Text.Length - 1) == "-" || InOutTextBox.Text.Substring(InOutTextBox.Text.Length - 1) == "*" || InOutTextBox.Text.Substring(InOutTextBox.Text.Length - 1) == "/"))
            {
                if (value == "-" && (InOutTextBox.Text.Substring(InOutTextBox.Text.Length - 1) == "+" || InOutTextBox.Text.Substring(InOutTextBox.Text.Length - 1) == "-" || InOutTextBox.Text.Substring(InOutTextBox.Text.Length - 1) == "*" || InOutTextBox.Text.Substring(InOutTextBox.Text.Length - 1) == "/"))
                {
                    value = "⁻";
                    InOutTextBox.Text = InOutTextBox.Text + value;
                }
                return;
            }
            else
            {
                InOutTextBox.Text = InOutTextBox.Text + value;
            }
        }

        private void Button_Click_del(object sender, RoutedEventArgs e)
        {
            string textContent = InOutTextBox.Text;
            string newContent = "";
            for (int i = 0; i < textContent.Length - 1; i++)
            {
                newContent = newContent + textContent[i];
            }
            InOutTextBox.Text = newContent;
        }

        private void Button_Click_Clear(object sender, RoutedEventArgs e)
        {
            InOutTextBox.Text = "";
        }

        private void Button_Click_Equals(object sender, RoutedEventArgs e)
        {
            parseEquation(InOutTextBox.Text);
        }

        private void Button_Click_SwapSign(object sender, RoutedEventArgs e)
        {
            //Do later
            //remove ⁻ from numbers that have it
            //give ⁻ to numbers that don't
            // Split at operators { '+', '-', '*', '/', '!' }
            
            char[] operators = { '+', '-', '*', '/', '!' };
            char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '⁻', '.' };
            string[] splitEquation = InOutTextBox.Text.Split(operators);
            string[] equationOperators = InOutTextBox.Text.Split(digits);

            singleCleanup(ref equationOperators);

            for (int index = 0; index < splitEquation.Length; index++)
            {
                if (splitEquation[index].Contains("⁻"))
                {
                    splitEquation[index] = splitEquation[index].Replace("⁻", "");
                } else
                {
                    splitEquation[index] = "⁻" + splitEquation[index];
                }
            }

            string output = "";
            for (int index = 0; index < equationOperators.Length; index++)
            {
                output = output + splitEquation[index] + equationOperators[index];
            }
            output = output + splitEquation[splitEquation.Length - 1];

            InOutTextBox.Text = output;
        }

        private void Button_Click_History(object sender, RoutedEventArgs e)
        {
            string output = "History:\n";
            for (int i = 0; i < GlobalHistory.EquationHistory.Count; i++)
            {
                output = output + GlobalHistory.EquationHistory[i] + " = " + GlobalHistory.AnswerHistory[i] + "\n";
            }

            MessageBox.Show(output);
        }

        private void Button_Click_Work(object sender, RoutedEventArgs e)
        {
            if ((bool)ShowWorkCheckBox.IsChecked)
            {
                ShowWorkCheckBox.IsChecked = false;
            } else
            {
                ShowWorkCheckBox.IsChecked = true;
            }
        }

        private void InOutTextBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.Enter))
            {
                parseEquation(InOutTextBox.Text);
            }
        }

        private void parseEquation(string equation)
        {
            char[] operators = { '+', '-', '*', '/', '!' };
            char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '⁻', '.' };
            string[] splitEquation = equation.Split(operators);
            //char[] shatteredEquation = equation.ToCharArray();
            string[] equationOperators = equation.Split(digits);
            string showboxOutput = "";
            foreach (string number in splitEquation)
            {
                showboxOutput = showboxOutput + " " + number;
            }
            showboxOutput = "";
            foreach (string operatorChar in equationOperators)
            {
                showboxOutput = showboxOutput + " " + operatorChar;
            }

            singleCleanup(ref equationOperators);

            calc(splitEquation, equationOperators);
        }

        private void calc(string[] numbers_in, string[] operators_in)
        {

            string operators_string = listToString(operators_in);

            string numbers_string = listToString(numbers_in);

            for (int i = 0; i < numbers_in.Length; i++)
            {
                //Replace improvised negative sign for the actual one
                if (numbers_in[i].Contains("⁻"))
                {
                    numbers_in[i] = numbers_in[i].Replace("⁻", "-");
                }
            }

            singleCleanup(ref numbers_in);
            //5 2 ⁻3
            // + *
            int index = 0;
            showWork(numbers_in, operators_in);
            while (numbers_in.Length > 1)
            {
                if (operators_string.Contains("*") || operators_string.Contains("/")) {
                    if (operators_in[index] == "*")
                    {
                        //Parse Values
                        double.TryParse(numbers_in[index], out double a);
                        double.TryParse(numbers_in[index + 1], out double b);
                        //Do the math
                        double output = a * b;
                        //Replace a with the new number
                        numbers_in[index] = output.ToString();
                        //Mark b for deletion
                        numbers_in[index + 1] = "";

                        cleanup(index, ref numbers_in, ref operators_in, ref operators_string);

                        index = 0;
                        showWork(numbers_in, operators_in);
                        continue;
                    } else if (operators_in[index] == "/")
                    {
                        //Parse Values
                        double.TryParse(numbers_in[index], out double a);
                        double.TryParse(numbers_in[index + 1], out double b);
                        //Do the math
                        double output = a / b;
                        //Replace a with the new number
                        numbers_in[index] = output.ToString();
                        //Mark b for deletion
                        numbers_in[index + 1] = "";

                        cleanup(index, ref numbers_in, ref operators_in, ref operators_string);

                        index = 0;
                        showWork(numbers_in, operators_in);
                        continue;
                    }
                } else if (operators_string.Contains("+") || operators_string.Contains("-"))
                {
                    if (operators_in[index] == "+")
                    {
                        //Parse Values
                        double.TryParse(numbers_in[index], out double a);
                        double.TryParse(numbers_in[index + 1], out double b);
                        //Do the math
                        double output = a + b;
                        //Replace a with the new number
                        numbers_in[index] = output.ToString();
                        //Mark b for deletion
                        numbers_in[index + 1] = "";

                        cleanup(index, ref numbers_in, ref operators_in, ref operators_string);
                        
                        index = 0;
                        showWork(numbers_in, operators_in);
                        continue;
                    } else if (operators_in[index] == "-")
                    {
                        //Parse Values
                        double.TryParse(numbers_in[index], out double a);
                        double.TryParse(numbers_in[index + 1], out double b);
                        //Do the math
                        double output = a - b;
                        //Replace a with the new number
                        numbers_in[index] = output.ToString();
                        //Mark b for deletion
                        numbers_in[index + 1] = "";

                        cleanup(index, ref numbers_in, ref operators_in, ref operators_string);

                        index = 0;
                        showWork(numbers_in, operators_in);
                        continue;
                    }
                }

                
                
                index++;
                if (index == operators_in.Length)
                {
                    index = 0;
                }
            }
            if (numbers_in.Length > 0)
            {
                if (operators_in.Length > 0 && operators_in[0] == "!")
                {
                    if (numbers_in[0].Contains("."))
                    {
                        MessageBox.Show("Hey sorry, this special function is limited to integers because the math for when it's used on decimals is really complicated. The following output is the number calculated before the factorial tried applying");
                    }
                    else if (int.Parse(numbers_in[0]) > 20)
                    {
                        MessageBox.Show("The result of this equation exceeds the ulong limit, by a lot...");
                    }
                    else
                    {
                        long newNum = long.Parse(numbers_in[0]);
                        for (long i = newNum - 1; i > 0; i--)
                        {
                            newNum = newNum * i;
                        }
                        numbers_in[0] = newNum.ToString();
                    }
                }

                if (numbers_in[0].Contains("-"))
                {
                    numbers_in[0] = numbers_in[0].Replace("-", "⁻");
                }
                GlobalHistory.EquationHistory.Add(InOutTextBox.Text);
                GlobalHistory.AnswerHistory.Add(numbers_in[0]);
                InOutTextBox.Text = numbers_in[0];
            }
        }

        private void showWork(string[] numbers_in, string[] operators_in)
        {
            if ((bool)ShowWorkCheckBox.IsChecked)
            {
                string output = "";
                for (int index = 0; index < operators_in.Length; index++)
                {
                    output = output + numbers_in[index] + operators_in[index];
                }
                output = output + numbers_in[numbers_in.Length - 1];
                MessageBox.Show(output);
            }
        }
        //This function doesn't follow single purpose ideaology
        private void cleanup(int index, ref string[] numbers_in, ref string[] operators_in, ref string operators_string)
        {
            //Iterate through the number list and remove b (whose value is now "") by creating a temp new list without it
            List<string> tempNumbers_in = new List<string>();
            foreach (string number in numbers_in)
            {
                if (number != "")
                {
                    tempNumbers_in.Add(number);
                }
            }
            numbers_in = tempNumbers_in.ToArray();

            //Iterate through operator list to remove the last used operator, creates new list and string for those
            operators_in[index] = "";
            List<string> tempOperators_in = new List<string>();
            string tempOperators_string = "";
            foreach (string operator_in in operators_in)
            {
                if (operator_in != "")
                {
                    tempOperators_in.Add(operator_in);
                    tempOperators_string = tempOperators_string + " " + operator_in;
                }
            }

            operators_in = tempOperators_in.ToArray();
            operators_string = tempOperators_string;
        }

        private void singleCleanup(ref string[] list_in)
        {
            List<string> tempList_in = new List<string>();
            foreach (string number in list_in)
            {
                if (number != "")
                {
                    tempList_in.Add(number);
                }
            }
            list_in = tempList_in.ToArray();
        }

        private string listToString(string[] list )
        {
            string string_list = "";
            foreach (var item in list)
            {
                string_list = string_list + " " + item;
            }

            return string_list;
        }

        
    }
}
