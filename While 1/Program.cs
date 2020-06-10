using System;
using System.Globalization;

namespace While_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            double num1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
           
            while (num1 >= 0.0)
            {
                double raiz = Math.Sqrt(num1);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite Outro número");
                num1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Número negativo!");
            
        }
    }
}
