using System;
using System.Collections.Generic;
using System.Linq;

namespace Шифр_подстановки
{
    public class Transposition
    {
        private Dictionary<int, int> dictionary = new Dictionary<int, int>(52);
        private string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        private int block = 18;
        private int count;
        Random random = new Random();

        public string getAlphabet()
        {
            return alphabet;
        }

        public Dictionary<int, int> getTable(string text)
        {
            int[] randPos = Enumerable.Range(1, text.Length).ToArray();
            for (int i = text.Length - 1; i >= 0; i--)
            {
                int j = random.Next(i + 1);
                int temp = randPos[j];
                randPos[j] = randPos[i];
                randPos[i] = temp;

                dictionary.Add(text.Length - i, randPos[i]);
            }
            return dictionary;
        }

        public string Encrypt(string text, string EncryptText)
        {
            count = text.Length;

            for (int i = 0; i < text.Length; i++)
            {
                if (text.Length % block != 0)
                {
                    text += 'g';
                }
            }

            getTable(text);

            for (int i = 0; i <= text.Length; i++)
            {
                foreach(var dic in dictionary)
                {
                    if(dic.Key == i)
                    {
                        EncryptText += text[dic.Value - 1];
                    }
                }
            }
            return EncryptText;
        }

        public string Decrypt(string text, string DecryptText)
        {
            for (int i = 0; i <= text.Length; i++)
            {
                foreach (var dic in dictionary)
                {
                    if (dic.Value == i)
                    {
                        DecryptText += text[dic.Key - 1];
                    }
                }
            }

            if (count != text.Length)
                DecryptText = DecryptText.Remove(count, DecryptText.Length - count);

            return DecryptText;
        }
    }
}
