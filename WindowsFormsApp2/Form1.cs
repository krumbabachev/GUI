using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        double result = 0;
        double FirstNumber;
        double SecondNumber;
        double NumberCopy;
        //string operationPerform = "";
        //bool operationIsPerformed = false;
        string Operation;
        bool LastPressedIsOperation;



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if ((textBox_Result.Text == "0" || LastPressedIsOperation) && textBox_Result.Text != null)
            {
                textBox_Result.Text = button.Text;
            }
            else
            {
                textBox_Result.Text += textBox_Result.Text;
            }
            LastPressedIsOperation = false;


            //if ((textBox_Result.Text == "0") || (operationIsPerformed))
            //{
            //    textBox_Result.Clear();
            //}

            //operationIsPerformed = false;

           
            //if (button.Text == ",")
            //{
            //    if (!textBox_Result.Text.Contains(","))
            //    {
            //        textBox_Result.Text = textBox_Result.Text + button.Text;
            //    }

            //}
            //else
            //{
            //    textBox_Result.Text = textBox_Result.Text + button.Text;
            //}

            ////textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
           
            if (LastPressedIsOperation) return;
            FirstNumber = Convert.ToDouble(textBox_Result.Text, System.Globalization.CultureInfo.InvariantCulture);
            NumberCopy = FirstNumber;
            Operation = button.Text;
            textBox_Result.Text = Operation;
            LastPressedIsOperation = true;

            //if (result != 0)
            //{
            //button5.PerformClick();
            //     if (lblCurrentOperation.Text != "")
            //     {
            //         button15.PerformClick();
            //     }
            //     lblCurrentOperation.Text = result + " " + operationPerform;
            //     result = double.Parse(textBox_Result.Text);
            //     operationIsPerformed = true;
            //     operationPerform = button.Text;
            // }
            // else
            // {
            //operationPerform = button.Text;
            //result = double.Parse(textBox_Result.Text);
            // lblCurrentOperation.Text = result + " " + operationPerform;
            // operationIsPerformed = true;
            // }





            //operationPerform = button.Text;
            //result = double.Parse(textBox_Result.Text);
            //lblCurrentOperation.Text = result + " " + operationPerform;
            //operationIsPerformed = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            LastPressedIsOperation = false;
            NumberCopy = 0;
            FirstNumber = 0;
            SecondNumber = 0;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            LastPressedIsOperation = false;
            NumberCopy = 0;
            FirstNumber = 0;
            SecondNumber = 0;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (LastPressedIsOperation || Operation.Length == 0) return;

            if (SecondNumber != NumberCopy)
            {
                SecondNumber = Convert.ToDouble(textBox_Result.Text, System.Globalization.CultureInfo.InvariantCulture);
            }
                        
            switch (Operation)
            {
                case "+":
                    FirstNumber += SecondNumber;
                    textBox_Result.Text = Convert.ToString(FirstNumber, System.Globalization.CultureInfo.InvariantCulture);
                    break;

                case "-":
                    FirstNumber -= SecondNumber;
                    textBox_Result.Text = Convert.ToString(FirstNumber, System.Globalization.CultureInfo.InvariantCulture);
                    break;

                case "*":
                    FirstNumber *= SecondNumber;
                    textBox_Result.Text = Convert.ToString(FirstNumber, System.Globalization.CultureInfo.InvariantCulture);
                    break;

                case "/":
                    if (SecondNumber == 0)
                    {
                        textBox_Result.Text = "UNIVERSE DESTROYED! ";
                    }
                    else
                    {
                        FirstNumber /= SecondNumber;
                        textBox_Result.Text = Convert.ToString(FirstNumber, System.Globalization.CultureInfo.InvariantCulture);
                    }
                    break;

                default:
                    break;


            }
            //result = double.Parse(textBox_Result.Text);
            //lblCurrentOperation.Text = "";
            NumberCopy = SecondNumber;
        }
    }
}
