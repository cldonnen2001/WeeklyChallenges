using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)  //  boolean array  bool[] is an array,  differentce list can change   value type followed by [] is array   variable by [] is indexing  //  vals is the name of the boolean array
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
            //return val.First();
        }

        public char GetLastLetterOfString(string val)  
        {
            //return val[val.Length-1];       // interger so will be index #, this is bracket notation [] this is index not necessarily array []  so [val.Length] is the length (("test", 't') this is length of 4)
                                              //[] has to have integer in bracket because counting

             return val.Last();              // linq method
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return divisor == 0 ? 0 : dividend / divisor;  // inline if statement
            //if (divisor == 0)
            //    return 0;
            //return dividend/divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            //return nums[nums.Length - 1] - nums[0];
            return nums.Last()- nums.First();
        }

        public int[] GetOddsBelow100()  // not passing in parameters so doing a fact, not all codes baths return a value means add "return ____"
        {
            //int oddIncrement = 1;
            //int[] x = new int[50];
            //for (int i = 0; i < 50; i++)   //  do not have to use the letter i can use words or other letters,  // int i is declaring and intializing 
            //{
            //    x[i] = oddIncrement;        // one equal sign is the assignment operator takes what is on the left and asigns to the right, not allowed to increment a number can  name, i starts at 0 ++i is pre increment
            //    oddIncrement += 2;
            //}
            //return x;

            int odd = 1;
            int[] arr = new int[50];
            for (int i = 0; i < arr.Length; i++)   // int i is declaring and intializing 
            {
                arr[i] = odd;                       // one equal sign is the assignment operator takes what is on the left and asigns to the right, not allowed to increment a number can  name, i starts at 0 ++i is pre increment
                odd += 2;
            }
            return arr;
        }

        public void ChangeAllElementsToUppercase(string[] words)  // void is null of a return, so can not do return words.ToUpper();   // google "how to upper case string in array"
        {
            for (int i = 0; i < words.Length; i++)                //  need to use for loop because parameter is an array, so to access each thing in an array use the for loop (need to access the elements in the array access by using a for loop)
            {
                words[i] = words[i].ToUpper();                    //bracket notation
            }
            
        }
    }
}
