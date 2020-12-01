using System;
using System.Linq;

namespace CS.Impl._01_Basic
{
    public class Sentence
    {
        public string Reverse(string sentence)
        {
            var words = sentence.Split(" ");
            var result = "";

            for (int i = words.Length - 1; i >= 0; i--)
            {
                result += $"{words[i]} ";
            }

            return result.Remove(result.Length - 1, 1);
        }
    }
}