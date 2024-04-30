using System.Text;

namespace Cryptolysis.Algorithms.AES;

internal class AES
{
    public required AES_Key Key { get; set; }
    public int[][]? State { get; set; }

    public string GenRndState()
    {
        var rnd = new Random();
        State = new int[4][];
        for (var i = 0; i < 4; i++)
        {
            State[i] = new int[4];
            for (var j = 0; j < 4; j++)
                State[i][j] = rnd.Next(0, 256);
        }

        return PrintState();
    }

    private string PrintState()
    {
        var sb = new StringBuilder();
        for (var row = 0; row < 4; row++)
            for (var col = 0; col < 4; col++)
                sb.Append(State![row][col].ToString("X2"));

        return sb.ToString();
    }

    public string Encrypt()
    {
        if (State == null)
            return "";

        // AddRoundKey
        for (var col = 0; col < 4; col++)
            for (var row = 0; row < 4; row++)
                State[row][col] ^= Key.Key[row][col];

        for (int i = 0; i < 10; i++)
        {
            // SubBytes
            for (var row = 0; row < 4; row++)
                for (var col = 0; col < 4; col++)
                    State[row][col] = AES_Utils.SubByte[State[row][col] >> 4][State[row][col] & 0x0f];

            // ShiftRows
            for (var row = 1; row < 4; row++)
                for (var j = 0; j < row; j++)
                {
                    var temp = State[row][0];
                    for (var col = 0; col < 3; col++)
                        State[row][col] = State[row][col + 1];
                    State[row][3] = temp;
                }

            if (i < 9)
            {
                // MixColumns
                for (var col = 0; col < 4; col++)
                {
                    var s0 = State[0][col];
                    var s1 = State[1][col];
                    var s2 = State[2][col];
                    var s3 = State[3][col];

                    State[0][col] = AES_Utils.GF_Mul(0x02, s0) ^ AES_Utils.GF_Mul(0x03, s1) ^ s2 ^ s3;
                    State[1][col] = s0 ^ AES_Utils.GF_Mul(0x02, s1) ^ AES_Utils.GF_Mul(0x03, s2) ^ s3;
                    State[2][col] = s0 ^ s1 ^ AES_Utils.GF_Mul(0x02, s2) ^ AES_Utils.GF_Mul(0x03, s3);
                    State[3][col] = AES_Utils.GF_Mul(0x03, s0) ^ s1 ^ s2 ^ AES_Utils.GF_Mul(0x02, s3);
                }
            }

            // AddRoundKey
            Key.Next();
            for (var col = 0; col < 4; col++)
                for (var row = 0; row < 4; row++)
                    State[row][col] ^= Key.Key[row][col];
        }

        return PrintState();
    }
}
