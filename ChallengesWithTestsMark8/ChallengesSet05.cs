using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int numDivisible = startNumber + 1;
            while(numDivisible % n != 0)
            {
                numDivisible++;
            }
            return numDivisible;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for(int i = 0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }
            if (numbers.Length == 1)
            {
                return true;
            }
            
            for(int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i-1] > numbers[i])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            var sum = 0;
            try
            {
                for (var i = 1; i < numbers.Length; i++)
                {
                    if (numbers[i - 1] % 2 == 0)
                    {
                        sum += numbers[i];
                    }
                }
            } catch
            {

            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            var sentence = "";
            try
            {
                if(words.Length > 0)
                {
                    for (int i = 0; i < words.Length; i++)
                    {
                        var word = "";
                        for (int j = 0; j < words[i].Length; j++)
                        {
                            if (Char.IsLetter(words[i][j]) || Char.IsPunctuation(words[i][j]))
                            {
                                word += words[i][j];
                            }
                        }
                        if (word != "")
                        {
                            word += " ";
                        }
                        sentence += word;
                    }
                }
                sentence = sentence.Substring(0, sentence.Length - 1) + ".";
            } catch
            {
                return sentence;
            }
            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            double[] doubles;
            try
            {
                doubles = new double[elements.Count / 4];
            } catch
            {
                return new double[0];
            }
            
            var counter = 0;
            for(int i = 0; i < elements.Count; i++)
            {
                if((i+1) % 4 == 0)
                {
                    doubles[counter] = elements[i];
                    counter++;
                }
            }
            return doubles;
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
