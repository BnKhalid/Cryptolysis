using Cryptolysis.Algorithms.DES;
using Cryptolysis.Algorithms.RSA;

namespace Cryptolysis;

public partial class MainForm : Form
{
    readonly RSA _rsa;
    readonly Random _rnd;
    readonly DES _des;
    public MainForm()
    {
        InitializeComponent();
        _rnd = new Random();
        _rsa = new RSA() { Key = new(0, 0) };
        _des = new DES() { Key = new() };
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
