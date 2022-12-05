using System;
using System.Collections.Generic;

namespace ConParcial
{

    class ClassMatrices
    {
        private static readonly Random random = new Random();

        public static int NumeroAleatorio()
        {
            return random.Next(1, 10);
        }

        public static int[,] PrimerEjercicioMatriz(int tam)
        {
            int[,] matriz = new int[tam, tam];

            for (int i = 0; i < tam; i++)
            {
                for (int j = 0; j < tam; j++)
                {
                    if (i != 0 && i != 4 && j != 0 && j != 4)
                        matriz[i, j] = 1;
                    else
                        matriz[i, j] = 0;

                }
            }

            return matriz;

        }

        public static void MostrarMatriz(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public static int[,] CargarMatriz(int dimension, bool esAutomatica)
        {
            int[,] matriz = new int[dimension, dimension];

            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    Console.WriteLine($"Digite la ubicacion {i + 1} y {j + 1} de la matriz");
                    if (esAutomatica)
                        matriz[i, j] = NumeroAleatorio();
                    else
                        matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Clear();
            return matriz;
        }

        public static void BuscarDentroMatriz(int[,] array, int aBuscar)
        {
            int contador = 0;
            for (int fila = 0; fila < array.GetLength(0); fila++)
            {
                for (int col = 0; col < array.GetLength(0); col++)
                {
                    if (array[fila, col] == aBuscar)
                    {
                        Console.WriteLine($"Se encontro el número { aBuscar } en la posicion { fila + 1 } { col + 1 }");
                        contador++;
                    }
                }
            }

            Console.WriteLine($"El número { aBuscar } se encontro { contador } veces");
        }

        public static void BuscarEntreDosMatrices(int[,] arrayA, int[,] arrayB, bool sinDuplicados)
        {
            int dimension = arrayA.GetLength(0);
            int contador = 0;
            List<int> numeros = new List<int>();

            for (int fil = 0; fil < dimension; fil++)
            {
                for (int col = 0; col < dimension; col++)
                {
                    int num = arrayA[fil, col];
                    if (sinDuplicados)
                    {
                        if (numeros.IndexOf(num) == -1)
                            numeros.Add(num);
                    }
                    else
                    {
                        numeros.Add(num);
                    }
                }
            }

            numeros.Sort();

            foreach (var numero in numeros)
            {
                for (int fil = 0; fil < dimension; fil++)
                {
                    for (int col = 0; col < dimension; col++)
                    {
                        int num = arrayB[fil, col];
                        if (numero == num)
                        {
                            Console.WriteLine($"Se encontro el número { num } en el arrayB fila { fil+1 } columna { col+1 }");
                            contador++;
                        }
                    }
                }
            }



            Console.WriteLine($"Se encontraron { contador } números de la matriz A en la matriz B");
        }
    }
}
