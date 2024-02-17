using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AMC.SimpleCalculator.UI
{
    public class Calculator
    {
        public Calculator() { }
        public double number1 {  get; set; }
        public double number2 { get; set; }
        public string Function { get; set; } = "";

        public bool assigned1 {  get; set; }= false;
        public bool assigned2 { get; set; }=false;



        public double addition(double number1, double number2)
        {
            return number1 + number2;
        }
        public double subtraction(double number1, double number2)
        {
            return number1 - number2;
        }
        public double multiplication (double number1, double number2) 
        {
            return number1 * number2;
        }
        public double division(double number1, double number2)
        {
            try
            {
                return number1 / number2;
            }
            catch
            {
                MessageBox.Show("DIVIDE BY ZERO ERROR");
                return 0;
            }



        }
        public double sqrt(double number1)
        {
            return (double)(Math.Sqrt(number1));
        }
        public double reciprical(double number1) 
        {
            return 1 / number1;
        }
        public void Assignnumber(double input=0)
        {

            if (assigned1==false)
            {
                assigned1 = true;
                number1 = input;
            }
            else if (assigned2 == false)
            {
                assigned2 = true;
                number2 = input;
            }
            else
            {
                executefunction();
            }
        }
        public void storefunction(string input) 
        { 
            Function = input;
        }
        public double executefunction()
        {
            assigned1=false;
            assigned2 = false;
            if (Function == "+")
            {
                return addition(number1,number2);
            }
            else if(Function == "-")
            {
                return subtraction(number1,number2);
            }
            else if (Function == "*")
            {
                return multiplication(number1, number2);
            }
            else if (Function == "/")
            {
                return division(number1,number2);
            }
            else if(Function == "sqrt")
            {
                return sqrt(number1);
            }
            else { return reciprical(number1); }
        }
    }
}
