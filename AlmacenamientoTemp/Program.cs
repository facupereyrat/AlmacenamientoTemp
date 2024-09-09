using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Crear una cola para almacenar las cadenas
        Queue<string> cola = new Queue<string>();

        while (true)
        {
            // Pedir al usuario que introduzca una cadena
            Console.Write("Introduce una cadena (deja vacío para terminar): ");
            string entrada = Console.ReadLine();

            // Verificar si la cadena es vacía
            if (string.IsNullOrEmpty(entrada))
            {
                break; // Salir del bucle si la entrada está vacía
            }

            // Agregar la cadena a la cola
            cola.Enqueue(entrada);
        }

        // Mostrar todas las cadenas almacenadas en la cola
        Console.WriteLine("Cadenas introducidas:");

        while (cola.Count > 0)
        {
            string cadena = cola.Dequeue();
            Console.WriteLine(cadena);
        }
    }
}
