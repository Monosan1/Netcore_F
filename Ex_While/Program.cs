using System;

/*namespace Ex_While
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
}*/

#region EX2
/*namespace Ex_While2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois valores separados por um ' '");
            string[] var = Console.ReadLine().Split(' ');

            int x = int.Parse(var[0]);
            int y = int.Parse(var[1]);

            double Coord = Coordenadas(x, y);

            Console.WriteLine(Coord);
        }

        static int Coordenadas(int x, int y)
        {
            while (x != 0 && y != 0)
            {

                if (x > 0 && y > 0)
                {
                    Console.WriteLine("A cordenada pertence ao 1º Quadrante");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Cordenada 2º Quadrante");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Pertence ao 3º Quadrante");
                }
                else
                {
                    Console.WriteLine("Pertence ao 4º Quadrante");
                }
                Console.WriteLine("Digite novas coordenadas");
                string[] coord = Console.ReadLine().Split(' ');
                x = int.Parse(coord[0]);
                y = int.Parse(coord[1]);
            }
            Console.WriteLine("Coordenada errada");
            return 0;
        }
    }

}*/
#endregion

namespace While3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alcool 1 - Gasolina 2 - 3 Diessel - 4 Fim");
            Console.WriteLine("Digite um número correspondente a sua necessidade");
            int comb = int.Parse(Console.ReadLine());

            double Combs = combustivel(comb);

            Console.WriteLine(Combs);
        }

        static int combustivel(int comb)
        {
            int gasolina = 0;
            int alcool = 0;
            int diessel = 0;

            while (comb != 4)
            {
                if (comb == 1)
                {
                    gasolina = gasolina + 1;
                }
                else if (comb == 2)
                {
                    alcool = alcool + 1;
                }
                else if (comb == 3)
                {
                    diessel = diessel + 1;
                }
                
               
                    Console.WriteLine("Digite um número correto");
                    comb = int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diessel}");


            return 0;
        }
    }

}

