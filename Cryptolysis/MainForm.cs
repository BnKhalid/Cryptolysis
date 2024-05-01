using Cryptolysis.Algorithms.AES;
using Cryptolysis.Algorithms.DES;
using Cryptolysis.Algorithms.Diffie_Hellman;
using Cryptolysis.Algorithms.RSA;
using Cryptolysis.Algorithms.SDES;
using System.Numerics;

namespace Cryptolysis;

public partial class MainForm : Form
{
    readonly RSA _rsa;
    readonly Random _rnd;
    readonly DES _des;
    readonly SDES _sdes;
    readonly AES _aes;
    readonly Diffie_Hellman _diffie_hellman;

    public MainForm()
    {
        InitializeComponent();
        _rnd = new();
        _rsa = new() { Key = new(0, 0) };
        _des = new() { Key = new() };
        _sdes = new() { Key = new() };
        _aes = new() { Key = new() };
        _diffie_hellman = new();
    }

    #region RSA
    private void RSA_CalculateKey_Click(object sender, EventArgs e)
    {
        var key = new RSA_Key(int.Parse(RSA_FirstPrime.Text), int.Parse(RSA_SecondPrime.Text));

        if (key.IsValid())
        {
            RSA_KeyTextBox.Text = RSA_CalculatedKey.Text = key.ToString();
            _rsa.Key = key;
        }
        else
            RSA_CalculatedKey.Text = "INVALID TWO PRIME NUMBERS";
    }

    private void RSA_TextChanged(object sender, EventArgs e)
    {
        if (sender is TextBox primeTextBox &&
            (primeTextBox.Name == nameof(RSA_FirstPrime) || primeTextBox.Name == nameof(RSA_SecondPrime)))
            RSA_CalculatedKey.Text = string.Empty;

        RSA_CalculateKey.Enabled =
            !string.IsNullOrEmpty(RSA_FirstPrime.Text) && !string.IsNullOrEmpty(RSA_SecondPrime.Text);

        _rsa.Key = new(RSA_KeyTextBox.Text);

        RSA_Encrypt.Enabled =
            !string.IsNullOrEmpty(RSA_PlainText.Text) && !string.IsNullOrEmpty(RSA_KeyTextBox.Text) && _rsa.Key.IsValid();

        RSA_Decrypt.Enabled =
            !string.IsNullOrEmpty(RSA_CipherText.Text) && !string.IsNullOrEmpty(RSA_KeyTextBox.Text) && _rsa.Key.IsValid();
    }

    private void RSA_Encrypt_Click(object sender, EventArgs e)
    {
        RSA_CipherText.Text = _rsa.Encrypt(RSA_PlainText.Text);
    }

    private void RSA_Decrypt_Click(object sender, EventArgs e)
    {
        RSA_PlainText.Text = _rsa.Decrypt(RSA_CipherText.Text);
    }

    private void RSA_RndKey_Click(object sender, EventArgs e)
    {
        _rsa.Key = new();
        RSA_KeyTextBox.Text = $"{_rsa.Key.E}, {_rsa.Key.N}";
    }
    #endregion
    #region DES
    private void DES_Rnd_Click(object sender, EventArgs e)
    {
        string val = _rnd.Get64().ToString("X16");

        string? name = sender is Button button ? button.Name : null;

        switch (name)
        {
            case nameof(DES_RndKey):
                DES_KeyTextBox.Text = val;
                _des.Key = new(val);
                break;
            case nameof(DES_RndPlain):
                DES_PlainText.Text = val;
                break;
        }
    }

    private void DES_TextChanged(object sender, EventArgs e)
    {
        DES_Encrypt.Enabled =
            !string.IsNullOrEmpty(DES_PlainText.Text) && !string.IsNullOrEmpty(DES_KeyTextBox.Text);
    }

    private void DES_Encrypt_Click(object sender, EventArgs e)
    {
        DES_CipherText.Text = _des.Encrypt(DES_PlainText.Text);
    }
    #endregion
    #region SDES
    private void SDES_Rnd_Click(object sender, EventArgs e)
    {
        string val;

        string? name = sender is Button button ? button.Name : null;

        switch (name)
        {
            case nameof(SDES_RndKey):
                val = _rnd.Next(1024).ToString("X");
                SDES_KeyTextBox.Text = val;
                _sdes.Key = new(val);
                break;
            case nameof(SDES_RndPlain):
                val = _rnd.Next(256).ToString("X2");
                SDES_PlainText.Text = val;
                break;
        }
    }

    private void SDES_TextChanged(object sender, EventArgs e)
    {
        SDES_Encrypt.Enabled =
            !string.IsNullOrEmpty(SDES_PlainText.Text) && !string.IsNullOrEmpty(SDES_KeyTextBox.Text);
    }

    private void SDES_Encrypt_Click(object sender, EventArgs e)
    {
        SDES_CipherText.Text = _sdes.Encrypt(SDES_PlainText.Text);
    }
    #endregion
    #region AES
    private void AES_Rnd_Click(object sender, EventArgs e)
    {
        string? name = sender is Button button ? button.Name : null;

        switch (name)
        {
            case nameof(AES_RndKey):
                _aes.Key = new();
                AES_KeyTextBox.Text = _aes.Key.ToString();
                AES_CurrentKey.Text = string.Empty;
                break;
            case nameof(AES_RndPlain):
                AES_PlainText.Text = _aes.GenRndState();
                break;
        }
    }

    private void AES_TextChanged(object sender, EventArgs e)
    {
        AES_Encrypt.Enabled =
            !string.IsNullOrEmpty(AES_PlainText.Text) && !string.IsNullOrEmpty(AES_KeyTextBox.Text);

        AES_NxtKey.Enabled =
            !string.IsNullOrEmpty(AES_KeyTextBox.Text);
    }

    private void AES_Encrypt_Click(object sender, EventArgs e)
    {
        AES_CipherText.Text = _aes.Encrypt();
    }

    private void AES_NxtKey_Click(object sender, EventArgs e)
    {
        AES_Encrypt.Enabled = false;
        AES_CipherText.Text = string.Empty;
        _aes.Key.Next();
        if (_aes.Key.IterationIndex >= 11)
        {
            AES_KeyTextBox.Text = string.Empty;
            AES_CurrentKey.Text = string.Empty;
        }
        else
            AES_CurrentKey.Text = _aes.Key.ToString();
    }
    #endregion
    #region Diffie-Hellman
    private void DH_GeneratePG_Click(object sender, EventArgs e)
    {
        var (tp, th) = _diffie_hellman.GeneratePG();
        (DH_P.Text, DH_G.Text) = (tp.ToString(), th.ToString());

        DH_PrivateA.ReadOnly = DH_PrivateB.ReadOnly = false;
    }

    private void DH_TextChanged(object sender, EventArgs e)
    {
        bool a = !string.IsNullOrEmpty(DH_PrivateA.Text), b = !string.IsNullOrEmpty(DH_PrivateB.Text);

        if (!string.IsNullOrEmpty(DH_G.Text) && !string.IsNullOrEmpty(DH_P.Text))
        {
            if (a)
            {
                _diffie_hellman.A = BigInteger.Parse(DH_PrivateA.Text);
                DH_PublicA.Text = _diffie_hellman.ComputePrivateKey(_diffie_hellman.A).ToString();
            }
            else
                DH_PublicA.Text = string.Empty;

            if (b)
            {
                _diffie_hellman.B = BigInteger.Parse(DH_PrivateB.Text);
                DH_PublicB.Text = _diffie_hellman.ComputePrivateKey(_diffie_hellman.B).ToString();
            }
            else
                DH_PublicB.Text = string.Empty;
        }

        DH_S.Text = a && b
            ? _diffie_hellman.ComputePrivateKey(_diffie_hellman.A * _diffie_hellman.B).ToString()
            : string.Empty;
    }
    #endregion
    private void OnDigit_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            e.Handled = true;
    }

    private void OnChar_KeyPress(object sender, KeyPressEventArgs e)
    {
        if ((!char.IsLetter(e.KeyChar) && e.KeyChar != '\b'))
            e.Handled = true;
    }
}
