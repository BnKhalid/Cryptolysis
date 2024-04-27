namespace Cryptolysis.Algorithms.Interfaces;

interface IAlgorithm
{
    string Encrypt(string plainText);
    string Decrypt(string cipherText);
}
