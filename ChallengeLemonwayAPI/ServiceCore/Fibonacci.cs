using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Web;

namespace ChallengeLemonwayAPI.ServiceCore
{
    public static class Fibonacci
    {
        public static BigInteger Calculate(int n)
        {
            BigInteger response = -1;
            if (1 <= n && n <= 100)
            {
                BigInteger a = 0;
                BigInteger b = 1;
                for (int i = 31; i >= 0; i--)
                {
                    BigInteger d = a * (b * 2 - a);
                    BigInteger e = a * a + b * b;
                    a = d;
                    b = e;
                    if ((((uint)n >> i) & 1) != 0)
                    {
                        BigInteger c = a + b;
                        a = b;
                        b = c;
                    }
                }
                response = a;
            }
            return response;
        }
    }
}