﻿using System;
using System.Collections.Generic;

namespace CS.Impl._02_Intermediate
{
    public class Recursion
    {
        public IEnumerable<int> GetNaturalNumbers(int n)
        {
            return GetNaturalNumbers(new List<int>(), 1, n);
        }

        private IEnumerable<int> GetNaturalNumbers(List<int> naturalNumbers, int current, int max)
        {
            // Condition de sortie
            if (current > max)
            {
                return naturalNumbers;
            }

            naturalNumbers.Add(current);
            return GetNaturalNumbers(naturalNumbers, current + 1, max);
        }

        public int SumNaturalNumbers(int n)
        {
            return ComputeSum(0, n);
        }

        private int ComputeSum(int min, int current)
        {
            if (current < 0)
            {
                return min;
            }

            min += current;

            return ComputeSum(min, current - 1);
        }

        public bool IsPrime(int n)
        {
            return IsPrime(n, n - 1);
        }

        private bool IsPrime(int n, int current)
        {
            if (current == 1)
            {
                return true;
            }

            return n % current != 0 && IsPrime(n, current - 1);
        }

        public bool IsPalindrome(string text)
        {
            if (text.Length == 1 || text.Length == 0)
            {
                return true;
            }
            
            if (text[0] != text[text.Length - 1])
            {
                return false;
            }

            text = text.Remove(0, 1);
            text = text.Remove(text.Length - 1, 1);

            return IsPalindrome(text);
        }
    }
}