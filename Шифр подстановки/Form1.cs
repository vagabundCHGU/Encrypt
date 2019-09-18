using System;
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
        private Dictionary<char, string> keyValues = new Dictionary<char, string>(25);
        const int block = 2;
        private int count = 0;
        private string alphabet = "abcdefghijklmnopqrstuvwx";

        private string[] table = {"00","01","02","03","04",
                                  "10","11","12","13","14",
                                  "20","21","22","23","24",
                                  "30","31","31","33","34",
                                  "40","41","42","43","44"};

        public Form1()
        {
            InitializeComponent();
        }

        private Dictionary<char,string> CreateTable()
        {
            foreach (var ch in alphabet)
            {
                keyValues.Add(ch, table[count]);
                count++;
            }
            return keyValues;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateTable();
            InputText.Select();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            EncryptText.Text = null;
            DecryptText.Text = null;
            Encrypt(InputText.Text);
            Decrypt(EncryptText.Text);
        }
        
        private void Encrypt(string text)
        {
            string key = "";

            for (int i = 0; i < text.Length; i++) 
            {
                key += text[i];
                if (key.Length == 2)
                {
                    EncryptText.Text += keyValues.Where(x => x.Value == key).FirstOrDefault().Key;
                    key = "";
                }
            }
        }

        private void Decrypt(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if(text.Contains(keyValues.Where(x=>x.Key == text[i]).FirstOrDefault().Key))
                {
                    DecryptText.Text += keyValues.Where(x => x.Key == text[i]).FirstOrDefault().Value;
                }
            }
        }

        private void InputText_Leave(object sender, EventArgs e)
        {
            if (InputText.Text.Length % block != 0)
            {
                InputText.Text += '0';
            }
        }
    }
}
