using System;

namespace JuegoDeCraps
{
    internal class JuegoCraps
    {
        private Random random;
        private EstadoJuego estado;
        private int punto;

        public JuegoCraps()
        {
            random = new Random();
            estado = EstadoJuego.NoIniciado;
            punto = 0;
        }

        public int TirarDado()
        {
            return random.Next(1, 7);
        }

        public int TirarDados(out int dado1, out int dado2)
        {
            dado1 = TirarDado();
            dado2 = TirarDado();

            return dado1 + dado2;
        }

        public void Jugar()
        {
            int dado1;
            int dado2;

            int suma = TirarDados(out dado1, out dado2);

            Console.WriteLine("El jugador lanzo: " + dado1 + " + " + dado2 + " = " + suma);

            if (suma == 7 || suma == 11)
            {
                estado = EstadoJuego.Ganado;
                Console.WriteLine("¡El jugador gana!");
            }
            else if (suma == 2 || suma == 3 || suma == 12)
            {
                estado = EstadoJuego.Perdido;
                Console.WriteLine("¡El jugador pierde!");
            }
            else
            {
                punto = suma;
                estado = EstadoJuego.Jugando;

                Console.WriteLine("El punto es: " + punto);

                while (estado == EstadoJuego.Jugando)
                {
                    suma = TirarDados(out dado1, out dado2);

                    Console.WriteLine("El jugador lanzo: " + dado1 + " + " + dado2 + " = " + suma);

                    if (suma == punto)
                    {
                        estado = EstadoJuego.Ganado;
                        Console.WriteLine("¡El jugador gana!");
                    }
                    else if (suma == 7)
                    {
                        estado = EstadoJuego.Perdido;
                        Console.WriteLine("¡El jugador pierde!");
                    }
                }
            }
        }
    }
}