using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace CShapeLearn
{
    enum Level
    {
        Low,
        Medium,
        High
    }
    class Animal  // Base class (parent) 
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }
    interface IFirstInterface
    {
        void myMethod(); // interface method
    }

    interface ISecondInterface
    {
        void myOtherMethod(); // interface method
    }

    // Implement multiple interfaces
    class DemoClass : IFirstInterface, ISecondInterface
    {
        public void myMethod()
        {
            Console.WriteLine("Some text..");
        }
        public void myOtherMethod()
        {
            Console.WriteLine("Some other text...");
        }
    }

    class Program
    {
  
        static void Main(string[] args)
        {
            DemoClass myObj = new DemoClass();
            myObj.myMethod();

            //File.Create("filename.txt");



            Level myVar = Level.Low;
            EnumCase(myVar);
        }
        static void EnumCase(Level myVar)
        {
            
            switch (myVar)
            {
                case Level.Low:
                    Console.WriteLine("Low Level");
                    break;
                case Level.Medium:
                    Console.WriteLine("Medium Level");
                    break;
                case Level.High:
                    Console.WriteLine("High Level");
                    break;

            }

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
