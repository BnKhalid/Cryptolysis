using System.Text;

namespace Cryptolysis.Algorithms.AES;

internal class AES_Key
{
    public int IterationIndex { get; set; }
    public int[][] Key { get; set; }

    public AES_Key()
    {
        var rnd = new Random();
        Key = new int[4][];

        for (var i = 0; i < 4; i++)
        {
            Key[i] = new int[4];
            for (var j = 0; j < 4; j++)
                Key[i][j] = rnd.Next(0, 256);
        }

        IterationIndex = 0;
    }

    public void Next()
    {
        IterationIndex++;

        if (IterationIndex >= 11)
            return;

        var nxt = new int[4][];

        for (int col = 0; col < 4; col++)
        {
            nxt[col] = new int[4];

            for (int row = 0; row < 4; row++)
            {
                if (col == 0)
                {
                    int temp = Key[(row + 1) % 4][col];
                    nxt[col][row] = Key[row][col] ^ AES_Utils.SubByte[temp >> 4][temp & 0x0f] ^ AES_Utils.Rcon[IterationIndex];
                }
                else
                {
                    nxt[col][row] = Key[row][col - 1] ^ Key[row][col];
                }
            }
        }

        for (int i = 0; i < 4; i++)
            for (int j = 0; j < 4; j++)
                Key[j][i] = nxt[i][j];
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        for (int col = 0; col < 4; col++)
            for (int row = 0; row < 4; row++)
                sb.Append(Key[col][row].ToString("X2"));

        return sb.ToString();
    }
}
