using System;
using System.Collections.Generic;
using System.Globalization;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            // Crear un LindkedList
            var lnkList = new LinkedList();

            lnkList.AddNode("Jorge");
            lnkList.AddNode("Carlos");
            lnkList.AddNode("Martin");
            lnkList.AddNode("Roberto");
            lnkList.AddNode("Juan");
            lnkList.AddNode("Miguel");
            lnkList.AddNode("Lucio");

            lnkList.ShowNode();

            Console.WriteLine("\n\nEnter close..");
            _=Console.ReadLine();
        }
    }
}
   