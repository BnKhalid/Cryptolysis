using System.Numerics;

namespace Cryptolysis.Algorithms.Diffie_Hellman;

internal class Diffie_Hellman
{
    public BigInteger P { get; set; }
    public BigInteger G { get; set; }
    public BigInteger A { get; set; }
    public BigInteger B { get; set; }

    public Diffie_Hellman()
    {
        GeneratePG();
    }

    public (BigInteger, BigInteger) GeneratePG()
    {
        var rnd = new Random();
        G = rnd.Next(5, 16);

        for (int i = rnd.Next(1000, 5000); i < 1e4; i++)
            if (Diffie_Hellman_Utils.IsPrime(i))
            {
                P = i;
                break;
            }

        return (P, G);
    }

    public BigInteger ComputePrivateKey(BigInteger num)
    {
        return BigInteger.ModPow(G, num, P);
    }
}
