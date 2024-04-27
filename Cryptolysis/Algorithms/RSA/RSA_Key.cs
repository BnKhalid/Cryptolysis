using Cryptolysis.Algorithms.Interfaces;
using System.Numerics;
using System.Text.RegularExpressions;

namespace Cryptolysis.Algorithms.RSA;

internal class RSA_Key : IKey
{

    public BigInteger N { get; private set; } = 0;
    public BigInteger O { get; private set; } = 0;
    public BigInteger E { get; private set; } = 0;
    public BigInteger D { get; private set; } = 0;
    public BigInteger P { get; private set; } = 0;
    public BigInteger Q { get; private set; } = 0;

    public RSA_Key()
    {
        var rnd = new Random();

        BigInteger p = GetPrime(rnd.Next(30));
        BigInteger q = GetPrime(rnd.Next(30));

        CreateKey(p, q);
    }
    public RSA_Key(BigInteger p, BigInteger q)
    {
        CreateKey(p, q);
    }
    public RSA_Key(string key)
    {
        var args = ExtractNumbers(key);
        if ((args?.Count) == 2)
        {
            var (p, q) = GetDivisors(args[1]);
            CreateKey(p, q, args[0]);
        }
        else
            CreateKey(0, 0);
    }

    private void CreateKey(BigInteger p, BigInteger q, BigInteger? e = null)
    {
        P = p;
        Q = q;

        N = p * q;
        O = (p - 1) * (q - 1);

        if (e is not null)
            E = (BigInteger)e;
        else
        {
            for (BigInteger i = O - 1; i >= 1; --i)
                if (GCD(i, O) == 1)
                {
                    E = i;
                    break;
                }

        }

        if (O - 2 >= 0)
            D = ModularInverse(E, O);
    }
    private static BigInteger GetPrime(int i)
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
    private static bool IsPrime(BigInteger num)
    {
        if (num <= 1) return false;

        for (BigInteger i = 2; i * i <= num; i++)
            if (num % i == 0)
                return false;

        return true;
    }
    private static BigInteger GCD(BigInteger a, BigInteger b)
    {
        if (a < b)
        {
            a ^= b;
            b ^= a;
            a ^= b;
        }

        return b == 0 ? a : GCD(b, a % b);
    }
    private static (BigInteger, BigInteger) GetDivisors(BigInteger num)
    {
        for (BigInteger i = 2; i * i <= num; ++i)
            if (num % i == 0)
                return (i, num / i);
        return (0, 0);
    }
    private static BigInteger ModularInverse(BigInteger u, BigInteger v)
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
    private static List<BigInteger>? ExtractNumbers(string input)
    {
        var matches = Regex.Matches(input, @"\d+");

        if (matches?.Count >= 2)
            return matches.Select(m => BigInteger.Parse(m.Value)).ToList();

        return null;
    }

    public bool IsValid()
    {
        return P != Q && IsPrime(P) && IsPrime(Q) && GCD(E, O) == 1;
    }
    public override string ToString()
        => $"{E}, {N}";
}
