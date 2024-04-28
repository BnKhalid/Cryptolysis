using System.Numerics;
using Cryptolysis.Algorithms.Interfaces;

namespace Cryptolysis.Algorithms.DES;

internal class DES_Key : IKey
{
    public BigInteger HexNumber { get; set; }
    public DES_Key()
    {
        var rnd = new Random();
        HexNumber = rnd.Get64();
    }
    public DES_Key(string hex)
    {
        HexNumber = BigInteger.Parse(hex, System.Globalization.NumberStyles.HexNumber);
    }

    public bool IsValid()
    {
        throw new NotImplementedException();
    }
}
