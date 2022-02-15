using System;

namespace Exercicio4.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] n = new double[5];
            double total = 0;
            int positivo = 0, negativo = 0;

            for (int i = 0; i < n.Length; i++)
            {

                Console.WriteLine("Insira o valor " + i);
                n[i] = Convert.ToDouble(Console.ReadLine());

            }

            for (int i = 0; i < n.Length; i++)
            {

                total += n[i];

                if(n[i] < 0)
                {

                    negativo++;

                }
                else
                {

                    positivo++;

                }

            }

            Console.WriteLine("A media aritimetica dos valores e: " + total/5);
            Console.WriteLine("Voce inseriu " + positivo + " valores positivos e " + negativo
                + " valores negativos");

            Console.ReadKey();
            
            
        }
    }
}
