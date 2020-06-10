using System;

namespace Ex_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a Senha");
            int s = int.Parse(Console.ReadLine());

            double Senha1 = Senha(s);

            Console.WriteLine($"{Senha1}");
        }

        static int Senha(int senha)
        {
            while (senha != 2002)
            {
                Console.WriteLine("A senha informada é incorreta, digite novamente");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Senha Correta!");
            return senha;
        }
    }
}
