using System;  // Espacio para usar la consola y otras funcionalidades básicas.

class Program  // Clase
{
    static void Main()   // Método principal para ejecutar el programa
    {
        // Alvarez_David_Ejercicio_1      3ero TSDS

        // Ejercicio 1

        // 1)   Imprimir los números pares que hay dentro de los 100 primeros números enteros. No utilizar la estructura de control "if" para resolver este ejercicio
        
        Console.WriteLine("1) Números pares sin usar 'if'");    // Imprime mensaje del enunciado
        for (int i = 0; i <= 100; i += 2)    // Bucle 'for' que inicia en 0, se ejecuta mientras i sea <= 100, y se incrementa en 2
        {
            Console.WriteLine(i);            // Imprime el valor de i, será para ya que va incrementando de 2 en 2
        }

        // 2)   Imprimir los números pares que hay dentro de los 100 primeros números enteros

        Console.WriteLine("\n2) Números pares usando una condición 'if'");     // Imprime mensaje del enunciado
        for (int i = 0; i <= 100; i++)  // Bucle 'for' que va de 0 a 100, con incremento de 1
        {
            if (i % 2 == 0)             // Se usa if para verificar si el residuo de dividir i entre 2 es 0, si es así es par
            {
                Console.WriteLine(i);   // Si la condición es verdadera, imprime el número
            }
        }

        /*  3)	Imprimir los números del 1 al 50:
                a.	Para números divisibles por 3, imprima "Fizz".
                b.	Para números divisibles por 5, imprima "Buzz".
                c.	Para números divisibles por 3 y 5, imprime "FizzBuzz".
                d.	En cualquier otro caso, imprima el número. 
            */

        Console.WriteLine("\n3) Números del 1 al 50, usando FizzBuzz, Fizz y Buzz");    // Imprime mensaje del enunciado
        for (int i = 1; i <= 50; i++)               // Bucle 'for' que recorre los números del 1 al 50
        {
            if (i % 3 == 0 && i % 5 == 0) // Verifica si el número es divisible entre 3 y 5
                Console.WriteLine("FizzBuzz"); // Imprime 'FizzBuzz' si cumple la condición
            else if (i % 3 == 0) // Verifica si el número es divisible entre 3
                Console.WriteLine("Fizz"); // Imprime 'Fizz' si cumple la condición
            else if (i % 5 == 0) // Verifica si el número es divisible entre 5
                Console.WriteLine("Buzz"); // Imprime 'Buzz' si cumple la condición
            else
                Console.WriteLine(i); // Si no cumple alguna condición va a imprimir el número
        }

        // 4)   Imprime los números del 1 al 10 utilizando un bucle "while"

        Console.WriteLine("\n4) Números del 1 al 10 con'while'");  // Imprime mensaje del enunciado
        int j = 1; // Inicializa la variable j en 1
        while (j <= 10) // Mientras j sea menor o igual a 10, ejecuta el bucle
        {
            Console.WriteLine(j); // Imprime el valor actual de j
            j++; // Incrementa el valor de j en 1
        }

        // 5)	Calcula la suma de los primeros 100 números enteros utilizando un bucle "while"

        Console.WriteLine("\n5) Suma de los primeros 100 números con 'while'");
        int sum = 0;         // Inicializa suma en 0
        int k = 1;           // Inicializa k con el valor 1.
        while (k <= 100)    // Mientras k sea menor o igual a 100, ejecuta el bucle
        {
            sum += k;     // Suma el valor actual de k a la variable sum que acumula los numeros para la suma
            k++;          // Incrementa el valor de k en 1 después de cada iteración
        }
        Console.WriteLine("La suma de los 100 primeros números es: " + sum); // Imprime el resultado de la suma

        // 6)	Imprimir los números pares que hay dentro de los 100 primeros números enteros utilizando un bucle " while "

        Console.WriteLine("\n6) Números pares con 'while'");
        int l = 0;          // Inicializa la variable l en 0.
        while (l <= 100)    // Mientras l sea menor o igual a 100, ejecuta el bucle
        {
            Console.WriteLine(l);    // Imprime el valor actual de l
            l += 2;                  // Incrementa el valor de l en 2 después de cada iteración
        }
    }
}
