using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList
    {
        private Nodo headNode;
        private Nodo referenceNode;

        public LinkedList()
        {
            headNode = new Nodo();
            headNode.NextNode = null;
        }

        /// <summary>
        /// Agrega un nuevo nodo y un dato
        /// </summary>
        public void AddNode(dynamic dato)
        {
            referenceNode = headNode;

            while (referenceNode.NextNode != null)
            {
                referenceNode = referenceNode.NextNode;
            }

            Nodo newNode = new Nodo(); //Crea nuevo nodo
            newNode.DataNode = dato; //Insertamos dato al ndo
            newNode.NextNode = null; //Siguiente apunta a null

            referenceNode.NextNode = newNode;
        }

        /// <summary>
        /// Muestra los nodos y datos del linkedlist
        /// </summary>
        public void ShowNode()
        {
            referenceNode = headNode;

            while (referenceNode.NextNode != null)
            {
                referenceNode = referenceNode.NextNode;
                var data = referenceNode.DataNode;

                Console.Write($"[{data}]-->");
            }
            Console.Write("null");

            Console.WriteLine();
        }

    }
}
