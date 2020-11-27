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
            var people = new SortedList<string,Persona>();

            people.Add("117711", new Persona() { Name = "Jorge", Pais = EnumPais.ARG, Age = 17 });
            people.Add("117712", new Persona() { Name = "Carlos", Pais = EnumPais.PAR, Age = 47 });
            people.Add("117713", new Persona() { Name = "Lorenzo", Pais = EnumPais.PER, Age = 70 });
            people.Add("117714", new Persona() { Name = "Mariana", Pais = EnumPais.ECU, Age = 25 });
            people.Add("117715", new Persona() { Name = "Bonny", Pais = EnumPais.URU, Age = 27 });
            people.Add("117716", new Persona() { Name = "Banny", Pais = EnumPais.CHI, Age = 23 });
            people.Add("117717", new Persona() { Name = "Arturh", Pais = EnumPais.VEN, Age = 30 });
            people.Add("117718", new Persona() { Name = "Anali", Pais = EnumPais.BRA, Age = 50 });
            people.Add("117719", new Persona() { Name = "Jimena", Pais = EnumPais.PER, Age = 19 });
            people.Add("117720", new Persona() { Name = "Michael", Pais = EnumPais.CHI, Age = 33 });

            people.ShowSortedList();
            
            
            Console.WriteLine("Enter close");
            _ = Console.ReadKey();

        }
    }
}
