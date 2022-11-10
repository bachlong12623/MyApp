using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    public class MyMath
    {
        public int Add(int a, int b)
        {
            int tong;
            tong = a + b;
            return tong;
        }

        public int Sub(int a, int b)
        {
            int hieu;
            hieu = a - b;
            return hieu;
        }

        public int Mul(int a, int b)
        {
            int tich;
            tich = a * b;
            return tich;
        }

        public int Div(int a, int b)
        {
            int thuong;
            if (b == 0)
            {
                return 9999;
            }
            else
            {
                thuong = a / b;
                return thuong;
            }
        }

        public bool isNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

    }
}
