using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals.Contains(false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            return numbers != null && numbers.Where(x => x % 2 != 0).Sum() % 2 != 0;  
            //if (numbers == null)
            //    return false;
            //return Math.Abs(numbers.Sum()) % 2 == 1;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            return password.Any(letter => char.IsDigit(letter)) &&  password.Any(letter => char.IsLower(letter)) && password.Any(letter=> char.IsUpper(letter));
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            //return val[val.Length-1];  // interger so will be index number

             return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return divisor == 0 ? 0 : dividend / divisor;  // inline if
            //if (divisor == 0)
            //    return 0;
            //return dividend/divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            //return nums[nums.Length - 1] - nums[0];
            return nums.Last()- nums.First();
        }

        public int[] GetOddsBelow100()  // not passing in parameters so doing a fact
        {
            int oddIncrement = 1;
            int[] x = new int[50];
            for (int i = 0; i < 50; i++)
            {
                x[i] = oddIncrement;
                oddIncrement += 2;
            }
            return x;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
