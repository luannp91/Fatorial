using System;

namespace FatorialRecursivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Inicio:
            Console.Clear();

            Console.Write("Calcular o fatorial de qual número? ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("O fatorial de " + num + " é " + Fatorial(num));

            System.Console.Write("\n\nContinuar (s / n) ? ");
            string opcao = Console.ReadLine();

            if (opcao == "s" || opcao == "S")
            {
                goto Inicio;
            }
        }

        static int Fatorial(int num)
        {
            if (num <= 0)
            {
                return 1;
            }

            return num * Fatorial(num - 1);
        }
    }
}
