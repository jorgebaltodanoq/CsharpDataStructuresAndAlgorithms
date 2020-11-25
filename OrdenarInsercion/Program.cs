using System;
using static System.Console;

namespace OrdenarInsercion
{
    class Program
    {
        static void Main(string[] args)
        {
            // ORDENAMIENTO INSERCION

            //Matrices
            int[] Enteros = { 20, -11, 12, -42, 0, 1, 90, 68, 6, -9 }; ;
          
            //Metodo Ordenar
            InserccionSort.SortInsert(Enteros);

            //Impresion valores.
            WriteLine(string.Join("| ", Enteros));
           

            ReadKey();
        }
    }
}
