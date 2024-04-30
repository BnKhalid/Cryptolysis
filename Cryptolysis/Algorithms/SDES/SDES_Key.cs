namespace Cryptolysis.Algorithms.SDES;

internal class SDES_Key
{
    public int HexNumber { get; set; }
    public SDES_Key()
    {
        var rnd = new Random();
        HexNumber = rnd.Next(1024);
    }
    public SDES_Key(string hex)
    {
        HexNumber = int.Parse(hex, System.Globalization.NumberStyles.HexNumber);
    }
}
