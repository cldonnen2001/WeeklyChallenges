using System;
using System.Collections.Generic;
using System.Linq;



namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;
            for (int e = 0; e < numbers.Length; e++)
            {
                if (numbers[e] % 2 == 0)
                    sum += numbers[e];

                else if (numbers[e] % 2 != 0)
                {
                    sum -= numbers[e];
                }
            }
            return sum;

        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var list = new List<int>() { str1.Length, str2.Length, str3.Length, str4.Length };
            return list.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var list = new List<int>() { number1, number2, number3, number4 };
            return list.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
            //string trimmed = string.Concat(biz.Name.Where(c => !Char.IsWhiteSpace(c)));
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3 && sideLength3 + sideLength2 > sideLength1 && sideLength3 + sideLength1 > sideLength2)
            {
                return true;
            }
            else
            {
                return false;
            };
        }

        public bool IsStringANumber(string input)
        {
            if (input == null || input == "")
            {
                return false;
            }
            if (input.All(c => char.IsDigit(c)) == true || input.Contains('-') || input.Contains('.'))
            {
                return true;
            }
            else
                return false;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            //var resultNull = objs.Where(x => x == null).Count();
            //var result = objs.Where(x => x != null).Count();
            //return resultNull > result ? true : false;

            var numberOfNulls = new List<object>();
            foreach (var x in objs)
            {
                if (x == null)
                {
                    numberOfNulls.Add(x);
                }
            }
            if (numberOfNulls.Count() > objs.Length / 2)
            {
                return true;
            }
            else
                return false;

        }

        public double AverageEvens(int[] numbers) 
        {
           return numbers == null || numbers.Length == 0 || numbers.Where(x => x % 2 == 0).Count() == 0 ? 0 : numbers.Where(x => x % 2 == 0).Average();

            //    var list = new List<double>();
            //    if (numbers == null || numbers.Length == 0)
            //    {
            //        return 0;
            //    }
            //    foreach (var x in numbers)
            //    {
            //        if (x % 2 == 0)
            //        {
            //            list.Add(x);
            //        }
            //    }
            //    if (list.Count() == 0)
            //    {
            //        return 0;
            //    }
            //    return list.Average();
        }

        public int Factorial(int number)
        {
            int fact1 = number;

            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (number == 0)
            {
                return 1;
            }

            for (int i = number - 1; i >= 1; i--)
            {
                fact1 *= i;
            }
            return fact1;
        
        }
    }
}
