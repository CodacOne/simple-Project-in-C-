using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
   

    public partial class Form1 : Form
    {

        private string Input = "";
        private string FullResult = "";
        private double Result =0;
        private char Operation ;


        public Form1()
        {
            InitializeComponent();
        }


        ////////////////////////////////////

        private void StartCalculate(Button btn)
        {
            if(Operation=='\0')
            {
                Input += btn.Tag.ToString();
                FullResult = Input;

            }

           else

            {
                Input += btn.Tag.ToString();
                FullResult =  $" {Result} {Operation} {Input}";
            }

            lblPanel.Text = FullResult;
        }


        ////////////////////////////////////
        private void OperationChoice(Button btn)
        {

            Operation = btn.Tag.ToString()[0];
            Result = Double.Parse(Input);
            Input = "";
            FullResult = $"{Result} {Operation}";

            lblPanel.Text = FullResult;

        }

        ////////////////////////////////////
        private void ResultCalculater()
        {
            double SecondInput = double.Parse(Input);

            string FinalResult = $"{FullResult} = ";

            if (Operation == '\0' || string.IsNullOrEmpty(Input))
                return;


            switch (Operation)
            {
                case '+':
                    Result += SecondInput;
                    break;

                case '-':
                    Result -= SecondInput;
                    break;

                case '*':
                    Result *= SecondInput;
                    break;

                case '^':
                    Result = Math.Pow(Result,SecondInput);
                    break;

                case '/':
                    Result /= SecondInput;
                    break;

            }

            FinalResult+= Result.ToString();
            lblPanel.Text = FinalResult;
            FullResult = "";
            Input = Result.ToString();
            Operation = '\0';


        }




        ////////////////////////////////////
        ///
        private void ResetCalculater()
        {
            lblPanel.Text = "";
            Input = "";
            Result = 0;
            Operation = '\0';
            FullResult = "";

        }




        ////////////////////////////////////
        ///
        private void Backspace()
        {

            if (!string.IsNullOrEmpty(Input))
            {
               
                Input = Input.Substring(0, Input.Length - 1);

               
                if (Operation == '\0')
                {
                    FullResult = Input;
                }
                else
                {
                    FullResult = $"{Result} {Operation} {Input}";
                }

               
                lblPanel.Text = FullResult;
            }

        }


        ////////////////////////////////////
        private void Button4_Click(object sender, EventArgs e)
        {
            OperationChoice((Button)sender);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            StartCalculate((Button)sender);

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            StartCalculate((Button)sender);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            StartCalculate((Button)sender);
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            StartCalculate((Button)sender);
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            StartCalculate((Button)sender);
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            StartCalculate((Button)sender);
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            StartCalculate((Button)sender);
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            StartCalculate((Button)sender);
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            StartCalculate((Button)sender);
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            StartCalculate((Button)sender);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            OperationChoice((Button)sender);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            OperationChoice((Button)sender);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            OperationChoice((Button)sender);
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            OperationChoice((Button)sender);
        }

        private void Button18_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ResetCalculater();
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            ResultCalculater();
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            StartCalculate((Button)sender);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Backspace();
        }
    }
}
