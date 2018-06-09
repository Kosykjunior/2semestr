using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myQueue
{
    public class IntQueue
    {
        Node Head;
        Node Tail;
        public int Count { get; private set; }

        public IntQueue()
        {
            Head = new Node();
            Tail = Head;
            Count = 0;
        }

        public void Enqueue(int value)
        {
            Count++;
            Tail.Next = new Node(value);
            Tail = Tail.Next;
        }
        public int Peek()
        {
            if (Count == 0)
                throw new InvalidOperationException();
            return Head.Next.Value;
        }
        public int Dequque()
        {
            if (Count == 0)
                throw new InvalidOperationException();
            Count--;
            Head = Head.Next;
            return Head.Value;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            Node Go = Head.Next;
            for (int i = 0; i < Count; i++)
            {
                sb.Append(Go.Value);
                sb.Append(" ");
                Go = Go.Next;
            }
            return sb.ToString();
        }
        public void InsertAt(int index, int value)
        {
            if (index < 0 || index > Count)
                throw new ArgumentOutOfRangeException();
            Node Go = Head;
            for (int i = 0; i < index; i++)
                Go = Go.Next;
            Go.Next = new Node(value, Go.Next);
            Count++;
        }
    }
}
