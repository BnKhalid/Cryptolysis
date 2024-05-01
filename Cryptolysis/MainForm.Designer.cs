namespace Cryptolysis
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox3 = new GroupBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            RSA_Decrypt = new Button();
            RSA_Encrypt = new Button();
            RSA_RndKey = new Button();
            RSA_CipherText = new TextBox();
            RSA_KeyTextBox = new TextBox();
            RSA_PlainText = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            RSA_CalculateKey = new Button();
            RSA_CalculatedKey = new TextBox();
            RSA_SecondPrime = new TextBox();
            RSA_FirstPrime = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            groupBox6 = new GroupBox();
            textBox8 = new TextBox();
            groupBox5 = new GroupBox();
            SDES_Encrypt = new Button();
            SDES_RndKey = new Button();
            SDES_RndPlain = new Button();
            SDES_CipherText = new TextBox();
            SDES_KeyTextBox = new TextBox();
            SDES_PlainText = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            groupBox4 = new GroupBox();
            DES_Encrypt = new Button();
            DES_RndKey = new Button();
            DES_RndPlain = new Button();
            DES_CipherText = new TextBox();
            DES_KeyTextBox = new TextBox();
            DES_PlainText = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            tabPage4 = new TabPage();
            groupBox9 = new GroupBox();
            textBox9 = new TextBox();
            groupBox8 = new GroupBox();
            AES_Encrypt = new Button();
            AES_RndPlain = new Button();
            AES_CipherText = new TextBox();
            AES_PlainText = new TextBox();
            label17 = new Label();
            label16 = new Label();
            groupBox7 = new GroupBox();
            AES_NxtKey = new Button();
            AES_RndKey = new Button();
            AES_CurrentKey = new TextBox();
            AES_KeyTextBox = new TextBox();
            label14 = new Label();
            label15 = new Label();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            groupBox12 = new GroupBox();
            textBox11 = new TextBox();
            groupBox10 = new GroupBox();
            DH_GeneratePG = new Button();
            DH_G = new TextBox();
            DH_P = new TextBox();
            label18 = new Label();
            label19 = new Label();
            groupBox11 = new GroupBox();
            DH_PublicA = new TextBox();
            label23 = new Label();
            DH_S = new TextBox();
            label22 = new Label();
            DH_PublicB = new TextBox();
            label21 = new Label();
            DH_PrivateB = new TextBox();
            label20 = new Label();
            DH_PrivateA = new TextBox();
            label13 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            tabPage4.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox7.SuspendLayout();
            tabPage6.SuspendLayout();
            groupBox12.SuspendLayout();
            groupBox10.SuspendLayout();
            groupBox11.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.ItemSize = new Size(88, 18);
            tabControl1.Location = new Point(11, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(361, 487);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 22);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(353, 461);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "RSA";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox1);
            groupBox3.Font = new Font("Microsoft Sans Serif", 9.75F);
            groupBox3.Location = new Point(9, 349);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(334, 108);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Description";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 9.75F);
            textBox1.Location = new Point(7, 19);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(321, 83);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(RSA_Decrypt);
            groupBox2.Controls.Add(RSA_Encrypt);
            groupBox2.Controls.Add(RSA_RndKey);
            groupBox2.Controls.Add(RSA_CipherText);
            groupBox2.Controls.Add(RSA_KeyTextBox);
            groupBox2.Controls.Add(RSA_PlainText);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Microsoft Sans Serif", 9.75F);
            groupBox2.Location = new Point(9, 176);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(334, 153);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Encryption";
            // 
            // RSA_Decrypt
            // 
            RSA_Decrypt.Enabled = false;
            RSA_Decrypt.Location = new Point(229, 115);
            RSA_Decrypt.Name = "RSA_Decrypt";
            RSA_Decrypt.Size = new Size(75, 23);
            RSA_Decrypt.TabIndex = 5;
            RSA_Decrypt.Text = "Decrypt";
            RSA_Decrypt.UseVisualStyleBackColor = true;
            RSA_Decrypt.Click += RSA_Decrypt_Click;
            // 
            // RSA_Encrypt
            // 
            RSA_Encrypt.Enabled = false;
            RSA_Encrypt.Location = new Point(130, 115);
            RSA_Encrypt.Name = "RSA_Encrypt";
            RSA_Encrypt.Size = new Size(75, 23);
            RSA_Encrypt.TabIndex = 4;
            RSA_Encrypt.Text = "Encrypt";
            RSA_Encrypt.UseVisualStyleBackColor = true;
            RSA_Encrypt.Click += RSA_Encrypt_Click;
            // 
            // RSA_RndKey
            // 
            RSA_RndKey.Location = new Point(20, 115);
            RSA_RndKey.Name = "RSA_RndKey";
            RSA_RndKey.Size = new Size(94, 23);
            RSA_RndKey.TabIndex = 3;
            RSA_RndKey.Text = "Random Key";
            RSA_RndKey.UseVisualStyleBackColor = true;
            RSA_RndKey.Click += RSA_RndKey_Click;
            // 
            // RSA_CipherText
            // 
            RSA_CipherText.Cursor = Cursors.IBeam;
            RSA_CipherText.Location = new Point(193, 84);
            RSA_CipherText.Name = "RSA_CipherText";
            RSA_CipherText.Size = new Size(121, 22);
            RSA_CipherText.TabIndex = 2;
            RSA_CipherText.TextChanged += RSA_TextChanged;
            RSA_CipherText.KeyPress += OnDigit_KeyPress;
            // 
            // RSA_KeyTextBox
            // 
            RSA_KeyTextBox.Cursor = Cursors.IBeam;
            RSA_KeyTextBox.Location = new Point(193, 56);
            RSA_KeyTextBox.Name = "RSA_KeyTextBox";
            RSA_KeyTextBox.Size = new Size(121, 22);
            RSA_KeyTextBox.TabIndex = 1;
            RSA_KeyTextBox.TextChanged += RSA_TextChanged;
            // 
            // RSA_PlainText
            // 
            RSA_PlainText.Cursor = Cursors.IBeam;
            RSA_PlainText.Location = new Point(193, 27);
            RSA_PlainText.Name = "RSA_PlainText";
            RSA_PlainText.Size = new Size(121, 22);
            RSA_PlainText.TabIndex = 0;
            RSA_PlainText.TextChanged += RSA_TextChanged;
            RSA_PlainText.KeyPress += OnDigit_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 87);
            label6.Name = "label6";
            label6.Size = new Size(75, 16);
            label6.TabIndex = 2;
            label6.Text = "Cipher Text";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 59);
            label5.Name = "label5";
            label5.Size = new Size(62, 16);
            label5.TabIndex = 1;
            label5.Text = "Key (e, n)";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 30);
            label4.Name = "label4";
            label4.Size = new Size(66, 16);
            label4.TabIndex = 0;
            label4.Text = "Plain Text";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RSA_CalculateKey);
            groupBox1.Controls.Add(RSA_CalculatedKey);
            groupBox1.Controls.Add(RSA_SecondPrime);
            groupBox1.Controls.Add(RSA_FirstPrime);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Microsoft Sans Serif", 9.75F);
            groupBox1.Location = new Point(9, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(334, 153);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Key Generation";
            // 
            // RSA_CalculateKey
            // 
            RSA_CalculateKey.Enabled = false;
            RSA_CalculateKey.Location = new Point(92, 115);
            RSA_CalculateKey.Name = "RSA_CalculateKey";
            RSA_CalculateKey.Size = new Size(150, 23);
            RSA_CalculateKey.TabIndex = 3;
            RSA_CalculateKey.Text = "Calculate Key";
            RSA_CalculateKey.UseVisualStyleBackColor = true;
            RSA_CalculateKey.Click += RSA_CalculateKey_Click;
            // 
            // RSA_CalculatedKey
            // 
            RSA_CalculatedKey.Cursor = Cursors.IBeam;
            RSA_CalculatedKey.Enabled = false;
            RSA_CalculatedKey.Location = new Point(193, 84);
            RSA_CalculatedKey.Name = "RSA_CalculatedKey";
            RSA_CalculatedKey.ReadOnly = true;
            RSA_CalculatedKey.Size = new Size(121, 22);
            RSA_CalculatedKey.TabIndex = 2;
            // 
            // RSA_SecondPrime
            // 
            RSA_SecondPrime.Cursor = Cursors.IBeam;
            RSA_SecondPrime.Location = new Point(193, 56);
            RSA_SecondPrime.Name = "RSA_SecondPrime";
            RSA_SecondPrime.Size = new Size(121, 22);
            RSA_SecondPrime.TabIndex = 1;
            RSA_SecondPrime.TextChanged += RSA_TextChanged;
            RSA_SecondPrime.KeyPress += OnDigit_KeyPress;
            // 
            // RSA_FirstPrime
            // 
            RSA_FirstPrime.Cursor = Cursors.IBeam;
            RSA_FirstPrime.Location = new Point(193, 27);
            RSA_FirstPrime.Name = "RSA_FirstPrime";
            RSA_FirstPrime.Size = new Size(121, 22);
            RSA_FirstPrime.TabIndex = 0;
            RSA_FirstPrime.TextChanged += RSA_TextChanged;
            RSA_FirstPrime.KeyPress += OnDigit_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 87);
            label3.Name = "label3";
            label3.Size = new Size(62, 16);
            label3.TabIndex = 2;
            label3.Text = "Key (e, n)";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 59);
            label2.Name = "label2";
            label2.Size = new Size(67, 16);
            label2.TabIndex = 1;
            label2.Text = "2nd Prime";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 30);
            label1.Name = "label1";
            label1.Size = new Size(62, 16);
            label1.TabIndex = 0;
            label1.Text = "1st Prime";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox6);
            tabPage2.Controls.Add(groupBox5);
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Location = new Point(4, 22);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(353, 461);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "DES";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(textBox8);
            groupBox6.Font = new Font("Microsoft Sans Serif", 9.75F);
            groupBox6.Location = new Point(9, 349);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(334, 108);
            groupBox6.TabIndex = 4;
            groupBox6.TabStop = false;
            groupBox6.Text = "Description";
            // 
            // textBox8
            // 
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Font = new Font("Microsoft Sans Serif", 9.75F);
            textBox8.Location = new Point(7, 19);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(321, 83);
            textBox8.TabIndex = 0;
            textBox8.Text = resources.GetString("textBox8.Text");
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(SDES_Encrypt);
            groupBox5.Controls.Add(SDES_RndKey);
            groupBox5.Controls.Add(SDES_RndPlain);
            groupBox5.Controls.Add(SDES_CipherText);
            groupBox5.Controls.Add(SDES_KeyTextBox);
            groupBox5.Controls.Add(SDES_PlainText);
            groupBox5.Controls.Add(label10);
            groupBox5.Controls.Add(label11);
            groupBox5.Controls.Add(label12);
            groupBox5.Font = new Font("Microsoft Sans Serif", 9.75F);
            groupBox5.Location = new Point(9, 176);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(334, 153);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            groupBox5.Text = "SDES Encryption (8-bit)";
            // 
            // SDES_Encrypt
            // 
            SDES_Encrypt.Enabled = false;
            SDES_Encrypt.Location = new Point(242, 115);
            SDES_Encrypt.Name = "SDES_Encrypt";
            SDES_Encrypt.Size = new Size(75, 23);
            SDES_Encrypt.TabIndex = 5;
            SDES_Encrypt.Text = "Encrypt";
            SDES_Encrypt.UseVisualStyleBackColor = true;
            SDES_Encrypt.Click += SDES_Encrypt_Click;
            // 
            // SDES_RndKey
            // 
            SDES_RndKey.Location = new Point(135, 115);
            SDES_RndKey.Name = "SDES_RndKey";
            SDES_RndKey.Size = new Size(95, 23);
            SDES_RndKey.TabIndex = 4;
            SDES_RndKey.Text = "Random Key";
            SDES_RndKey.UseVisualStyleBackColor = true;
            SDES_RndKey.Click += SDES_Rnd_Click;
            // 
            // SDES_RndPlain
            // 
            SDES_RndPlain.Location = new Point(18, 115);
            SDES_RndPlain.Name = "SDES_RndPlain";
            SDES_RndPlain.Size = new Size(105, 23);
            SDES_RndPlain.TabIndex = 3;
            SDES_RndPlain.Text = "Random Plain";
            SDES_RndPlain.UseVisualStyleBackColor = true;
            SDES_RndPlain.Click += SDES_Rnd_Click;
            // 
            // SDES_CipherText
            // 
            SDES_CipherText.Cursor = Cursors.IBeam;
            SDES_CipherText.Location = new Point(193, 84);
            SDES_CipherText.Name = "SDES_CipherText";
            SDES_CipherText.ReadOnly = true;
            SDES_CipherText.Size = new Size(121, 22);
            SDES_CipherText.TabIndex = 2;
            // 
            // SDES_KeyTextBox
            // 
            SDES_KeyTextBox.Cursor = Cursors.IBeam;
            SDES_KeyTextBox.Location = new Point(193, 56);
            SDES_KeyTextBox.Name = "SDES_KeyTextBox";
            SDES_KeyTextBox.ReadOnly = true;
            SDES_KeyTextBox.Size = new Size(121, 22);
            SDES_KeyTextBox.TabIndex = 1;
            SDES_KeyTextBox.TextChanged += SDES_TextChanged;
            // 
            // SDES_PlainText
            // 
            SDES_PlainText.Cursor = Cursors.IBeam;
            SDES_PlainText.Location = new Point(193, 27);
            SDES_PlainText.Name = "SDES_PlainText";
            SDES_PlainText.ReadOnly = true;
            SDES_PlainText.Size = new Size(121, 22);
            SDES_PlainText.TabIndex = 0;
            SDES_PlainText.TextChanged += SDES_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(20, 87);
            label10.Name = "label10";
            label10.Size = new Size(75, 16);
            label10.TabIndex = 2;
            label10.Text = "Cipher Text";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(20, 59);
            label11.Name = "label11";
            label11.Size = new Size(30, 16);
            label11.TabIndex = 1;
            label11.Text = "Key";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(20, 30);
            label12.Name = "label12";
            label12.Size = new Size(66, 16);
            label12.TabIndex = 0;
            label12.Text = "Plain Text";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(DES_Encrypt);
            groupBox4.Controls.Add(DES_RndKey);
            groupBox4.Controls.Add(DES_RndPlain);
            groupBox4.Controls.Add(DES_CipherText);
            groupBox4.Controls.Add(DES_KeyTextBox);
            groupBox4.Controls.Add(DES_PlainText);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(label9);
            groupBox4.Font = new Font("Microsoft Sans Serif", 9.75F);
            groupBox4.Location = new Point(9, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(334, 153);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "DES Encryption (64-bit)";
            // 
            // DES_Encrypt
            // 
            DES_Encrypt.Enabled = false;
            DES_Encrypt.Location = new Point(242, 115);
            DES_Encrypt.Name = "DES_Encrypt";
            DES_Encrypt.Size = new Size(75, 23);
            DES_Encrypt.TabIndex = 5;
            DES_Encrypt.Text = "Encrypt";
            DES_Encrypt.UseVisualStyleBackColor = true;
            DES_Encrypt.Click += DES_Encrypt_Click;
            // 
            // DES_RndKey
            // 
            DES_RndKey.Location = new Point(135, 115);
            DES_RndKey.Name = "DES_RndKey";
            DES_RndKey.Size = new Size(95, 23);
            DES_RndKey.TabIndex = 4;
            DES_RndKey.Text = "Random Key";
            DES_RndKey.UseVisualStyleBackColor = true;
            DES_RndKey.Click += DES_Rnd_Click;
            // 
            // DES_RndPlain
            // 
            DES_RndPlain.Location = new Point(18, 115);
            DES_RndPlain.Name = "DES_RndPlain";
            DES_RndPlain.Size = new Size(105, 23);
            DES_RndPlain.TabIndex = 3;
            DES_RndPlain.Text = "Random Plain";
            DES_RndPlain.UseVisualStyleBackColor = true;
            DES_RndPlain.Click += DES_Rnd_Click;
            // 
            // DES_CipherText
            // 
            DES_CipherText.Cursor = Cursors.IBeam;
            DES_CipherText.Location = new Point(193, 84);
            DES_CipherText.Name = "DES_CipherText";
            DES_CipherText.ReadOnly = true;
            DES_CipherText.Size = new Size(121, 22);
            DES_CipherText.TabIndex = 2;
            // 
            // DES_KeyTextBox
            // 
            DES_KeyTextBox.Cursor = Cursors.IBeam;
            DES_KeyTextBox.Location = new Point(193, 56);
            DES_KeyTextBox.Name = "DES_KeyTextBox";
            DES_KeyTextBox.ReadOnly = true;
            DES_KeyTextBox.Size = new Size(121, 22);
            DES_KeyTextBox.TabIndex = 1;
            DES_KeyTextBox.TextChanged += DES_TextChanged;
            // 
            // DES_PlainText
            // 
            DES_PlainText.Cursor = Cursors.IBeam;
            DES_PlainText.Location = new Point(193, 27);
            DES_PlainText.Name = "DES_PlainText";
            DES_PlainText.ReadOnly = true;
            DES_PlainText.Size = new Size(121, 22);
            DES_PlainText.TabIndex = 0;
            DES_PlainText.TextChanged += DES_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 87);
            label7.Name = "label7";
            label7.Size = new Size(75, 16);
            label7.TabIndex = 2;
            label7.Text = "Cipher Text";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 59);
            label8.Name = "label8";
            label8.Size = new Size(30, 16);
            label8.TabIndex = 1;
            label8.Text = "Key";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 30);
            label9.Name = "label9";
            label9.Size = new Size(66, 16);
            label9.TabIndex = 0;
            label9.Text = "Plain Text";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(groupBox9);
            tabPage4.Controls.Add(groupBox8);
            tabPage4.Controls.Add(groupBox7);
            tabPage4.Location = new Point(4, 22);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(353, 461);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "AES";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(textBox9);
            groupBox9.Font = new Font("Microsoft Sans Serif", 9.75F);
            groupBox9.Location = new Point(9, 302);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(334, 146);
            groupBox9.TabIndex = 7;
            groupBox9.TabStop = false;
            groupBox9.Text = "Description";
            // 
            // textBox9
            // 
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Font = new Font("Microsoft Sans Serif", 9.75F);
            textBox9.Location = new Point(7, 19);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(321, 121);
            textBox9.TabIndex = 0;
            textBox9.Text = resources.GetString("textBox9.Text");
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(AES_Encrypt);
            groupBox8.Controls.Add(AES_RndPlain);
            groupBox8.Controls.Add(AES_CipherText);
            groupBox8.Controls.Add(AES_PlainText);
            groupBox8.Controls.Add(label17);
            groupBox8.Controls.Add(label16);
            groupBox8.Font = new Font("Microsoft Sans Serif", 9.75F);
            groupBox8.Location = new Point(9, 161);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(334, 130);
            groupBox8.TabIndex = 6;
            groupBox8.TabStop = false;
            groupBox8.Text = "AES Encryption (128-bit Key)";
            // 
            // AES_Encrypt
            // 
            AES_Encrypt.Enabled = false;
            AES_Encrypt.Location = new Point(187, 91);
            AES_Encrypt.Name = "AES_Encrypt";
            AES_Encrypt.Size = new Size(127, 23);
            AES_Encrypt.TabIndex = 5;
            AES_Encrypt.Text = "Encrypt";
            AES_Encrypt.UseVisualStyleBackColor = true;
            AES_Encrypt.Click += AES_Encrypt_Click;
            // 
            // AES_RndPlain
            // 
            AES_RndPlain.Location = new Point(20, 91);
            AES_RndPlain.Name = "AES_RndPlain";
            AES_RndPlain.Size = new Size(127, 23);
            AES_RndPlain.TabIndex = 3;
            AES_RndPlain.Text = "Random Plain";
            AES_RndPlain.UseVisualStyleBackColor = true;
            AES_RndPlain.Click += AES_Rnd_Click;
            // 
            // AES_CipherText
            // 
            AES_CipherText.Cursor = Cursors.IBeam;
            AES_CipherText.Location = new Point(193, 56);
            AES_CipherText.Name = "AES_CipherText";
            AES_CipherText.ReadOnly = true;
            AES_CipherText.Size = new Size(121, 22);
            AES_CipherText.TabIndex = 2;
            // 
            // AES_PlainText
            // 
            AES_PlainText.Cursor = Cursors.IBeam;
            AES_PlainText.Location = new Point(193, 21);
            AES_PlainText.Name = "AES_PlainText";
            AES_PlainText.ReadOnly = true;
            AES_PlainText.Size = new Size(121, 22);
            AES_PlainText.TabIndex = 0;
            AES_PlainText.TextChanged += AES_TextChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(20, 56);
            label17.Name = "label17";
            label17.Size = new Size(75, 16);
            label17.TabIndex = 2;
            label17.Text = "Cipher Text";
            label17.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(20, 30);
            label16.Name = "label16";
            label16.Size = new Size(66, 16);
            label16.TabIndex = 0;
            label16.Text = "Plain Text";
            label16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(AES_NxtKey);
            groupBox7.Controls.Add(AES_RndKey);
            groupBox7.Controls.Add(AES_CurrentKey);
            groupBox7.Controls.Add(AES_KeyTextBox);
            groupBox7.Controls.Add(label14);
            groupBox7.Controls.Add(label15);
            groupBox7.Font = new Font("Microsoft Sans Serif", 9.75F);
            groupBox7.Location = new Point(9, 12);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(334, 138);
            groupBox7.TabIndex = 3;
            groupBox7.TabStop = false;
            groupBox7.Text = "128-Key Generation";
            // 
            // AES_NxtKey
            // 
            AES_NxtKey.Enabled = false;
            AES_NxtKey.Location = new Point(187, 94);
            AES_NxtKey.Name = "AES_NxtKey";
            AES_NxtKey.Size = new Size(127, 23);
            AES_NxtKey.TabIndex = 5;
            AES_NxtKey.Text = "Next Key";
            AES_NxtKey.UseVisualStyleBackColor = true;
            AES_NxtKey.Click += AES_NxtKey_Click;
            // 
            // AES_RndKey
            // 
            AES_RndKey.Location = new Point(20, 94);
            AES_RndKey.Name = "AES_RndKey";
            AES_RndKey.Size = new Size(127, 23);
            AES_RndKey.TabIndex = 3;
            AES_RndKey.Text = "Random Key";
            AES_RndKey.UseVisualStyleBackColor = true;
            AES_RndKey.Click += AES_Rnd_Click;
            // 
            // AES_CurrentKey
            // 
            AES_CurrentKey.Cursor = Cursors.IBeam;
            AES_CurrentKey.Location = new Point(193, 59);
            AES_CurrentKey.Name = "AES_CurrentKey";
            AES_CurrentKey.ReadOnly = true;
            AES_CurrentKey.Size = new Size(121, 22);
            AES_CurrentKey.TabIndex = 1;
            // 
            // AES_KeyTextBox
            // 
            AES_KeyTextBox.Cursor = Cursors.IBeam;
            AES_KeyTextBox.Location = new Point(193, 22);
            AES_KeyTextBox.Name = "AES_KeyTextBox";
            AES_KeyTextBox.ReadOnly = true;
            AES_KeyTextBox.Size = new Size(121, 22);
            AES_KeyTextBox.TabIndex = 0;
            AES_KeyTextBox.TextChanged += AES_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(20, 60);
            label14.Name = "label14";
            label14.Size = new Size(75, 16);
            label14.TabIndex = 1;
            label14.Text = "Current Key";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(20, 23);
            label15.Name = "label15";
            label15.Size = new Size(63, 16);
            label15.TabIndex = 0;
            label15.Text = "Initial Key";
            label15.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 22);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(353, 461);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "MD5";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(groupBox12);
            tabPage6.Controls.Add(groupBox10);
            tabPage6.Controls.Add(groupBox11);
            tabPage6.Location = new Point(4, 22);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(353, 461);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Diffie-Hellman";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // groupBox12
            // 
            groupBox12.Controls.Add(textBox11);
            groupBox12.Font = new Font("Microsoft Sans Serif", 9.75F);
            groupBox12.Location = new Point(9, 322);
            groupBox12.Name = "groupBox12";
            groupBox12.Size = new Size(334, 131);
            groupBox12.TabIndex = 5;
            groupBox12.TabStop = false;
            groupBox12.Text = "Description";
            // 
            // textBox11
            // 
            textBox11.BorderStyle = BorderStyle.None;
            textBox11.Font = new Font("Microsoft Sans Serif", 9.75F);
            textBox11.Location = new Point(7, 21);
            textBox11.Multiline = true;
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(321, 104);
            textBox11.TabIndex = 0;
            textBox11.Text = resources.GetString("textBox11.Text");
            // 
            // groupBox10
            // 
            groupBox10.Controls.Add(DH_GeneratePG);
            groupBox10.Controls.Add(DH_G);
            groupBox10.Controls.Add(DH_P);
            groupBox10.Controls.Add(label18);
            groupBox10.Controls.Add(label19);
            groupBox10.Font = new Font("Microsoft Sans Serif", 9.75F);
            groupBox10.Location = new Point(9, 3);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new Size(334, 138);
            groupBox10.TabIndex = 3;
            groupBox10.TabStop = false;
            groupBox10.Text = "Publicly shared Information";
            // 
            // DH_GeneratePG
            // 
            DH_GeneratePG.Location = new Point(88, 93);
            DH_GeneratePG.Name = "DH_GeneratePG";
            DH_GeneratePG.Size = new Size(159, 23);
            DH_GeneratePG.TabIndex = 5;
            DH_GeneratePG.Text = "Generate Public info";
            DH_GeneratePG.UseVisualStyleBackColor = true;
            DH_GeneratePG.Click += DH_GeneratePG_Click;
            // 
            // DH_G
            // 
            DH_G.Cursor = Cursors.IBeam;
            DH_G.Location = new Point(193, 60);
            DH_G.Name = "DH_G";
            DH_G.ReadOnly = true;
            DH_G.Size = new Size(121, 22);
            DH_G.TabIndex = 1;
            DH_G.TextChanged += DH_TextChanged;
            // 
            // DH_P
            // 
            DH_P.Cursor = Cursors.IBeam;
            DH_P.Location = new Point(193, 27);
            DH_P.Name = "DH_P";
            DH_P.ReadOnly = true;
            DH_P.Size = new Size(121, 22);
            DH_P.TabIndex = 0;
            DH_P.TextChanged += DH_TextChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(20, 59);
            label18.Name = "label18";
            label18.Size = new Size(80, 16);
            label18.TabIndex = 1;
            label18.Text = "Generator G";
            label18.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(20, 30);
            label19.Name = "label19";
            label19.Size = new Size(54, 16);
            label19.TabIndex = 0;
            label19.Text = "Prime P";
            label19.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox11
            // 
            groupBox11.Controls.Add(DH_PublicA);
            groupBox11.Controls.Add(label23);
            groupBox11.Controls.Add(DH_S);
            groupBox11.Controls.Add(label22);
            groupBox11.Controls.Add(DH_PublicB);
            groupBox11.Controls.Add(label21);
            groupBox11.Controls.Add(DH_PrivateB);
            groupBox11.Controls.Add(label20);
            groupBox11.Controls.Add(DH_PrivateA);
            groupBox11.Controls.Add(label13);
            groupBox11.Font = new Font("Microsoft Sans Serif", 9.75F);
            groupBox11.Location = new Point(9, 147);
            groupBox11.Name = "groupBox11";
            groupBox11.Size = new Size(334, 169);
            groupBox11.TabIndex = 4;
            groupBox11.TabStop = false;
            groupBox11.Text = "Combine secret keys ";
            // 
            // DH_PublicA
            // 
            DH_PublicA.Cursor = Cursors.IBeam;
            DH_PublicA.Location = new Point(193, 49);
            DH_PublicA.Name = "DH_PublicA";
            DH_PublicA.ReadOnly = true;
            DH_PublicA.Size = new Size(121, 22);
            DH_PublicA.TabIndex = 23;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(24, 52);
            label23.Name = "label23";
            label23.Size = new Size(82, 16);
            label23.TabIndex = 22;
            label23.Text = "Public Key A";
            label23.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DH_S
            // 
            DH_S.Cursor = Cursors.IBeam;
            DH_S.Location = new Point(193, 133);
            DH_S.Name = "DH_S";
            DH_S.ReadOnly = true;
            DH_S.Size = new Size(121, 22);
            DH_S.TabIndex = 21;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(24, 136);
            label22.Name = "label22";
            label22.Size = new Size(132, 16);
            label22.TabIndex = 20;
            label22.Text = "Private Shared Key s";
            label22.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DH_PublicB
            // 
            DH_PublicB.Cursor = Cursors.IBeam;
            DH_PublicB.Location = new Point(193, 105);
            DH_PublicB.Name = "DH_PublicB";
            DH_PublicB.ReadOnly = true;
            DH_PublicB.Size = new Size(121, 22);
            DH_PublicB.TabIndex = 18;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(24, 83);
            label21.Name = "label21";
            label21.Size = new Size(85, 16);
            label21.TabIndex = 19;
            label21.Text = "2nd Private b";
            label21.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DH_PrivateB
            // 
            DH_PrivateB.Cursor = Cursors.IBeam;
            DH_PrivateB.Location = new Point(193, 77);
            DH_PrivateB.Name = "DH_PrivateB";
            DH_PrivateB.ReadOnly = true;
            DH_PrivateB.Size = new Size(121, 22);
            DH_PrivateB.TabIndex = 16;
            DH_PrivateB.TextChanged += DH_TextChanged;
            DH_PrivateB.KeyPress += OnDigit_KeyPress;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(24, 27);
            label20.Name = "label20";
            label20.Size = new Size(80, 16);
            label20.TabIndex = 17;
            label20.Text = "1st Private a";
            label20.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DH_PrivateA
            // 
            DH_PrivateA.Cursor = Cursors.IBeam;
            DH_PrivateA.Location = new Point(193, 21);
            DH_PrivateA.Name = "DH_PrivateA";
            DH_PrivateA.ReadOnly = true;
            DH_PrivateA.Size = new Size(121, 22);
            DH_PrivateA.TabIndex = 14;
            DH_PrivateA.TextChanged += DH_TextChanged;
            DH_PrivateA.KeyPress += OnDigit_KeyPress;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(24, 108);
            label13.Name = "label13";
            label13.Size = new Size(82, 16);
            label13.TabIndex = 15;
            label13.Text = "Public Key B";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 511);
            Controls.Add(tabControl1);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cryptolysis";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            tabPage4.ResumeLayout(false);
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            tabPage6.ResumeLayout(false);
            groupBox12.ResumeLayout(false);
            groupBox12.PerformLayout();
            groupBox10.ResumeLayout(false);
            groupBox10.PerformLayout();
            groupBox11.ResumeLayout(false);
            groupBox11.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox RSA_FirstPrime;
        private Label label3;
        private Button RSA_CalculateKey;
        private TextBox RSA_CalculatedKey;
        private TextBox RSA_SecondPrime;
        private GroupBox groupBox2;
        private Label label5;
        private Label label4;
        private TextBox RSA_PlainText;
        private Label label6;
        private TextBox RSA_CipherText;
        private TextBox RSA_KeyTextBox;
        private Button RSA_RndKey;
        private Button RSA_Decrypt;
        private Button RSA_Encrypt;
        private GroupBox groupBox3;
        private TextBox textBox1;
        private GroupBox groupBox5;
        private Button SDES_Encrypt;
        private Button SDES_RndKey;
        private Button SDES_RndPlain;
        private TextBox SDES_CipherText;
        private TextBox SDES_KeyTextBox;
        private TextBox SDES_PlainText;
        private Label label10;
        private Label label11;
        private Label label12;
        private GroupBox groupBox4;
        private Button DES_Encrypt;
        private Button DES_RndKey;
        private Button DES_RndPlain;
        private TextBox DES_CipherText;
        private TextBox DES_KeyTextBox;
        private TextBox DES_PlainText;
        private Label label7;
        private Label label8;
        private Label label9;
        private GroupBox groupBox6;
        private TextBox textBox8;
        private GroupBox groupBox7;
        private Button AES_NxtKey;
        private Button AES_RndKey;
        private TextBox AES_CurrentKey;
        private TextBox AES_KeyTextBox;
        private Label label14;
        private Label label15;
        private GroupBox groupBox9;
        private TextBox textBox9;
        private GroupBox groupBox8;
        private Button AES_Encrypt;
        private Button AES_RndPlain;
        private TextBox AES_CipherText;
        private TextBox AES_PlainText;
        private Label label17;
        private Label label16;
        private GroupBox groupBox10;
        private Button DH_GeneratePG;
        private TextBox DH_G;
        private TextBox DH_P;
        private Label label18;
        private Label label19;
        private GroupBox groupBox11;
        private TextBox DH_PublicA;
        private Label label23;
        private TextBox DH_S;
        private Label label22;
        private TextBox DH_PublicB;
        private Label label21;
        private TextBox DH_PrivateB;
        private Label label20;
        private TextBox DH_PrivateA;
        private Label label13;
        private GroupBox groupBox12;
        private TextBox textBox11;
    }
}
