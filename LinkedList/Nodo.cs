using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Nodo
    {
        public dynamic DataNode { get; set; }
        public Nodo NextNode { get; set; } = null;

        public override string ToString()
        {
            return string.Format($"{DataNode}");
        }


    }
}
