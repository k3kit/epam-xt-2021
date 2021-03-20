using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._1
{
    class CustomString
    {
        private char[] chars { get; set; }

        public CustomString(string str)
        {
            chars = str.ToCharArray();
        }

        public CustomString(char[] str)
        {
            this.chars = str;
        }

        public int Length()
        {
            return chars.Length;
        }


        public int Compare(CustomString str)
        {
            if (Length() > str.Length())
            {
                return 1;
            }
            else if (Length() < str.Length())
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }


        public string Concatenation(CustomString str)
        {
            StringBuilder resultString = new StringBuilder();
            for (int i = 0; i < Length(); i++)
            {
                resultString.Append(chars[i]);
            }
            for (int i = 0; i < str.Length(); i++)
            {
                resultString.Append(str[i]);
            }
            return resultString.ToString();
        }

        public int SearchSymbol(char symbol)
        {
            for (int i = 0; i < Length(); i++)
            {
                if (chars[i] == symbol)
                {
                    return i;
                }
            }
            return 0;
        }


        
        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < Length(); ++i)
            {
                str += chars[i];
            }
            return str;
        }

        public CustomString Reverse()
        {
            char[] res = new char[Length()];
            for(int i = 0; i<Length() -1; i++)
            {
                res[i] = chars[Length()-i ];
            }
            return new CustomString(res);
        }
        public char this[int index]
        {
            get
            {
                if (chars.Length > index && index > -1)
                {
                    return chars[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"Index '{index}' incorrect!");
                }
            }
            set
            {
                if (chars.Length > index && index > -1)
                {
                    chars[index] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"Index '{index}' incorrect!");
                }
            }
        }
    }
}
