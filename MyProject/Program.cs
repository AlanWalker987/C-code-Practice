using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public class Program
    {
        const double PI = 3.245;
        static void Main(string[] args)
        {
            Local_Variable lv = new Local_Variable();
            Instance_Variable Iv = new Instance_Variable();

            lv.VPractise();
            lv.getNumber();

            Iv.Name = "Karthik";
            Iv.Age = 25;
            Instance_Variable.Place = "Mysore";
            Instance_Variable.Idnum = 007;
            Console.WriteLine("The value of PI is " + PI);
            Console.WriteLine($"Place is {Instance_Variable.Place} and {Instance_Variable.Idnum}");
            Console.WriteLine($"Name is {Iv.Name} and Age is {Iv.Age}");

            Functions f1 = new Functions();
            f1.sum();
            int sumoftwonumbers = f1.sumoftwo();
            Console.WriteLine(sumoftwonumbers);
            int multiply2 = f1.multiply(2, 4);
            int multiply3 = f1.multiply(1, 2, 3);

            Console.WriteLine("multiply of 2 numbers " + multiply2);
            Console.WriteLine("multiply of 3 numbers " + multiply3);
            int number1 = 15, number2 = 20, sum;
            sum = number1 + number2;
            Console.WriteLine("{0} + {1} = {2}", number1, number2, sum);
            int greeting = 2;
            
            switch (greeting)
            {
                case 1:
                    Console.WriteLine("Hello");
                    goto default;
                case 2:
                    Console.WriteLine("Hi");
                    goto case 3;
                case 3:
                    Console.WriteLine("Namaste");
                    goto default;
                default:
                    Console.WriteLine("Entered value is: " + greeting);
                    break;
            }

            Console.ReadKey();

            /* Write to the console  
              Console.WriteLine("Hello");
              Console.Write("World!!");
              Console.ReadKey();

              string name = "Karthik";
              Console.WriteLine(name);
              Console.Write("name " + name);
              Console.ReadLine();
            */


            /* Read from the console 
             Console.WriteLine("Enter your name");
             string name = Console.ReadLine();
             Console.Write("hello " + name);
             Console.ReadKey();
            */

            /* Sum of two numbers

             Console.WriteLine("ENTER TWO NUMBERS");
             int a = int.Parse(Console.ReadLine());
             int b = Convert.ToInt32(Console.ReadLine());
             int c = a + b;
             Console.WriteLine("Sum is " + c);
             Console.WriteLine("The sum is " + c);
             Console.ReadKey();
            */


            /* Read and Write Employee details 

            Console.WriteLine("Enter the Employee details");
            Console.WriteLine("Enter Employee name");
            string eName = Console.ReadLine();
            Console.WriteLine("Enter Employee ID");
            int eID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee salary");
            int eSalary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Place");
            string ePlace = Console.ReadLine();

            Console.WriteLine("Employee ID " + eID);
            Console.WriteLine("Employee Name " + eName);
            Console.WriteLine("Employee Salary " + eSalary);
            Console.WriteLine("Employee Place " + ePlace);

            Console.ReadKey();
            */

            /* Enter student detials and calculate average marks and print 

            Console.WriteLine("Enter the student details");
            Console.WriteLine("Enter Student Name");
            string sName = Console.ReadLine();
            Console.WriteLine("Enter Student ID");
            int sId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter three subjects marks");
            int mark_1 = int.Parse(Console.ReadLine());
            int mark_2 = int.Parse(Console.ReadLine());
            int mark_3 = int.Parse(Console.ReadLine());

            int averageMarks = (mark_1 + mark_2 + mark_3) / 3;
            Console.WriteLine("Student Details");

            Console.WriteLine("Student Name " + sName);
            Console.WriteLine("Student ID " + sId);
            Console.WriteLine("Average Marks " + averageMarks);

            Console.ReadKey();

            */

            /* inbuilt console methods and properties 

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "Understanding Console class";

            Console.WriteLine("Background color");
            Console.WriteLine("Foreground color");
            Console.WriteLine("understanding console class");
            Console.ReadKey();
            */

            /* escape sequence 
            string Name = "\"Dotnettutorials\"";
            Console.WriteLine(Name);
            // Displaying new line character in c#
            Name = "One\nTwo\nThree";
            Console.WriteLine(Name);
            // Displaying new line character in c#
            Name = "c:\\Pranaya\\Dotnettutorials\\Csharp";
            Console.WriteLine(Name);
            // C# verbatim literal
            Name = @"c:\Pranaya\Dotnettutorials\Csharp";
            Console.WriteLine(Name);
            Console.ReadKey();
            */

            /* Literals 
            Console.WriteLine("Integer Literals");
            Console.WriteLine("-----------------");
            int deci = 123;
            int octa = 03435;
            int hexa = 0x3233;
            int bin = 0b11010;

            Console.WriteLine("Decimal " + deci);
            Console.WriteLine("Octal " + octa);
            Console.WriteLine("HexaDecimal " + hexa);
            Console.WriteLine("Binary " + bin);

            Console.WriteLine("---------");

            Console.WriteLine("Double / Floating Literals");

            double d1 = 34.595656;
            double d2 = 4323e-5;
            double d3 = 849f;

            Console.WriteLine("double1 " + d1);
            Console.WriteLine("double2 " + d2);
            Console.WriteLine("double3 " + d3);

            Console.ReadKey();
            */
        }
    }
         
}

