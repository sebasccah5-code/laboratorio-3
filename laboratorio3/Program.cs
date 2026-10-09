// laboratorio 3
using System;

class Program
{
    static void Main()
    {
        // etapa 1 ARREGLOS UNIDIMENSIONALES
        Console.WriteLine("ETAPA 1");
        int[] numeros = { 15, 42, 8, 23, 4, 10, 99, 7, 31, 5 };

        Console.WriteLine("elementos del arreglo:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine(numeros[i]);
        }

        numeros[2] = LeerEntero("Ingresa un nuevo numero para el tercer elemento: ");
        Console.WriteLine("Arreglo Actualizado. El tercer elemento es: " + numeros[2]);

        int buscar = LeerEntero("¿Que numero quieres buscar?: ");
        bool existe = false;

        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == buscar)
            {
                existe = true;
                break;
            }
        }

        if (existe) Console.WriteLine("El numero si existe en el arreglo.");
        else Console.WriteLine("El numero no esta en el arreglo.");
    }

    static int LeerEntero(string mensaje)
    {
        while (true)
        {
            Console.Write(mensaje);
            string? entrada = Console.ReadLine();

            if (entrada is null)
            {
                throw new InvalidOperationException("No se recibió una entrada.");
            }

            if (int.TryParse(entrada, out int numero))
            {
                return numero;
            }

            Console.WriteLine("Entrada no válida. Ingresa un número entero.");
        }
    }
}
