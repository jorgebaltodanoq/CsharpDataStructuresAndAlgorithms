using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //1era Forma
            SortedList<string, Persona> people = new SortedList<string, Persona>();
            //2da Forma
            var people2 = people;

            people.Add("117711", new Persona() { Name = "Jorge",   Pais = PaisesEnum.ARG, Age = 17 });
            people.Add("117712", new Persona() { Name = "Carlos",  Pais = PaisesEnum.PAR, Age = 47 });
            people.Add("117713", new Persona() { Name = "Lorenzo", Pais = PaisesEnum.PER, Age = 70 });
            people.Add("117714", new Persona() { Name = "Mariana", Pais = PaisesEnum.ECU, Age = 25 });
            people.Add("117715", new Persona() { Name = "Bonny",   Pais = PaisesEnum.URU, Age = 27 });
            people.Add("117716", new Persona() { Name = "Banny",   Pais = PaisesEnum.CHI, Age = 23 });
            people.Add("117717", new Persona() { Name = "Arturh",  Pais = PaisesEnum.VEN, Age = 30 });
            people.Add("117718", new Persona() { Name = "Anali",   Pais = PaisesEnum.BRA, Age = 50 });
            people.Add("117719", new Persona() { Name = "Jimena",  Pais = PaisesEnum.PER, Age = 19 });
            people.Add("117720", new Persona() { Name = "Michael", Pais = PaisesEnum.CHI, Age = 33 });

            Console.WriteLine("INFORMACION PEOPLE");
            foreach (KeyValuePair<string,Persona> person in people)
            {
                Console.WriteLine($" {person.Key} => {person.Value.Name} ({person.Value.Age} year) of {person.Value.Pais}");
            }

            Console.WriteLine("INFORMACION PEOPLE2");
            foreach (var person in people)
            {
                Console.WriteLine($" {person.Key} => {person.Value.Name} ({person.Value.Age} year) of {person.Value.Pais}");
            }

            Console.WriteLine("");
            Console.WriteLine("---------");
            Console.WriteLine($"{people["117711"]}");



            Console.WriteLine("Enter close");
            _ = Console.ReadKey();

        }
    }
}
