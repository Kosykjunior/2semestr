using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTree
{
    public class Tree
    {
        public Node Root { get; set; }

        public Tree()
        {
            Root = new Node();
        }
        public Tree(int N)
        {
            if (N < 1)
                throw new ArgumentException();
            Root = new Node(N, 1);
        }
        public int GetHeight() => Root.GetHeight();
    }
}
