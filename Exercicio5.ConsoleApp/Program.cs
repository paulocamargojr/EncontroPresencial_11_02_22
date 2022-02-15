using System;

namespace Exercicio5.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pontosJogador1 = 0, pontosJogador2 = 0, totalJogador1 = 0, totalJogador2 = 0;
            Random randNum = new Random();


            Console.WriteLine("Insira o nome do primeiro jogador: ");
            string jogador1 = Console.ReadLine();

            Console.WriteLine("Insira o nome do segundo jogador: ");
            string jogador2 = Console.ReadLine();

            for (int i = 0; i < 3; i++)
            {

                pontosJogador1 = randNum.Next(6);
                totalJogador1 += pontosJogador1;
                pontosJogador2 = randNum.Next(6);
                totalJogador2 += pontosJogador2;

                Console.WriteLine(jogador1 + " : " + pontosJogador1);
                Console.WriteLine(jogador2 + " : " + pontosJogador2);

                if(pontosJogador1 > pontosJogador2)
                {

                    Console.WriteLine(jogador1 + " venceu essa rodada!");

                }else if(pontosJogador1 < pontosJogador2)
                {

                    Console.WriteLine(jogador2 + " venceu essa rodada!");

                }
                else
                {

                    Console.WriteLine("Empatou!");

                }

            }

            if(totalJogador1 > totalJogador2)
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n");
                Console.WriteLine(jogador1 + " Venceu a partida!");

            }else if(totalJogador1 < totalJogador2)
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n");
                Console.WriteLine(jogador2 + " Venceu a partida!");

            }
            else
            {

                Console.WriteLine("Empate definitivo, tentem novamente!");

            }

            Console.ReadKey();
        }
    }
}
