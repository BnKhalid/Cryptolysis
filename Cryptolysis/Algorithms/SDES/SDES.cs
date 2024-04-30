namespace Cryptolysis.Algorithms.SDES;

internal class SDES
{
    public required SDES_Key Key { get; set; }

    public string Encrypt(string plainText)
    {
        var plain = int.Parse(plainText, System.Globalization.NumberStyles.HexNumber);
        var (l, r) = plain
            .Permute(SDES_Utils.ip)
            .Split();

        var key = Key.HexNumber.Permute(SDES_Utils.p10);
        var (c, d) = key.Split();

        for (int i = 1; i <= 2; i++)
        {
            c.Rotate(i, 5);
            d.Rotate(i, 5);

            key = c.Merge(d, 10)
                .Permute(SDES_Utils.p8);

            var tmpR = r;
            r = l ^ SDES_Utils.F(r, key);
            l = tmpR;

        }

        var cipher = r
            .Merge(l, 8)
            .Permute(SDES_Utils.ipInv);

        return cipher.ToString("X2");
    }
}
