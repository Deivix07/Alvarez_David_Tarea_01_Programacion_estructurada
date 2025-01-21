using System;

class Program
    {static void Main() 
    {
        do  // El bucle do-while mantiene el programa funcionando hasta que el usuario decida salir
        {
            Console.Clear(); // Limpiamos la pantalla

            // Mostramos el menú con los ejercicios
            Console.WriteLine("----- MENÚ PRINCIPAL -----");
            Console.WriteLine("1. Evaluar si un número es positivo, negativo o cero");
            Console.WriteLine("2. Evaluar una calificación");
            Console.WriteLine("3. Determinar el rango de un número");
            Console.WriteLine("4. Mostrar el día de la semana");
            Console.WriteLine("5. Calculadora básica");
            Console.WriteLine("0. Salir");
            Console.WriteLine("--------------------------");

            Console.Write("Seleccione una opción: ");  // Intrucción para que ingrese una opción

            try
            {
                int opcion = int.Parse(Console.ReadLine()); // // Convertir la entrada del usuario a un número entero y guardar la opción

                // Dependiendo de la opción ingresada, ejecutamos el método correspondiente
                switch (opcion)
                {
                    case 1:
                        Evaluar_num();
                        break;
                    case 2:
                        Evaluar_calif();
                        break;
                    case 3:
                        Determinar_rango();
                        break;
                    case 4:
                        Mostrar_dia_semana();
                        break;
                    case 5:
                        Calculadora();
                        break;
                    case 0:
                        Console.WriteLine("¡Gracias por usar el programa!");
                        return; // El programa termina y se sale del bucle
                    
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");  // Si se ingresa una opción que no está se muestra un error
                        break;
                }
            }
            catch (FormatException)      // Si ocurre un error al ingresar un numero
            {
                // se captura la excepción y se muestra un mensaje de error al usuario
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
            }
            Console.WriteLine("\nPresione una tecla para volver al menú...");   // Mensaje de una instrucción
            Console.ReadKey(); // Presionar una tecla antes de continuar

        } while (true); // El bucle seguira ejecutándose hasta que el usuaria eliga 0 para salir
    }

    // 1)   Escribe un programa que evalúe si un número ingresado por el usuario es positivo, negativo o cero.
    static void Evaluar_num()
    {
        while (true)     // Bucle infinito que se ejecuta hasta que el usuario ingrese una entrada válida
        {
            try
            {
                Console.Write("Ingrese un número: ");  // Pedimos al usuario que ingrese un número
                int numero = int.Parse(Console.ReadLine());   // Convertir la entrada del usuario a un entero
                if (numero > 0)         // Condición si el número ingresado es mayor que 0
                    Console.WriteLine("El número es positivo.");    // Si cumple la condición es positivo
                else if (numero < 0)    // Si el número ingresado es menor que 0
                    Console.WriteLine("El número es negativo.");    // Si cumple la condición es negativo
                else                    // Si el número es 0, mostramos que el número es cero
                    Console.WriteLine("El número es cero.");
                break; // Salimos del bucle ya que la entrada fue válida
            }
            catch (FormatException)    // Si ocurre un error en la entrada
            {
                // Mensaje indicando que la entrada no es válida y pedimos que lo intente nuevamente
                Console.WriteLine("Entrada no válida. Intente nuevamente.");
            }
        }
    }


    /*  2)   Crea un programa que solicita al usuario ingresar una calificación y luego muestre un mensaje según la calificación ingresada
    (por ejemplo: "Aprobado" si la calificación es mayor o igual a 60, "Reprobado" si es menor a 60)
    */

    static void Evaluar_calif()
    {
        while (true) // Bucle que continuará hasta que se ingrese una calificación válida
        {
            try
            {
                Console.Write("Ingrese una calificación (0-100): ");    // Instruccion para el usuario
                int calificacion = int.Parse(Console.ReadLine());       // Convertir la entrada del usuario a un entero

                if (calificacion >= 0 && calificacion <= 100)    // Verificamos si la calificación está en el rango válido (0-100)
                {
                    if (calificacion >= 60)               // Condición si la calificación es mayor a 60
                        Console.WriteLine("Aprobado.");   // Si cumple la condición el estudiantes esta Aprobado
                    else
                        Console.WriteLine("Reprobado.");  // Si no cumple la condición el estudiantes esta Reprobado
                    break; // Salimos del bucle si la calificación es válida
                }
                else
                {
                    Console.WriteLine("La calificación debe estar entre 0 y 100. Intente nuevamente.");  //Si la calificación esta fuera de rango pedirá que intente nuevamente
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada no válida. Intente nuevamente.");     // Si ocurre un error en la entrada dara un mensaje de error
            }
        }
    }

    /*  3)  Desarrolla un programa que pida al usuario ingrese un número y luego determine en qué rango se encuentra
    (por ejemplo: "Menor que 10", "Entre 10 y 20", "Mayor que 20")
    */

    static void Determinar_rango()
    {
        while (true) // Bucle hasta que se ingrese un número válido
        {
            try
            {
                Console.Write("Ingrese un número: ");    // Solicita al usuario que ingrese un número
                int numero = int.Parse(Console.ReadLine()); // Convertir la entrada del usuario a un entero

                string mensaje = "El número " + numero + " es:";  // Mensaje que va a mostrar el numero ingresado

                // Lógica para los rangos

                // para "Mayor que x" (restamos 20 al número)
                mensaje += " mayor que " + (numero - 20);

                // Lpara "Entre x y x" (restamos 1 y sumamos 1)
                mensaje += ", entre " + (numero - 1) + " y " + (numero + 1);

                // para "Menor que x" (sumamos 20 al número)
                mensaje += ", menor que " + (numero + 20);

                Console.WriteLine(mensaje);  // Muestra el mensaje final
                break; // Sale del bucle si la entrada es válida
            }
            catch (FormatException)
            {
                // Si la entrada no es válida da un mensaje de error
                Console.WriteLine("Entrada no válida. Intente nuevamente.");
            }
        }
    }

    /*  4)  Desarrolla un programa que pida al usuario ingrese un número y luego determine en qué rango se encuentra
    (por ejemplo: "Menor que 10", "Entre 10 y 20", "Mayor que 20")
    */
    static void Mostrar_dia_semana()
    {
        while (true) // Bucle que continuará hasta que se ingrese un número válido
        {
            try
            {
                Console.Write("Ingrese un número del 1 al 7: ");
                int dia = int.Parse(Console.ReadLine()); // Usamos int.Parse para convertir la entrada a entero.

                // Verificamos si el número está en el rango correcto (1 a 7)
                if (dia >= 1 && dia <= 7)
                {
                    // Usamos switch para mostrar el día correspondiente
                    switch (dia)
                    {
                        case 1: Console.WriteLine("Lunes"); break;
                        case 2: Console.WriteLine("Martes"); break;
                        case 3: Console.WriteLine("Miércoles"); break;
                        case 4: Console.WriteLine("Jueves"); break;
                        case 5: Console.WriteLine("Viernes"); break;
                        case 6: Console.WriteLine("Sábado"); break;
                        case 7: Console.WriteLine("Domingo"); break;
                    }
                    break; // Sale del bucle si el número es válido
                }
                else
                {
                    // Si el número está fuera del rango, se muestra un mensaje y se vuelve a pedir
                    Console.WriteLine("Número fuera de rango. Ingrese un número del 1 al 7.");
                }
            }
            catch (FormatException)
            {
                // Si ocurre un error de formato (por ejemplo, si el usuario ingresa texto en lugar de un número), mostramos un mensaje
                Console.WriteLine("Entrada no válida. Intente nuevamente.");
            }
        }
    }


    static void Calculadora()
    {
        try
        {
            Console.Write("Ingrese el primer número: ");
            int num1 = int.Parse(Console.ReadLine()); // Usamos int.Parse para convertir la entrada a entero.

            Console.Write("Ingrese el segundo número: ");
            int num2 = int.Parse(Console.ReadLine()); // Usamos int.Parse para convertir la entrada a entero.

            Console.Write("Ingrese la operación (+, -, *, /): ");
            char operacion = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (operacion)
            {
                case '+': Console.WriteLine($"Resultado: {num1 + num2}"); break;
                case '-': Console.WriteLine($"Resultado: {num1 - num2}"); break;
                case '*': Console.WriteLine($"Resultado: {num1 * num2}"); break;
                case '/':
                    if (num2 != 0)
                        Console.WriteLine($"Resultado: {num1 / num2}");
                    else
                        Console.WriteLine("Error: No se puede dividir entre cero.");
                    break;
                default: Console.WriteLine("Operación no válida."); break;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Entrada no válida. Intente nuevamente.");
        }
    }
}
