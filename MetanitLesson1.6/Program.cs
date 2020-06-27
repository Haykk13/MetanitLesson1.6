using System;

namespace MetanitLesson1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the operation number: 1. Addition 2. Subtraction 3. Multiplication: ");
            int operation = int.Parse(Console.ReadLine());
            
            switch (operation)
            {
                case 1:
                    Console.WriteLine("Addition"); 
                    break;
                case 2:
                    Console.WriteLine("Subtraction");
                    break;
                case 3:
                    Console.WriteLine("Multiplication");
                    break;
                default:
                    Console.WriteLine("Operation is undefined");
                    break;
            }
            Console.ReadLine();
        }
    }
}
