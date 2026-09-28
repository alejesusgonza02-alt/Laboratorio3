using System;

namespace JuegoDeCraps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JuegoCraps juego = new JuegoCraps();

            Console.WriteLine("Juego de Craps");
            Console.WriteLine("----------------");

            juego.Jugar();

            Console.ReadKey();
        }
    }
}