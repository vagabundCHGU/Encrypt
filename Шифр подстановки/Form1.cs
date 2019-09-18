﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Шифр_подстановки
{
    public partial class Form1 : Form
    {
        public Substitution substitution = new Substitution();

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

        private void InputText_Leave(object sender, EventArgs e)
        {
            if (InputText.Text.Length % substitution.getBlock() != 0)
            {
                InputText.Text += '0';
            }
        }

        private void InputText_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == '0' || ch == '1' || ch == '2' || ch == '3' || ch == '4')
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
