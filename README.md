Este proyecto consiste en la creación de un juego de Craps desarrollado en C# utilizando Visual Studio y una aplicación de consola.
El programa simula el lanzamiento de dos dados y utiliza las reglas básicas del juego de Craps para determinar si el jugador gana, pierde o debe continuar jugando.
Funcionamiento
Al iniciar el juego, el jugador realiza una primera tirada con dos dados.
•	Si la suma es 7 u 11, el jugador gana.
•	Si la suma es 2, 3 o 12, el jugador pierde.
•	Si la suma es 4, 5, 6, 8, 9 o 10, esa suma se convierte en el punto.
Cuando se establece un punto, el jugador continúa lanzando los dados:
•	Si vuelve a salir el mismo punto, el jugador gana.
•	Si sale un 7, el jugador pierde.
•	Si sale cualquier otro número, continúa lanzando hasta que ocurra una de las dos condiciones anteriores.
Estructura del proyecto
El proyecto está organizado utilizando diferentes clases:
Program.cs
Contiene el método principal Main, desde donde se crea el objeto del juego y se inicia la partida.
JuegoCraps.cs
Contiene la lógica principal del juego. Se encarga de:
•	Generar los lanzamientos de los dados.
•	Sumar los resultados.
•	Determinar el resultado de la primera tirada.
•	Establecer el punto.
•	Continuar las tiradas hasta que el jugador gane o pierda.
EstadoJuego.cs
Contiene un enum que representa los diferentes estados posibles del juego:
•	NoIniciado
•	Jugando
•	Ganado
•	Perdido
Ejemplo de ejecución
Juego de Craps
----------------
El jugador lanzo: 5 + 4 = 9
El punto es: 9
El jugador lanzo: 2 + 3 = 5
El jugador lanzo: 4 + 2 = 6
El jugador lanzo: 5 + 4 = 9
¡El jugador gana!
Tecnologías utilizadas
•	C#
•	.NET
•	Visual Studio
•	Aplicación de consola
Objetivo
El objetivo del proyecto es practicar conceptos de programación orientada a objetos, uso de clases, enumeraciones, métodos, estructuras de control y generación de números aleatorios en C#.
