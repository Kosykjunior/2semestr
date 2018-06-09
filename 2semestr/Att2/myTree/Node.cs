using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTree
{
    public class Node
    {
        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Value { get; set; }
        public Node(int value = 0)
        {
            Value = value;
        }
        internal Node(int N, int value)
        {
            Value = value;
            if(N>1)
            {
                Left = new Node(N - 1, value + 1);
                Right = new Node(N - 1, value + 1);
            }
        }
        public int GetHeight()
        {
            if (Left != null && Right != null)
                return Math.Max(Left.GetHeight(), Right.GetHeight())+1;
            if (Left != null)
                return Left.GetHeight() + 1;
            if (Right != null)
                return Right.GetHeight() + 1;
            return 1;
        }
    }
}
