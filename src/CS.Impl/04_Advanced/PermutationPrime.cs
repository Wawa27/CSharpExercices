using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CS.Impl._02_Intermediate;

namespace CS.Impl._04_Advanced
{
    public class PermutationPrime
    {
        public int[] GetPermutationPrimes(int upperBound)
        {
            var output = new List<int>();
            var recursion = new Recursion();
            
            for (var i = 2; i < upperBound; i++)
            {
                var permutations = GetPermutations(i + "").ToArray();
                var j = 0;
                bool isPrime;
                do
                {
                    var permutation = int.Parse(permutations[j++]);
                    isPrime = recursion.IsPrime(permutation);
                } while (isPrime && j < permutations.Length);

                if (isPrime && j == permutations.Length)
                {
                    output.Add(i);
                }
            }

            return output.ToArray();
        }

        private IEnumerable<string> GetPermutations(string set)
        {
            var output = new List<string>();
            if (set.Length == 1)
            {
                output.Add(set);
            }
            else
            {
                foreach (var c in set)
                {
                    var tail = set.Remove(set.IndexOf(c), 1);
                    foreach (var tailPerms in GetPermutations(tail))
                    {
                        output.Add(c + tailPerms);
                    }
                }
            }

            return output;
        }
    }
}