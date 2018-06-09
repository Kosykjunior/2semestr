using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myQueue
{
    class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int value = 0, Node next = null)
        {
            Value = value;
            Next = next;
        }
    }
}
