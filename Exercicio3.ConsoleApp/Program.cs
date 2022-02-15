using System;

namespace Exercicio3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            int hora = Convert.ToInt32(dateTime.Hour);
            Console.WriteLine(hora);
            if(hora >= 6 && hora < 12)
            {

                Console.WriteLine("Bom dia!");

            }else if(hora >= 12 && hora < 18)
            {

                Console.WriteLine("Boa tarde!");

            }
            else
            {

                Console.WriteLine("Boa noite!");

            }
            Console.ReadKey();
        }
    }
}
