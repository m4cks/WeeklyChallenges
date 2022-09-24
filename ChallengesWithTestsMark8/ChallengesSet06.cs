using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            try
            {
                if (ignoreCase)
                {
                    word = word.ToLower();
                    foreach (var item in words)
                    {
                        if (item.ToLower() == word)
                        {
                            return true;
                        }
                    }
                }
                else
                {
                    foreach (var item in words)
                    {
                        if (item == word)
                        {
                            return true;
                        }
                    }
                }
            } catch
            {

            }
            
            return false;
            
        }

        public bool IsPrimeNumber(int num)
        {
            if(num <= 1)
            {
                return false;
            }
            for(int i = 2; i < num; i++)
            {
                if(num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            var indexOfLastUniqueLetter = -1;
            int[] characters = new int[26]; //A = 65
            int[] indexOfCharacters = new int[26];
            int index;
            for(int i = 0; i < str.Length; i++)
            {
                index = Char.ToUpper(str[i]) - 65;
                characters[index]++;
                indexOfCharacters[index] = i;
            }
            for(int i = 0; i < characters.Length; i++)
            {
                if(characters[i] == 1 && indexOfCharacters[i] > indexOfLastUniqueLetter)
                {
                    indexOfLastUniqueLetter = indexOfCharacters[i];
                }
            }
            return indexOfLastUniqueLetter;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int consecutives = 0;
            int maxConsecutive = 0;
            for(int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i-1] == numbers[i])
                {
                    consecutives++;
                    if(consecutives >= maxConsecutive)
                    {
                        maxConsecutive = consecutives + 1;
                    }
                } else
                {
                    consecutives = 0;
                }
            }
            return maxConsecutive;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            double[] doubles;
            try
            {
                doubles = new double[elements.Count / n];
            }
            catch
            {
                return new double[0];
            }

            var counter = 0;
            for (int i = 0; i < elements.Count; i++)
            {
                if ((i + 1) % n == 0)
                {
                    doubles[counter] = elements[i];
                    counter++;
                }
            }
            return doubles;
        }
    }
}
