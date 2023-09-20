using System;
namespace Uppgift2_2
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Hur långt hoppade Elin i meter?");
            double elin = double.Parse(Console.ReadLine());
            Console.WriteLine("Hur långt hoppade Alma i meter?");
            double alma = double.Parse(Console.ReadLine());
            double skillnad = elin - alma;
            Console.WriteLine("Elin hoppade " + skillnad + " meter längre.");
            Console.ReadKey();
        }
    }
}