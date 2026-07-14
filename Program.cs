using System.Numerics;
using System.Text;
using System.Xml.Serialization;
//test
namespace A2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true; ;
            while (running)
            {
                string choice = PromptUser();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter first integer: ");
                        int i1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter second integer: ");
                        int i2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Result: {Maths.Add(i1, i2)}");
                        break;
                    case "2":
                        Console.Write("Enter first decimal: ");
                        decimal d1 = Convert.ToDecimal(Console.ReadLine());
                        Console.Write("Enter second decimal: ");
                        decimal d2 = Convert.ToDecimal(Console.ReadLine());
                        Console.Write("Enter third decimal: ");
                        decimal d3 = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine($"Reuslt: {Maths.Add(d1, d2, d3)}");
                        break;
                    case "3":
                        Console.Write("Enter first float: ");
                        float f1 = Convert.ToSingle(Console.ReadLine());
                        Console.Write("Enter second float: ");
                        float f2 = Convert.ToSingle(Console.ReadLine());
                        Console.WriteLine($"Result: {Maths.Multiply(f1, f2)}");
                        break;
                    case "4":
                        Console.Write("Enter first float: ");
                        float f1a = Convert.ToSingle(Console.ReadLine());
                        Console.Write("Enter second float: ");
                        float f2a = Convert.ToSingle(Console.ReadLine());
                        Console.Write("Enter third float: ");
                        float f3a = Convert.ToSingle(Console.ReadLine());

                        Console.WriteLine($"Result: {Maths.Multiply(f1a, f2a, f3a)}");
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid. Try Again.");
                        break;

                }


            }
            static string PromptUser()
            {
                Console.WriteLine("Maths Calculator");
                Console.WriteLine("1. Add two integers");
                Console.WriteLine("2. Add three decimals");
                Console.WriteLine("3. Multiply two floats");
                Console.WriteLine("4. Multiply three floats");
                Console.WriteLine("5. Exit");
                Console.Write("\nEnter your choice (1-5): ");
                string choice = Console.ReadLine();
                return choice;
            }
        }

        class Maths
        {
            public static int Add(int num1, int num2)
            {
                return num1 + num2;
            }

            public static decimal Add(decimal num1, decimal num2, decimal num3)
            {
                return num1 + num2 + num3;
            }

            public static float Multiply(float num1, float num2)
            {
                return num1 * num2;
            }

            public static float Multiply(float num1, float num2, float num3)
            {
                return num1 * num2 * num3;
            }
        }

    }
}
