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

        // etapa 3 LISTAS DINAMICAS

        Console.WriteLine("ETAPA 3");
        List<int> listaDinamica = new List<int> {10, 20, 30};
        int opcion = 0;

        while (opcion != 5)
        {
            Console.WriteLine(\n1. insertar al final \n2. Eliminar por posicion \n3. Buscar valor \n4. Mostrar lista \n5. Salir");
            Console.Write("Elige una opcion: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Console.Write("Ingresa el numero a insertar: ");
                listaDinamica.Add(int.Parse(Console.ReadLine()));
                Console.WriteLine("Elemento agregado.");
            }
            else if (opcion == 2)
            {
                Console.Write($"Ingresa la posicion del elemento a eliminar (0 a {listaDinamica.Count - 1}): ");
                listaDinamica.RemoveAt(int.Parse(Console.ReadLine()));
                Console.WriteLine("Elemento eliminado.");
            }
            else if (opcion == 3)
            {
                Console.Write("Ingresa el valor a buscar: ");
                int posicion = listaDinamica.IndexOf(int.Parse(Console.ReadLine()));

                if (posicion != -1)
                    Console.WriteLine($"El valor se encuentra en la posicion: {posicion}");
                else
                    Console.WriteLine("El valor no existe.");
            }
            else if (opcion == 4)
            {
                Console.WriteLine("lista actual:");
                foreach (int item in listaDinamica) Console.WriteLine(item);
                Console.WriteLine();
            }

        }

        // etapa 4 ALGORITMOS DE ORDENAMIENTO

        


         

    
    