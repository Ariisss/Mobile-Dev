using Microsoft.Maui.Graphics.Text;
using System.Buffers;

namespace _2203
{
    public partial class MainPage : ContentPage
    {

        double[] inputs = [0,0];
        double result = 0;
        char operation = '\0';
        bool lastInput = false;
        public MainPage()
        {

            InitializeComponent();

            ButtonC.Clicked += (sender, e) =>
            {
                display.Text = "0";
                inputBox.Text = " ";
                inputs = [0,0];
                operation = '\0';
            };

            ButtonDEL.Clicked += (sender, e) =>
            {
                if(display.Text.Length > 1)
                { 
                    display.Text = display.Text.Remove(display.Text.Length - 1);
                }
                else
                {
                    display.Text = "0";
                }
            };

            ButtonEquals.Clicked += (sender, e) => { 
                if(operation!= '\0')
                {
                    switch(operation)
                    {
                        case '/':
                                inputs[1] = double.Parse(display.Text);
                                result = inputs[0] / inputs[1];
                                displayFormat(result);
                                inputs[0] = 0;
                                inputBox.Text = " ";
                            break;
                        case '+':
                                inputs[1] = double.Parse(display.Text);
                                result = inputs[0] + inputs[1];
                                displayFormat(result);
                                inputs[0] = 0;
                                inputBox.Text = " ";
                            break;
                        case '-':
                                inputs[1] = double.Parse(display.Text);
                                result = inputs[0] - inputs[1];
                                displayFormat(result);
                                inputs[0] = 0;
                                inputBox.Text = " ";
                            break;
                        case 'x':
                                inputs[1] = double.Parse(display.Text);
                                result = inputs[0] * inputs[1];
                                displayFormat(result);
                                inputs[0] = 0;
                                inputBox.Text = " ";
                            break;
                    }
                    operation = '\0';
                }
            };

            ButtonDivide.Clicked += OperationClicked;
            ButtonPlus.Clicked += OperationClicked;
            ButtonMultiply.Clicked += OperationClicked;
            ButtonMinus.Clicked += OperationClicked;

            ButtonDot.Clicked += (sender, e) =>
            {
                if(!display.Text.Contains('.')){
                    display.Text += ".";
                };
                lastInput = false;
            };

            Button0.Clicked += (sender, e) =>
            {
                if (display.Text != "0")
                {
                    display.Text += "0";
                }
                else
                {
                    display.Text = "0";
                }
                lastInput = false;
            };

            Button1.Clicked += (sender, e) =>
            {
                if (display.Text != "0")
                {
                    display.Text += "1";
                }
                else
                {
                    display.Text = "1";
                }
                lastInput = false;
            };

            Button2.Clicked += (sender, e) =>
            {
                if (display.Text != "0")
                {
                    display.Text += "2";
                }
                else
                {
                    display.Text = "2";
                }
                lastInput = false;
            };

            Button3.Clicked += (sender, e) =>
            {
                if (display.Text != "0")
                {
                    display.Text += "3";
                }
                else
                {
                    display.Text = "3";
                }
                lastInput = false;
            };

            Button4.Clicked += (sender, e) =>
            {
                if (display.Text != "0")
                {
                    display.Text += "4";
                }
                else
                {
                    display.Text = "4";
                }
                lastInput = false;
            };

            Button5.Clicked += (sender, e) =>
            {
                if (display.Text != "0")
                {
                    display.Text += "5";
                }
                else
                {
                    display.Text = "5";
                }
                lastInput = false;
            };

            Button6.Clicked += (sender, e) =>
            {
                if (display.Text != "0")
                {
                    display.Text += "6";
                }
                else
                {
                    display.Text = "6";
                }
                lastInput = false;
            };

            Button7.Clicked += (sender, e) =>
            {
                if (display.Text != "0")
                {
                    display.Text += "7";
                }
                else
                {
                    display.Text = "7";
                }
                lastInput = false;
            };

            Button8.Clicked += (sender, e) =>
            {
                if (display.Text != "0")
                {
                    display.Text += "8";
                }
                else
                {
                    display.Text = "8";
                }
                lastInput = false;
            };

            Button9.Clicked += (sender, e) =>
            {
                if (display.Text != "0")
                {
                    display.Text += "9";
                }
                else
                {
                    display.Text = "9";
                }
                lastInput = false;
            };

            void useOperation(double parsedText)
            {
                switch (operation)
                {
                    case '/':
                        inputs[0] /= parsedText; break;
                    case '+':
                        inputs[0] += parsedText; break;
                    case '-':
                        inputs[0] -= parsedText; break;
                    case 'x':
                        inputs[0] *= parsedText; break;
                }
            }

            void displayFormat(double number)
            {
                int maxDigits = 10;

                string formattedNumber = number.ToString("F" + (maxDigits - 1));

                if ((formattedNumber.Length > maxDigits && formattedNumber.Contains(".")) || Math.Abs(number) >= Math.Pow(10, maxDigits))
                {
                    formattedNumber = number.ToString("G" + (maxDigits - 1));
                }
                else if (formattedNumber.Length > maxDigits)
                {
                    int decimalPlaces = maxDigits - (formattedNumber.IndexOf('.') + 1);
                    formattedNumber = number.ToString("F" + decimalPlaces);
                }

                display.Text = formattedNumber;
            }

            void OperationClicked(object sender, EventArgs e)
            {
                if (!(sender is Button button)) return;

                if (lastInput && operation != '\0')
                {
                    operation = button.Text[0];
                    inputBox.Text = $"{inputs[0]} {operation}";
                }
                else
                {
                    double parsedText;
                    if (!double.TryParse(display.Text, out parsedText))
                    {
                        display.Text = "Error";
                        return;
                    }

                    if (!lastInput || inputs[0] == 0)
                    {
                        if (operation != '\0')
                        {
                            useOperation(parsedText);
                        }
                        else
                        {
                            inputs[0] = parsedText;
                        }

                        display.Text = "0";
                        operation = button.Text[0];
                        inputBox.Text = $"{inputs[0]} {operation}";
                    }
                }
                lastInput = true;
            }





        }

    }

}
