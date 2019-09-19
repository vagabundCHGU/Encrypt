using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Шифр_подстановки
{
    public class Substitution
    {
        private Dictionary<string, string> keyValues = new Dictionary<string, string>(25);
        private int block = 2;
        private int count;
        private string[] table;
        private string str;

        public int getBlock()
        {
            return block;
        }

        public Dictionary<string, string> CreateTable()
        {
            try
            {
                using (StreamReader streamReader = new StreamReader("Шифр подстановки.txt"))
                {
                    while (!streamReader.EndOfStream)
                    {
                        string line = streamReader.ReadLine();
                        table = line.Split(';');
                        keyValues.Add(table[0], table[1]);
                    }
                }
            }
            catch
            {
                throw new FileNotFoundException();
            }

            return keyValues;
        }

        public string Encrypt(string text, string EncryptText)
        {
            count = text.Length;

            for (int i = 0; i < text.Length; i++)
            {
                if(text.Length % block !=0)
                {
                    text += '0';
                }
            }

            for (int i = 0; i < text.Length; i++)
            {
                str += text[i];
                if (str.Length == 2)
                {
                    EncryptText += keyValues.Where(x => x.Value == str).FirstOrDefault().Key;
                    str = "";
                }
            }
            return EncryptText;
        }

        public string Decrypt(string text, string DecryptText)
        {
            for (int i = 0; i < text.Length; i++)
            {
                str += text[i];
                if (str.Length == 2)
                {
                    DecryptText += keyValues.Where(x => x.Key == str).FirstOrDefault().Value;
                    str = "";
                }
            }

            if (count != text.Length)
                DecryptText = DecryptText.Remove(count, 1);

            return DecryptText;
        }
    }
}
