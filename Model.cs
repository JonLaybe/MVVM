using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp22
{
    class Model
    {
        public string Reverce(string text)
        {
            string result = "";
            for (int i = text.Length-1; i >= 0 ; i--)
            {
                result += text[i];
            }
            return result;
        }
    }
}
