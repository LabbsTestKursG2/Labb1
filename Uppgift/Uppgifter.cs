using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift
{
    //Uppgift1
   public class Uppgifter
    {
        public string ConcatArrayWithSpace(string[] array)
        {

            return String.Join(" ", array);
        }
        public string Capitalize(string str)
        {
            
            string ret = new String(str.Where(c => c != '-' && (c < '0' || c > '9')).ToArray());

            ret = UppercaseWords(ret);

            return (ret.Replace( '.', '_').Replace(',', '_').Replace(';', '_').Replace(':', '_').Replace('!', '_').Replace('?', '_').Replace('`', '_').Replace('"', '_').Replace('-', '_').Replace('/', '_').Replace('(', '_').Replace(')', '_').Replace('[', '_').Replace(']', '_').Replace('*', '_').Replace(" ", ""));
            

        }
        public string UppercaseFirstEach(string str)
        {
            return (UppercaseWords(str));
        }
        public int Average(int tal1, int tal2)
        {
            return (tal1 + tal2) / 2;
            
        }

        static string UppercaseWords(string value)
        {
            char[] array = value.ToCharArray();
            
            if (array.Length >= 1)
            {
                if (char.IsLower(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }
            }
             for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == ' ')
                {
                    if (char.IsLower(array[i]))
                    {
                        array[i] = char.ToUpper(array[i]);
                    }
                }
            }
            return new string(array);
        }
    }
}

