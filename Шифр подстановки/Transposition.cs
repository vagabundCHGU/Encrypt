using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Шифр_подстановки
{
    public class Transposition
    {
        private Dictionary<int, char> dictionary = new Dictionary<int, char>(52);
        private string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        private int block = 18;
        Random random = new Random();

        public Dictionary<int, char> getTable(string text)
        {
            int[] key = Enumerable.Range(0, text.Length).ToArray();
            for (int i = text.Length - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);
                int temp = key[j];
                key[j] = key[i];
                key[i] = temp;

                dictionary.Add(key[i], text[i]);
            }
            return dictionary;
        }
    }
}
