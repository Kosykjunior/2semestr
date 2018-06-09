using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public class BooleanLogic
    {
        public string Str { get; set; }

        public BooleanLogic(string str)
        {
            Str = str;
        }
        private string SimpleView;
        private bool SetSimpleView()
        {
            StringBuilder sb = new StringBuilder();
            int braces = 0;
            for (int i = 0; i < Str.Length;)
            {
                switch (Str[i])
                {
                    case '(':
                        braces++;
                        sb.Append(Str[i]);
                        i++;
                        break;
                    case ')':
                        braces--;
                        sb.Append(Str[i]);
                        if (braces < 0)
                            return false;
                        i++;
                        break;
                    case 'T':
                    case 't':
                        if (Str.Length - i < 4)
                            return false;
                        if (Str.Substring(i, 4).ToUpper() != "TRUE")
                            return false;
                        sb.Append("1");
                        i += 4;
                        break;
                    case 'F':
                    case 'f':
                        if (Str.Length - i < 5)
                            return false;
                        if (Str.Substring(i, 5).ToUpper() != "FALSE")
                            return false;
                        sb.Append("0");
                        i += 5;
                        break;
                    case 'N':
                    case 'n':
                        if (Str.Length - i < 3)
                            return false;
                        if (Str.Substring(i, 3).ToUpper() != "NOT")
                            return false;
                        sb.Append("-");
                        i += 3;
                        break;
                    case 'A':
                    case 'a':
                        if (Str.Length - i < 3)
                            return false;
                        if (Str.Substring(i, 3).ToUpper() != "AND")
                            return false;
                        sb.Append("*");
                        i += 3;
                        break;
                    case 'O':
                    case 'o':
                        if (Str.Length - i < 2)
                            return false;
                        if (Str.Substring(i, 2).ToUpper() != "OR")
                            return false;
                        sb.Append("+");
                        i += 2;
                        break;
                    case ' ':
                        i++;
                        break;
                    default:
                        return false;
                }
            }
            if (braces > 0)
                return false;
            SimpleView = sb.ToString();
            return true;
        }
        private bool GetValue(int index, int count)
        {
            if(count == 1)
            {
                if (SimpleView[index] == '0')
                    return false;
                if (SimpleView[index] == '1')
                    return true;
                throw new Exception();
            }
            int braces = 0;
            for (int i = index; i < count+index; i++)
            {
                switch (SimpleView[i])
                {
                    case '(':
                        braces++;
                        break;
                    case ')':
                        braces--;
                        break;
                    case '+':
                        if (braces == 0)
                            return GetValue(index, i - index) | GetValue(i + 1, count - i + index - 1);
                        break;
                }
            }
            for (int i = index; i < count + index; i++)
            {
                switch (SimpleView[i])
                {
                    case '(':
                        braces++;
                        break;
                    case ')':
                        braces--;
                        break;
                    case '*':
                        if (braces == 0)
                            return GetValue(index, i - index) & GetValue(i + 1, count - i + index - 1);
                        break;
                }
            }
            switch (SimpleView[index])
            {
                case '(':
                    return GetValue(index + 1, count - 2);
                case '-':
                    return !GetValue(index + 1, count - 1);
                default:
                    throw new Exception();
            }
        }
        public bool TryGet(out bool Value)
        {
            Value = false;
            if (!SetSimpleView())
                return false;
            try
            {
                Value = GetValue(0, SimpleView.Length);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
