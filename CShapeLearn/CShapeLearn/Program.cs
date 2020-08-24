using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShapeLearn
{
    class Program
    {
        string color = "red";
        static void Main(string[] args)
        {
            
            //AddTwoNumber();
            //MyMethod("child3","","hello");
            /*int myNum1 = PlusMethod(8, 5);
            double myNum2 = PlusMethod(4.3, 6.26);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2);
            */
            Program a = new Program();
            Console.WriteLine(a.color);
        }
        static int AddTwoNumber()
        {
            Console.WriteLine("Add two numbers");

            Console.WriteLine("Enter first number:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            int x = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int y = Convert.ToInt16(Console.ReadLine());
            int z = x + y;
            Console.WriteLine("The sum is " + z);
            return x + y;
        }
        static void MyMethod(string child1 = "Liam", string child2 = "Jenny", string child3 = "John")
        {
            Console.WriteLine(child3);
        }
        static int PlusMethod(int x, int y)
        {
            return x + y;
        }

        static double PlusMethod(double x, double y)
        {
            return x + y;
        }



    }
}
