﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public class StrTools
    {
        public string Str { get; set; }
        public StrTools(string str) => Str = str;
        public string GetMarks()
        {
            StringBuilder sb = new StringBuilder();
            char[] Marks = new char[] { ',', '.', ':', ';', '?', '!', '\"', '\'' };
            foreach (var item in Str)
            {
                if (Marks.Contains(item))
                    sb.Append(item + " ");
            }
            return sb.ToString();
        }
    }
}
