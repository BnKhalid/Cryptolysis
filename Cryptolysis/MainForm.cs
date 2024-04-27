using Cryptolysis.Algorithms.RSA;

namespace Cryptolysis;

public partial class MainForm : Form
{
    readonly RSA _rsa;
    public MainForm()
    {
        InitializeComponent();
        _rsa = new RSA() { Key = new(0, 0) };
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
