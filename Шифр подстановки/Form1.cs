using System;
using System.Windows.Forms;

namespace Шифр_подстановки
{
    public partial class Form1 : Form
    {
        private Substitution substitution = new Substitution();
        private Transposition transposition = new Transposition();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            substitution.CreateTable();
            InputText.Select();
        }

        private void EncryptDecryptButton_Click(object sender, EventArgs e)
        {
            EncryptText.Text = null;
            DecryptText.Text = null;
            EncryptText.Text = substitution.Encrypt(InputText.Text, EncryptText.Text);
            DecryptText.Text = substitution.Decrypt(EncryptText.Text, DecryptText.Text);
        }

        private void InputText_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == '0' || ch == '1' || ch == '2' || ch == '3' || ch == '4')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void EncryptDecryptTransposition_Click(object sender, EventArgs e)
        {
            EncryptTransposition.Text = null;
            DecryptTransposition.Text = null;
            EncryptTransposition.Text = transposition.Encrypt(InputTransposition.Text, EncryptTransposition.Text);
            DecryptTransposition.Text = transposition.Decrypt(EncryptTransposition.Text, DecryptTransposition.Text);
        }

        private void InputTransposition_KeyPress(object sender, KeyPressEventArgs e)
        {
            string str = transposition.getAlphabet();
            var ch = e.KeyChar;
            bool flag = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (ch == str[i])
                    flag = true;
            }
            if (flag)
                e.Handled = false;
            else
                e.Handled = true;
            flag = false;
        }
    }
}
