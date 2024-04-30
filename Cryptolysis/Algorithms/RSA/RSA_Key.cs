using System.Numerics;

namespace Cryptolysis.Algorithms.RSA;

internal class RSA_Key
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

        BigInteger p = RSA_Utils.GetPrime(rnd.Next(30));
        BigInteger q = RSA_Utils.GetPrime(rnd.Next(30));

        CreateKey(p, q);
    }
    public RSA_Key(BigInteger p, BigInteger q)
    {
        CreateKey(p, q);
    }
    public RSA_Key(string key)
    {
        var args = RSA_Utils.ExtractNumbers(key);
        if ((args?.Count) == 2)
        {
            var (p, q) = RSA_Utils.GetDivisors(args[1]);
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
                if (RSA_Utils.GCD(i, O) == 1)
                {
                    E = i;
                    break;
                }

        }

        if (O - 2 >= 0)
            D = RSA_Utils.ModularInverse(E, O);
    }

    public bool IsValid()
    {
        return P != Q && RSA_Utils.IsPrime(P) && RSA_Utils.IsPrime(Q) && RSA_Utils.GCD(E, O) == 1;
    }

    public override string ToString()
        => $"{E}, {N}";
}
