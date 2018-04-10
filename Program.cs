using System;
using System.Linq;

namespace basicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNo;
            string secondNo;
            double result = 0;
            string strOp;

            Console.WriteLine("Enter First No.:");
            firstNo = Convert.ToString(Console.ReadLine());

            double firstNoDouble;
            if (double.TryParse(firstNo, out firstNoDouble) == false)
            {
                Console.WriteLine("You entered an invalid number");
                Console.WriteLine("Enter First No.:");
                firstNoDouble = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Enter Second No.:");
            secondNo = Convert.ToString(Console.ReadLine());

            double secondNoDouble;
            if (double.TryParse(secondNo, out secondNoDouble) == false)
            {
                Console.WriteLine("You entered an invalid number");
                Console.WriteLine("Enter First No.:");
                secondNoDouble = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("Enter Operator:");
            strOp = Convert.ToString(Console.ReadLine());

            string[] constOperators = { "+", "-", "*", "/" };
            if (constOperators.Contains(strOp))
            {
                switch (strOp)
                {
                    case "+":
                        result = firstNoDouble + secondNoDouble;
                        break;

                    case "-":
                        result = firstNoDouble - secondNoDouble;
                        break;

                    case "*":
                        result = firstNoDouble * secondNoDouble;
                        break;

                    case "/":
                        result = firstNoDouble / secondNoDouble;
                        break;
                }
            }
            else
            {
                Console.WriteLine("You entered an invalid Operator");
                Console.WriteLine("Enter Operator:");
                strOp = Convert.ToString(Console.ReadLine());
            }


            Console.WriteLine(firstNoDouble + " " + strOp + " " + secondNoDouble + " = " + result);

            Console.ReadLine();
        }
    }
}
