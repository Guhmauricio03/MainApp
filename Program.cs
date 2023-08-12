using System;
using System.Security.Cryptography;
using System.Threading;

namespace MainApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("======================================");
            Console.WriteLine("S = Segundo" + "\nM = Minuto" +
                              "\n0 = Sair" + "\nQuanto tempo deseja contar?");
            Console.WriteLine("\n======================================");
            string entrada = Console.ReadLine().ToLower();
            char formato = char.Parse(entrada.Substring(entrada.Length-1, 1));
            int tempoUsuario = int.Parse(entrada.Substring(0, entrada.Length - 1));

            int multiplicador = 1;

            if (formato == 'm')
            
                multiplicador = 60;
            
            if (tempoUsuario == 0)
            
                System.Environment.Exit(0);
            
            start(tempoUsuario * multiplicador);
            
        }
        static void start(int tempo, int tempoAtual = 0)
        {
            while (tempoAtual != tempo)
            {
                Console.Clear();
                tempoAtual++;
                Console.WriteLine(tempoAtual);
                Thread.Sleep(1000);
            }
            
            Console.Clear();
            Console.WriteLine("Cronometro Finalizado!");
            Thread.Sleep(2500);
            Menu();
        }
    }
}