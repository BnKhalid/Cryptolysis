using System.Numerics;

namespace Cryptolysis.Algorithms.DES;

internal class DES
{
    public required DES_Key Key { get; set; }

    public string Encrypt(string plainText)
    {
        var plain = BigInteger.Parse(plainText, System.Globalization.NumberStyles.HexNumber);
        plain = plain.Permute(DES_Utils.ip, 64);
        var (l, r) = plain.Split(32);

        var key = Key.HexNumber.Permute(DES_Utils.pc1, 64);
        var (c, d) = key.Split(28);

        for (int i = 1; i <= 16; i++)
        {
            if (DES_Utils.exceptionalShifts.Contains(i))
            {
                c = c.Rotate(1, 28);
                d = d.Rotate(1, 28);
            }
            else
            {
                c = c.Rotate(2, 28);
                d = d.Rotate(2, 28);
            }

            var k = c.Merge(d, 56);
            k.Permute(DES_Utils.pc2, 56);

            var tmpR = r;
            r = l ^ DES_Utils.F(r, k);
            l = tmpR;
        }

        var ciphered = r.Merge(l, 64);
        ciphered.Permute(DES_Utils.ipInverse, 64);

        return ciphered.ToString("X16");
    }
}
