using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int opc = -1;
                int[,] matrizA = new int[5, 5];
                int[,] matrizB = new int[5, 5];
                bool pre = false;

                Console.Clear();
                Console.WriteLine("Parcial Andrés López\n");

                Console.WriteLine("Presione 1 para llenar las matrices con numeros aleatorios de forma automatica");
                Console.WriteLine("Presione cualquier otra tecla para hacerlo manual");
                try
                {
                    if (int.Parse(Console.ReadLine()) == 1)
                        pre = true;

                }
                catch (Exception ex)
                {
                    pre = false;
                }
                Console.Clear();
                Console.WriteLine($"Se cargara la matriz A de 5 X 5 { (pre ? "de forma automatica" : "de forma manual") }");
                matrizA = ClassMatrices.CargarMatriz(5, pre);
                Console.WriteLine("MATRIZ A");
                ClassMatrices.MostrarMatriz(matrizA);
                Console.WriteLine("Presione cualquier tecla para continuar");
                Console.ReadKey();

                Console.WriteLine($"Se cargara la matriz B de 5 X 5 { (pre ? "de forma automatica" : "de forma manual") }");
                matrizB = ClassMatrices.CargarMatriz(5, pre);
                Console.WriteLine("MATRIZ B");
                ClassMatrices.MostrarMatriz(matrizB);
                Console.WriteLine("Presione cualquier tecla para continuar");
                Console.ReadKey();

                Console.Clear();

                while (opc != 0)
                {
                    Console.WriteLine("Escoja uno de los siguientes ejercicios");
                    Console.WriteLine("1 para el primer ejercicio");
                    Console.WriteLine("2 para el segundo ejercicio");
                    Console.WriteLine("3 para el tercer ejercicio");
                    Console.WriteLine("0 para salir del programa");

                    opc = int.Parse(Console.ReadLine());

                    if (opc == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Primer Ejercicio");
                        ClassMatrices.MostrarMatriz(ClassMatrices.PrimerEjercicioMatriz(5));
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (opc == 2)
                    {
                        Console.Clear();

                        Console.WriteLine("La matriz A es la siguiente");
                        ClassMatrices.MostrarMatriz(matrizA);

                        Console.WriteLine("¿Cual termino quiere buscar?");
                        ClassMatrices.BuscarDentroMatriz(matrizA, int.Parse(Console.ReadLine()));
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (opc == 3)
                    {
                        bool dupl = false;

                        Console.Clear();
                        Console.WriteLine("La matriz A es la siguiente");
                        ClassMatrices.MostrarMatriz(matrizA);

                        Console.WriteLine("La matriz B es la siguiente");
                        ClassMatrices.MostrarMatriz(matrizB);
                        try
                        {
                            Console.WriteLine("presione 1 para evitar los numeros duplicados de la matriz A");
                            Console.WriteLine("presione cualquier otra tecla para mantenerlos");
                            dupl = int.Parse(Console.ReadLine()) == 1;
                        }
                        catch (Exception ex)
                        {
                            dupl = false;
                        }
                        
                        ClassMatrices.BuscarEntreDosMatrices(matrizA, matrizB, dupl);
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Solo son validos números");
                Console.ReadKey();
            }
        }
    }
}

