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

        // etapa 2 ARREGLOS BIDIMENSIONALES

        Console.WriteLine("ETAPA 2");
        int[,] matriz = new int[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Ingresa numero para fila {i}, columna {j}: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nAsi quedo la matriz:");
        int suma = 0;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matriz[i, j] + "\t");
                suma += matriz[i, j];
            }
            Console.WriteLine();
        }
        Console.WriteLine("La suma de todos los numeros es: " + suma);
        
    
    