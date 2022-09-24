using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            if(number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            double min = 0;
            double max = 0;
            int i = 0;
            if (numbers != null)
            {
                foreach (double num in numbers)
                {
                    if (i == 0)
                    {
                        min = num;
                        max = num;
                    }

                    if (num < min)
                    {
                        min = num;
                    }
                    else if (num > max)
                    {
                        max = num;
                    }
                    i++;
                }
            }
           
            return min + max;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
           if(str1.Length <= str2.Length)
            {
                return str1.Length;
            } else
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            var sum = 0;
            if (numbers == null)
                return sum;
            for(int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            var evenSum = 0;
            if (numbers == null)
                return evenSum;
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i]%2 == 0)
                {
                    evenSum += numbers[i];
                }
            }

            return evenSum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            var sum = 0;
            if(numbers == null)
            {
                return false;
            }
            foreach(int num in numbers)
            {
                sum += num;
            }

            return sum%2!=0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if(number <= 0)
            {
                return 0;
            }
            else if (number % 2 == 0)
            {
                return number / 2;
            } 
            else 
            {
                return (number - 1) / 2;    
            }
        }
    }
}
