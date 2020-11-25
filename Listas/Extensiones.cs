using System;
using System.Collections.Generic;


namespace Listas
{
    static class Extensiones
    {


        /// <summary>
        /// Metodo extension: muestra los elementos de una lista
        /// </summary>
        /// <param name="list">Evalua solo datos de tipo lista</param>
        public static void RunList(this List<Persona> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Name} tiene ({item.Age}) de {item.Pais}");
            }
            Console.WriteLine("\n");
        }

        public static void ShowInt(this int valor)
        {
            Console.WriteLine(valor);
            Console.WriteLine("\n");
        }



    }
}
