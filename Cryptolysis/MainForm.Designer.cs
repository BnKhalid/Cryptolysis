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
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
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
            groupBox2.Location = new Point(10, 178);
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
            groupBox1.Location = new Point(10, 4);
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
            tabPage2.Location = new Point(4, 22);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(353, 461);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "DES";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 22);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(353, 461);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "SDES";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 22);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(353, 461);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "AES";
            tabPage4.UseVisualStyleBackColor = true;
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
            tabPage6.Location = new Point(4, 22);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(353, 461);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Diffie-Hellman";
            tabPage6.UseVisualStyleBackColor = true;
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
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
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
    }
}
