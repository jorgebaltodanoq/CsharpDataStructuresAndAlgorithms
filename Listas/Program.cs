using System.Globalization;
using System.Collections.Generic;
using static System.Console;
using System.Linq;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            var listPerson = new List<Persona>();
           
            listPerson.Add(new Persona() { Name = "Jorge",   Pais = PaisLista.Perú,     Age = 27 });
            listPerson.Add(new Persona() { Name = "Bonny",   Pais = PaisLista.Colombia, Age = 28 });
            listPerson.Add(new Persona() { Name = "Evans",   Pais = PaisLista.Brasil,   Age = 14 });
            listPerson.Add(new Persona() { Name = "Camila",  Pais = PaisLista.Ecuador,  Age = 18 });
            listPerson.Add(new Persona() { Name = "Roberto", Pais = PaisLista.Colombia, Age = 25 });
            listPerson.Insert(2,
                           new Persona() { Name = "Juan",    Pais = PaisLista.Ecuador,  Age = 20 });

            WriteLine("LISTA ORIGINAL \n-------------");
            listPerson.RunList();

            WriteLine("LISTA ORDENADA ALFABETO \n-------------");
            var orderList = listPerson.OrderBy(x => x.Name).ToList();
            orderList.RunList();

            WriteLine("LISTA MAYORES EDAD \n-------------");
            var oldList = orderList.Where(x => x.Age > 18).ToList();
            oldList.RunList();

            WriteLine("EDAD MAYOR \n-------------");
            var oldPerson = listPerson.Max(x => x.Age);
            oldPerson.ShowInt();

            WriteLine("EDAD MENOR \n-------------");
            var youngPerson = listPerson.Min(x => x.Age);
            youngPerson.ShowInt();



            _ = ReadKey();

        }
    }
}
