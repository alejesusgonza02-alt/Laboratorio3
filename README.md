Este repositorio contiene diferentes proyectos desarrollados en C# utilizando Visual Studio y .NET, como parte de las actividades de programación orientada a objetos.

Los proyectos incluyen una aplicación de consola basada en el juego de Craps y dos aplicaciones desarrolladas con Windows Forms.

1. Juego de Craps

Este proyecto consiste en la creación de un juego de Craps desarrollado en C# utilizando Visual Studio y una aplicación de consola.

El programa simula el lanzamiento de dos dados y utiliza las reglas básicas del juego de Craps para determinar si el jugador gana, pierde o debe continuar jugando.

Funcionamiento

Al iniciar el juego, el jugador realiza una primera tirada con dos dados.

Si la suma es 7 u 11, el jugador gana.
Si la suma es 2, 3 o 12, el jugador pierde.
Si la suma es 4, 5, 6, 8, 9 o 10, esa suma se convierte en el punto.

Cuando se establece un punto, el jugador continúa lanzando los dados:

Si vuelve a salir el mismo punto, el jugador gana.
Si sale un 7, el jugador pierde.
Si sale cualquier otro número, continúa lanzando hasta que ocurra una de las dos condiciones anteriores.
Estructura del proyecto

El proyecto está organizado utilizando diferentes clases:

Program.cs

Contiene el método principal Main, desde donde se crea el objeto del juego y se inicia la partida.

JuegoCraps.cs

Contiene la lógica principal del juego. Se encarga de:

Generar los lanzamientos de los dados.
Sumar los resultados.
Determinar el resultado de la primera tirada.
Establecer el punto.
Continuar las tiradas hasta que el jugador gane o pierda.
EstadoJuego.cs

Contiene un enum que representa los diferentes estados posibles del juego:

NoIniciado
Jugando
Ganado
Perdido
Ejemplo de ejecución
Juego de Craps
----------------
El jugador lanzo: 5 + 4 = 9
El punto es: 9
El jugador lanzo: 2 + 3 = 5
El jugador lanzo: 4 + 2 = 6
El jugador lanzo: 5 + 4 = 9
¡El jugador gana!
2. Aplicación MDI

Este proyecto consiste en una aplicación desarrollada en C# utilizando Windows Forms, aplicando el concepto de MDI (Multiple Document Interface).

El programa utiliza un formulario principal que funciona como contenedor para las diferentes ventanas de la aplicación.

Funcionamiento

Al ejecutar el programa se muestra una ventana principal que contiene las diferentes opciones de la aplicación.

Las ventanas secundarias se muestran dentro de la ventana principal, permitiendo trabajar con varias funcionalidades sin abrir aplicaciones independientes.

Características
Uso de Windows Forms.
Implementación de una ventana principal MDI.
Uso de formularios secundarios.
Organización de las ventanas dentro del formulario principal.
Uso de controles y eventos para interactuar con el usuario.
Manejo de ventanas mediante una interfaz gráfica.
Estructura del proyecto
Form1.cs

Contiene el formulario principal de la aplicación y funciona como el contenedor MDI.

Desde este formulario se pueden abrir y controlar las diferentes ventanas secundarias.

Formularios secundarios

Contienen las diferentes funcionalidades de la aplicación y se ejecutan dentro del formulario principal.

3. Aplicación de Validaciones y Registro

Este proyecto consiste en una aplicación desarrollada en C# utilizando Windows Forms, enfocada en el ingreso y validación de información de una persona.

El programa permite introducir los datos mediante un formulario y realiza diferentes comprobaciones antes de permitir el registro.

Funcionamiento

El usuario debe completar los datos solicitados en el formulario.

Antes de realizar el registro, el programa verifica que la información ingresada cumpla con las condiciones establecidas.

Una de las validaciones principales es comprobar que la persona tenga 18 años o más para poder registrarse.

Validaciones implementadas
Verificación de campos obligatorios.
Validación de los datos ingresados.
Comprobación de la edad del usuario.
Verificación de que la persona tenga al menos 18 años.
Mostrar mensajes de error cuando los datos no son válidos.
Impedir el registro cuando no se cumplen las condiciones establecidas.
Tecnologías utilizadas
C#
.NET
Windows Forms
Visual Studio
Objetivo de los proyectos

El objetivo de estos proyectos es poner en práctica diferentes conceptos de programación orientada a objetos y desarrollo de aplicaciones en C#, incluyendo:

Creación y utilización de clases.
Uso de enumeraciones (enum).
Manejo de métodos y objetos.
Implementación de lógica de programación.
Uso de Windows Forms.
Manejo de eventos.
Creación de interfaces gráficas.
Validación de datos ingresados por el usuario.
Uso de aplicaciones de consola.
Tecnologías utilizadas
C#
.NET
Windows Forms
Visual Studio
•	Visual Studio
•	Aplicación de consola
Objetivo
El objetivo del proyecto es practicar conceptos de programación orientada a objetos, uso de clases, enumeraciones, métodos, estructuras de control y generación de números aleatorios en C#.
