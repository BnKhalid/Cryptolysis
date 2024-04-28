using System.Numerics;
using System.Text.RegularExpressions;

namespace Cryptolysis.Algorithms.RSA;

static class RSA_Utils
{
    public static List<BigInteger>? ExtractNumbers(string input)
    {
        var matches = Regex.Matches(input, @"\d+");

        if (matches?.Count >= 2)
            return matches.Select(m => BigInteger.Parse(m.Value)).ToList();

        return null;
    }
    public static BigInteger GCD(BigInteger a, BigInteger b)
    {
        if (a < b)
        {
            a ^= b;
            b ^= a;
            a ^= b;
        }

        return b == 0 ? a : GCD(b, a % b);
    }
    public static (BigInteger, BigInteger) GetDivisors(BigInteger num)
    {
        for (BigInteger i = 2; i * i <= num; ++i)
            if (num % i == 0)
                return (i, num / i);
        return (0, 0);
    }
    public static BigInteger GetPrime(int i)
    {
        int cnt = 0;

        for (int num = 2; num < 1e6; ++num)
        {
            if (IsPrime(num))
                cnt++;
            if (cnt == i)
                return num;
        }
        return 0;
    }
    public static bool IsPrime(BigInteger num)
    {
        if (num <= 1) return false;

        for (BigInteger i = 2; i * i <= num; i++)
            if (num % i == 0)
                return false;

        return true;
    }
    public static BigInteger ModularInverse(BigInteger u, BigInteger v)
    {
        BigInteger inverse, u1, u3, v1, v3, t1, t3, q = new BigInteger();
        BigInteger iteration;

        u1 = 1;
        u3 = u;
        v1 = 0;
        v3 = v;

        iteration = 1;
        while (v3 != 0)
        {
            q = u3 / v3;
            t3 = u3 % v3;
            t1 = u1 + q * v1;

            u1 = v1; v1 = t1; u3 = v3; v3 = t3;
            iteration = -iteration;
        }

        if (u3 != 1)
            return 0;
        else if (iteration < 0)
            inverse = v - u1;
        else
            inverse = u1;

        return inverse;
    }
}
