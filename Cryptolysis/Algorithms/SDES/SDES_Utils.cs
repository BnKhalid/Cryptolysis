namespace Cryptolysis.Algorithms.SDES;

static class SDES_Utils
{
    public static readonly int[] p10 = [3, 5, 2, 7, 4, 10, 1, 9, 8, 6];
    public static readonly int[] p8 = [6, 3, 7, 4, 8, 5, 10, 9];
    public static readonly int[] ip = [2, 6, 3, 1, 4, 8, 5, 7];
    public static readonly int[] ipInv = [4, 1, 3, 5, 7, 2, 8, 6];
    public static readonly int[] ep = [4, 1, 2, 3, 2, 3, 4, 1];
    public static readonly int[] p4 = [2, 4, 3, 1];
    public static readonly int[][][] sBox =
    [
        [
            [1, 0, 3, 2],
            [3, 2, 1, 0],
            [0, 2, 1, 3],
            [3, 1, 3, 2]
        ],
        [
            [0, 1, 2, 3],
            [2, 0, 1, 3],
            [3, 0, 1, 0],
            [2, 1, 0, 3]
        ]
    ];

    public static int Permute(this int input, int[] permutation, int inputSize = 8, int outputSize = 8)
    {
        int output = 0;
        for (int i = 0; i < permutation.Length; i++)
        {
            output <<= 1;
            output |= (input >> (inputSize - permutation[i])) & 1;
        }
        return output;
    }

    public static int F(int input, int key)
    {
        int expanded = Permute(input, ep);
        
        int xor = expanded ^ key;
        var (s0, s1) = xor.Split();

        s0 = sBox[0][(s0 & 1) | ((s0 >> 3) & 2)][(s0 >> 1) & 3];
        s1 = sBox[1][(s1 & 1) | ((s1 >> 3) & 2)][(s1 >> 1) & 3];
        
        var reduced = s0.Merge(s1, 4);

        return Permute(reduced, p4);
    }

    public static (int, int) Split(this int input)
    {
        return (input >> 4, input & 0xF);
    }

    public static int Rotate(this int input, int shift, int size)
    {
        return ((input << shift) | (input >> (size - shift))) & ((1 << size) - 1);
    }

    public static int Merge(this int left, int right, int resultSize)
    {
        return (left << (resultSize / 2)) | right;
    }
}
