using System;

namespace EncontroPresencial_11_02_22.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a largura:");
            int l = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira a largura:");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {

                for (int j = 0; j < l; j++)
                {

                    Console.Write("*");

                }

                Console.WriteLine("\n");

            }

            Console.ReadKey();
        }
    }
}
