using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Шифр_подстановки
{
    public class Substitution
    {
        private Dictionary<char, string> keyValues = new Dictionary<char, string>(25);
        private int block = 2;
        private int count = 0;
        private string alphabet = "abcdefghijklmnopqrstuvwxy";

        private string[] table = {"00","01","02","03","04",
                                  "10","11","12","13","14",
                                  "20","21","22","23","24",
                                  "30","31","32","33","34",
                                  "40","41","42","43","44"};

        public int getBlock()
        {
            return block;
        }

        public Dictionary<char, string> CreateTable()
        {
            foreach (var ch in alphabet)
            {
                keyValues.Add(ch, table[count]);
                count++;
            }
            return keyValues;
        }

        public string Encrypt(string text, string EncryptText)
        {
            string key = "";

            for (int i = 0; i < text.Length; i++)
            {
                key += text[i];
                if (key.Length == 2)
                {
                    EncryptText += keyValues.Where(x => x.Value == key).FirstOrDefault().Key;
                    key = "";
                }
            }
            return EncryptText;
        }

        public string Decrypt(string text, string DecryptText)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text.Contains(keyValues.Where(x => x.Key == text[i]).FirstOrDefault().Key))
                {
                    DecryptText += keyValues.Where(x => x.Key == text[i]).FirstOrDefault().Value;
                }
            }
            return DecryptText;
        }
    }
}
