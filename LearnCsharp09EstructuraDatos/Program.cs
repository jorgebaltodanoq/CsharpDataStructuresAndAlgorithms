using System;
using System.Text.RegularExpressions;
using static System.Console;

namespace LearnCsharp09EstructuraDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Matrices
            int[] enteros = {20, -11, 12, -42, 0, 1, 90, 68, 6, -9 }; ;
            string [] cadena = {"Pedro", "Juan", "Diego", "Lorenzo","Alberto" };

            //Metodo Ordenar
            SelectionSort.Sort(enteros);
            SelectionSort.Sort(cadena);

            //Impresion valores.
            WriteLine(string.Join("| ",enteros));
            WriteLine(string.Join("| ", cadena));

            ReadKey();


        }
    }
}
