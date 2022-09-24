using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for(int i = 0; i < vals.Length; i++)
            {
                if(!vals[i])
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {//1 2 2 3 4
            var sum = 0;
            if(numbers != null)
            {
                foreach (int num in numbers)
                {
                    sum += num;
                }
            } 
            else
            {
                return false;
            }
            return sum % 2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool hasDigit = false;
            bool hasUpper = false;
            bool hasLower = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (!hasDigit && char.IsDigit(password[i]))
                {
                    hasDigit = true;
                }
                if (!hasLower && char.IsLower(password[i]))
                {
                    hasLower = true;
                }
                if (!hasUpper && char.IsUpper(password[i]))
                {
                    hasUpper = true;
                }
            }
            return hasDigit && hasUpper && hasLower;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if(divisor == 0 )
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int[] returnable = new int[50];
            for(int i = 0; i < returnable.Length; i++)
            {
                returnable[i] = 1 + i*2;
            }
            return returnable;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        { 
            for (int i = 0; i < words.Length; i++)
            {
                string replacable = "";
                for (int j = 0; j < words[i].Length; j++)
                {
                    replacable += Char.ToUpper(words[i][j]);
                }
                words[i] = replacable;
            }
        }
        
    }
}
