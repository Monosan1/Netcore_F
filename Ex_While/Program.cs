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
namespace Ex_While2
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
                else if (x< 0 && y > 0)
                {
                    Console.WriteLine("Cordenada 2º Quadrante");
                }
                else if (x < 0 && y< 0)
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

}
#endregion