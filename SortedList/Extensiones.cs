using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    public static class Extensiones
    {
        /// <summary>
        /// Muestra todos los elementos solo de sortedList
        /// </summary>
         /// <param name="people"> es un metodo de extension</param>
        public static void ShowSortedList(this SortedList<string,Persona> people)
        {
            foreach (var person in people)
            {
                Console.WriteLine($"{person.Key} - {person.Value.Name}, {person.Value.Age}, {person.Value.Pais}");
            }
            Console.WriteLine();
        }
    }
}
