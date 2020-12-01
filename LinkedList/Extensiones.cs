using System;
using System.Collections.Generic;
using System.Globalization;
namespace LinkedList
{
    public static class Extensiones
    {
        public static void EncontrarValor<T>(this T dato, LinkedList<T> linkedList)
        {

            var exist = linkedList.Contains(dato);

            if (exist)
            {
                var index = linkedList.Find(dato).Value;
                Console.WriteLine($"El valor {dato} existe.");
               
            }
            else
            {
                Console.WriteLine($"El valor {dato} no existe. ");
            }

            
        }
        public static void MostrarLinkedList<T>(this LinkedList<T> linked, string mensaje)
        {
            Console.WriteLine(mensaje);
            foreach (var value in linked)
            {
                Console.Write($"|{value}| --> ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void RellenarMeses(this string[] array)
        {
            for (int mes = 1; mes <= array.Length; mes++)
            {
                DateTime fechaActual = new DateTime(DateTime.Now.Year, mes, 1);
                string nameMonth = fechaActual.ToString("MMMM", CultureInfo.CreateSpecificCulture("es"));
                array[mes - 1] = nameMonth;
            }
        }
        public static void RellenarMatriz(this int[] array)
        {
            Random randon = new Random();

            for ( var i = 0; i < array.Length; i++)
            {
                array[i] = randon.Next(1, 100);
            }
        }

        public static void ImprimerDato<T>(this T valor, string mensaje )
        {
            Console.WriteLine(mensaje);
            Console.WriteLine(valor);
        }

    }
}
