using System;  // Espacio para usar la consola y otras funcionalidades básicas.

class Program  // Método principal para ejecutar el programa
{
    static void Main()
    {
        // Ejercicio 1.1: Imprimir los números pares dentro de los 100 primeros números sin usar "if".
        Console.WriteLine("Ejercicio 1.1: Números pares sin usar 'if'");
        for (int i = 0; i <= 100; i += 2)
        {
            Console.WriteLine(i);
        }

        // Ejercicio 1.2: Imprimir los números pares dentro de los 100 primeros números.
        Console.WriteLine("\nEjercicio 1.2: Números pares usando 'if'");
        for (int i = 0; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }

        // Ejercicio 1.3: Imprimir números del 1 al 50 con FizzBuzz.
        Console.WriteLine("\nEjercicio 1.3: FizzBuzz del 1 al 50");
        for (int i = 1; i <= 50; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                Console.WriteLine("FizzBuzz");
            else if (i % 3 == 0)
                Console.WriteLine("Fizz");
            else if (i % 5 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(i);
        }

        // Ejercicio 1.4: Imprimir los números del 1 al 10 usando un bucle "while".
        Console.WriteLine("\nEjercicio 1.4: Números del 1 al 10 con 'while'");
        int j = 1;
        while (j <= 10)
        {
            Console.WriteLine(j);
            j++;
        }

        // Ejercicio 1.5: Calcular la suma de los primeros 100 números enteros usando "while".
        Console.WriteLine("\nEjercicio 1.5: Suma de los primeros 100 números con 'while'");
        int sum = 0;
        int k = 1;
        while (k <= 100)
        {
            sum += k;
            k++;
        }
        Console.WriteLine("La suma es: " + sum);

        // Ejercicio 1.6: Imprimir los números pares dentro de los 100 primeros números usando "while".
        Console.WriteLine("\nEjercicio 1.6: Números pares con 'while'");
        int l = 0;
        while (l <= 100)
        {
            Console.WriteLine(l);
            l += 2; // Incrementamos de 2 en 2 para obtener solo números pares.
        }
    }
}
