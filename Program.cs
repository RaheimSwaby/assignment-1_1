using System.Net.Sockets;

namespace assignment_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how tall are you");
            string myHeight = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("how old are you");
            double age = Convert.ToDouble( Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("What is your name?");
            string fName = Console.ReadLine();
            Console.WriteLine() ;

            Console.WriteLine("What's your address?");
            string addy = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("my name is " + fName + " I am " + myHeight + " Feet tall " + "and I am " + age + " years old");
            Console.WriteLine("I live at " + addy);

           
            float num2 = 2.25f;
            Console.WriteLine(num2);
            Console.WriteLine();
            
            decimal num3 =1.01m ;
            Console.WriteLine(num3);
            Console.WriteLine();
            
            double num4 = 2.99d;
            Console.WriteLine(num4);
            Console.WriteLine();    

            Console.WriteLine(1 + 1);
            Console.WriteLine();
            Console.WriteLine(8 / 2);
        }
    }
}
