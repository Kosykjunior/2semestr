using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public class ListIntFiltr
    {
        public List<int> list { get; set; }
        public ListIntFiltr(List<int> list) => this.list = list;
        public List<int> Positive()
        {
            List<int> positive = new List<int>();
            foreach (var item in list)
            {
                if (item > 0)
                    positive.Add(item);
            }
            return positive;
        }
        public List<int> Negative()
        {
            List<int> negative = new List<int>();
            foreach (var item in list)
            {
                if (item < 0)
                    negative.Add(item);
            }
            return negative;
        }

        public List<int> Even()
        {
            List<int> even = new List<int>();
            foreach (var item in list)
            {
                if (item %2 == 0)
                    even.Add(item);
            }
            return even;
        }

        public List<int> Odd()
        {
            List<int> odd = new List<int>();
            foreach (var item in list)
            {
                if (Math.Abs( item % 2) == 1)
                    odd.Add(item);
            }
            return odd;
        }

    }
}
