using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using System;
using System.Collections;
using Environment = System.Environment;

namespace first_app
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var edittxt = FindViewById<EditText>(Resource.Id.edit);
            var btnC = FindViewById<Button>(Resource.Id.btnC);
            var btnD = FindViewById<Button>(Resource.Id.btnD);
            var btn0 = FindViewById<Button>(Resource.Id.btn0);
            var btn1 = FindViewById<Button>(Resource.Id.btn1);
            var btn2 = FindViewById<Button>(Resource.Id.btn2);
            var btn3 = FindViewById<Button>(Resource.Id.btn3);
            var btn4 = FindViewById<Button>(Resource.Id.btn4);
            var btn5 = FindViewById<Button>(Resource.Id.btn5);
            var btn6 = FindViewById<Button>(Resource.Id.btn6);
            var btn7 = FindViewById<Button>(Resource.Id.btn7);
            var btn8 = FindViewById<Button>(Resource.Id.btn8);
            var btn9 = FindViewById<Button>(Resource.Id.btn9);
            var btnM = FindViewById<Button>(Resource.Id.btnM);
            var btnSupp = FindViewById<Button>(Resource.Id.btnSupp);
            var btnMin = FindViewById<Button>(Resource.Id.btnMin);
            var btnP = FindViewById<Button>(Resource.Id.btnP);
            var btnpar = FindViewById<Button>(Resource.Id.btnpar);
            var btnpoint = FindViewById<Button>(Resource.Id.btnpoint);
            var btnboth = FindViewById<Button>(Resource.Id.btnboth);
            var btnequal = FindViewById<Button>(Resource.Id.btnequal);

            string input = string.Empty;        //String storing user input
            String operand1 = string.Empty;     //String storing first operand
            String operand2 = string.Empty;     //String storing second operand
            char operation=' ';                     //Char to store operator
            double result = 0.0;                //Get result

            btnC.Click += delegate {
                edittxt.Text = "";
                result = 0.0;
            };
            btnD.Click += delegate
            {
                operand1 = input;
                operation = '/';
                input = string.Empty;
            };
            btnM.Click += delegate
            {
                operand1 = input;
                operation = '*';
                input = string.Empty;
            };
            btnMin.Click += delegate
            {
                operand1 = input;
                operation = '-';
                input = string.Empty;
            };
            btnP.Click += delegate
            {
                operand1 = input;
                operation = '+';
                input = string.Empty;
                edittxt.Text += "+";
            };
          
            btn0.Click += delegate
            {
                edittxt.Text = "";
                input += "0";
                edittxt.Text += "0";
            };
            btn1.Click += delegate
            {
                //edittxt.Text = "";
                input += "1";
                edittxt.Text += "1";
            };
            btn2.Click += delegate
            {
                edittxt.Text = "";
                input += "2";
                edittxt.Text += "2";
            };
            btn3.Click += delegate
            {
                edittxt.Text = "";
                input += "3";
                edittxt.Text += "3";
            };
            btn4.Click += delegate
            {
                edittxt.Text = "";
                input += "4";
                edittxt.Text += "4";
            };
            btn5.Click += delegate
            {
                edittxt.Text = "";
                input += "5";
                edittxt.Text += "5";
            };
            btn6.Click += delegate
            {
                edittxt.Text = "";
                input += "6";
                edittxt.Text += "6";
            };
            btn7.Click += delegate
            {
                edittxt.Text = "";
                input += "7";
                edittxt.Text += "7";
            };
            btn8.Click += delegate
            {
                edittxt.Text = "";
                input += "8";
                edittxt.Text += "8";
            };
            btn9.Click += delegate
            {
                edittxt.Text = "";
                input += "9";
                edittxt.Text += "9";
            };
            btnpoint.Click += delegate
            {
                input += ".";
            };
            btnSupp.Click += delegate
            {
                try { 
                    edittxt.Text = edittxt.Text.Remove(edittxt.Text.Length - 1, 1);
                }
                catch(Exception ex)
                { }
            };
            btnequal.Click += delegate
            {
              
                try
                {
                    result = 0.0;
                    operand2 = input;
                    double num1, num2;
                    double.TryParse(operand1, out num1);
                    double.TryParse(operand2, out num2);

                    if (operation == '+')
                    {
                        result = num1 + num2;
                        edittxt.Text = result.ToString();
                    }
                    else if (operation == '-')
                    {
                        result = num1 - num2;
                        edittxt.Text = result.ToString();
                    }
                    else if (operation == '*')
                    {
                        result = num1 * num2;
                        edittxt.Text = result.ToString();
                    }
                    else if (operation == '/')
                    {
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            edittxt.Text = result.ToString();
                        }
                        else
                        {
                            edittxt.Text = "ERROR DIV BY ZERO";
                        }
                    }

                }
                catch (Exception ex)
                { }
            };


        }
    }
}