using System.Numerics;

namespace Cryptolysis.Algorithms.RSA;

internal class RSA
{
    public required RSA_Key Key { get; set; }

    public string Encrypt(string plainText)
    {
        var pow = BigInteger.ModPow(BigInteger.Parse(plainText), Key.E, Key.N);
        var res = pow % Key.N;
        return res.ToString();
    }

    public string Decrypt(string cipherText)
    {
        var pow = BigInteger.ModPow(BigInteger.Parse(cipherText), Key.D, Key.N);
        var res = pow % Key.N;
        return res.ToString();
    }
}
