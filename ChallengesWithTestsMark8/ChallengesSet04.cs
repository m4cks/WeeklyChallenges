using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int total = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    total += numbers[i];
                } else
                {
                    total -= numbers[i];
                }
            }
            return total;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int shortest = str1.Length;
            if(shortest > str2.Length)
            {
                shortest = str2.Length;
            }
            if(shortest > str3.Length)
            {
                shortest = str3.Length;
            }
            if(shortest > str4.Length)
            {
                shortest = str4.Length;
            }
            return shortest;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int smallest = number1;
            if(smallest > number2)
            {
                smallest = number2;
            }
            if(smallest > number3)
            {
                smallest = number3;
            }
            if(smallest > number4)
            {
                smallest = number4;
            }
            return smallest;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {

            if(sideLength1 >= sideLength2 && sideLength1 >= sideLength3)
            {
                return sideLength1 < sideLength2 + sideLength3;
            } else if(sideLength2 >= sideLength1 && sideLength2 >= sideLength3)
            {
                return sideLength2 < sideLength1 + sideLength3;
            } else if(sideLength3 >= sideLength2 && sideLength3 >= sideLength1)
            {
                return sideLength3 < sideLength2 + sideLength1;
            } else
            {
                return false;
            }
            

        }

        public bool IsStringANumber(string input)
        {
            if(input == "")
            {
                return false;
            }
            try
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (!Char.IsDigit(input[i]) && input[i] != '.' && input[i] != '-')
                    {
                        return false;
                    }
                }
            } catch
            {
                return false;
            }
            
            return true;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int valNulls = 0;
            for(int i = 0; i < objs.Length; i++)
            {
                if (objs[i] == null)
                {
                    valNulls++;
                }
            }
            return 0 > (objs.Length / 2) - valNulls;
        }

        public double AverageEvens(int[] numbers)
        {
            double sumOfEvens = 0;
            int numOfEvens = 0;
            try
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        sumOfEvens += numbers[i];
                        numOfEvens++;
                    }
                }
            } catch
            {
                return 0;
            }
            if(numOfEvens == 0)
            {
                return 0;
            } else
            {
                return sumOfEvens / numOfEvens;
            }
           
        }

        public int Factorial(int number)
        {
            if(number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            int sum = 1;
            for (int i = 1; i <= number; i++)
            {
                sum *= i;
            }
            return sum;
        }
    }
}
