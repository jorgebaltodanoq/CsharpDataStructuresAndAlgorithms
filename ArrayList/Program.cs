using static System.Console;
using System.Collections;


namespace ArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(5);
            arrayList.AddRange(new int[] { 20, 58, 36, 58, 49 });
            arrayList.AddRange(new string[] { "Maria", "Bonny" });
            arrayList.Insert(5, 7.89);
            arrayList.Insert(6, "Roberto");

            var conteo = arrayList.Count; //Cantidad elementos
            var capacidad = arrayList.Capacity; //Capacidad de almacenamiento
            var existe = arrayList.Contains("Bonny");
            var minIndex = arrayList.IndexOf(58);
            var maxIndex = arrayList.LastIndexOf(58);

            recorrerLista(arrayList);

            WriteLine($" Conto: {conteo} -  Capacidad: {capacidad} -Existe:  {existe} ");
            WriteLine($" Min Index:{ minIndex} - Max Index: {maxIndex}");

            arrayList.Remove(20);
            arrayList.RemoveAt(8);
            arrayList.RemoveRange(7, 1);
            recorrerLista(arrayList);

            arrayList.Reverse();
            arrayList.ToArray();
            recorrerLista(arrayList);

            arrayList.Clear();
            recorrerLista(arrayList);

            ReadKey();

        }

        public static void recorrerLista(ArrayList coleccion)
        {
            foreach (var item in coleccion)
            {
                WriteLine(" " + item);

            }
            WriteLine("-");
        }
    }
}
