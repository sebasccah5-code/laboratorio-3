// laboratorio 3

using System;
using System.Collections.Generic;

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

        Console.WriteLine("\n ETAPA 2");
        int[,] matriz = new int[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matriz[i, j] = LeerEntero($"Ingresa numero para fila {i}, columna {j}: ");
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

        Console.WriteLine("\n ETAPA 3");
        List<int> listaDinamica = new List<int> {10, 20, 30};
        int opcion = 0;

        while (opcion != 5)
        {
            Console.WriteLine("\n1. Insertar al final\n2. Eliminar por posicion\n3. Buscar valor\n4. Mostrar lista\n5. Salir");
            opcion = LeerEntero("Elige una opcion: ");

            if (opcion == 1)
            {
                listaDinamica.Add(LeerEntero("Ingresa el numero a insertar: "));
                Console.WriteLine("Elemento agregado.");
            }
            else if (opcion == 2)
            {
                if (listaDinamica.Count == 0)
                {
                    Console.WriteLine("No hay elementos para eliminar.");
                }
                else
                {
                    int posicionEliminar = LeerEntero($"Ingresa la posicion del elemento a eliminar (0 a {listaDinamica.Count - 1}): ");
                    if (posicionEliminar >= 0 && posicionEliminar < listaDinamica.Count)
                    {
                        listaDinamica.RemoveAt(posicionEliminar);
                        Console.WriteLine("Elemento eliminado.");
                    }
                    else
                    {
                        Console.WriteLine("La posicion no es valida.");
                    }
                }
            }
            else if (opcion == 3)
            {
                int valor = LeerEntero("Ingresa el valor a buscar: ");
                int posicion = listaDinamica.IndexOf(valor);

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
            else if (opcion != 5)
            {
                Console.WriteLine("Opcion no valida. Elige un numero del 1 al 5.");
            }
        }

        // etapa 4 ALGORITMOS DE ORDENAMIENTO

        Console.WriteLine("\n ETAPA 4");
        int[] arregloDesordenado = { 64, 34, 25, 12, 22, 11,90 };
        int[] arregloBurbuja = (int[])arregloDesordenado.Clone();
        int[] arregloSeleccion = (int[])arregloDesordenado.Clone();

        Console.WriteLine("Arreglo original:");
        foreach (int num in arregloDesordenado) Console.Write(num + " ");
        Console.WriteLine();

        // ordenamiento burbuja

        for (int i = 0; i < arregloBurbuja.Length - 1; i++)
        {
            for (int j = 0; j < arregloBurbuja.Length - i - 1; j++)
            {
                if (arregloBurbuja[j] > arregloBurbuja[j + 1])
                {
                    int temp = arregloBurbuja[j];
                    arregloBurbuja[j] = arregloBurbuja[j + 1];
                    arregloBurbuja[j + 1] = temp;
                }
            }
        }
        Console.WriteLine("Ordenado por burbuja:");
        foreach (int num in arregloBurbuja) Console.Write(num + " ");
        Console.WriteLine();

        // ordenamiento por seleccion

        for (int i = 0; i < arregloSeleccion.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < arregloSeleccion.Length; j++)
            {
                if (arregloSeleccion[j] < arregloSeleccion[minIndex])
                {
                    minIndex = j;
                }
            }
            int temp = arregloSeleccion[i];
            arregloSeleccion[i] = arregloSeleccion[minIndex];
            arregloSeleccion[minIndex] = temp;
        }
        Console.WriteLine("Ordenado por seleccion:");
        foreach (int num in arregloSeleccion) Console.Write(num + " ");
        Console.WriteLine();

        Console.ReadLine();
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
    






         

    
    