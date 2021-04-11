using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)  // this was showing
            {
                return true;
            }
            else
            {
                return false;
            }
            // return num1 == num2 ? true : false;       this is a 2nd way via John
            //  return num 1 == num2;                    this is a 3rd way via John
        }

        public double Subtract(double minuend, double subtrahend)
        {
            return minuend - subtrahend;                        // my way

             
             //double result = minuend - subtrahend:             2nd way John
             // return result;
        }

        public int Add(int number1, int number2)
        {
            return number1 + number2; //  my way 

            //long way would be vai John:
            //int result = number1 + number2
            // return result;
        }

        public int GetSmallestNumber(int number1, int number2)
        {
            if (number1 < number2)                            // my way
            {
                return number1;
            }
            else
            {
                return number2;
            }
            // return number1 < number2 ? number1 : number2;  2nd way  via John  (?) is do this (:) is else do this
            // return Math.Min(number1, number2);             3rd way Juan

            // int min = Math.Min(number1, number2);  
            //  return min;                                   4th way Pat

            // return number1 < number2;                      !! this will not work!!
        }

        public long Multiply(long factor1, long factor2)
        {
            return factor1 * factor2;                         //my way

            //var anwer = factor1 * factor2;                  2nd way 
            //return answer;

            // if  (factor1 == 0 || factor2 == o)             3rd way via John
            // {
            // return 0;
            // }
            // else
            // {
            // long result = factor1 * factor2:
            // return result;
            // }

            // public long Multiply(long? factor1, long? factor2)  add (?) to make nullable

            // if (factor 1 == null  ||  factor2 == null)     
            // {
            //  return 0;
            // }
            // else if (actor 1 == 0  ||  factor2 == 0)
            // {
            // return 0;
            // }
            // else
            // {
            //  return factor1 * factor2:
            // }
        }

        public string GetGreeting(string nameOfPerson)
        {
            if (nameOfPerson == null)                             // my way  
            {
                return "Hello!";
            }
            else if (nameOfPerson == "")                        // "" is an empty string, also solves the problem of "Hello !"
            {                                                   // could combine:  if(nameOfPerson == null  || nameOfPrson ==  ""); start line 99
                return "Hello!";                                // could do:  if(string.IsNullOrEmpty(nameOfPerson));start line 99
            }
            else
            {
                return $"Hello, {nameOfPerson}!";             // string interpulation
            }
            // return string.IsNullOrEmpty(nameOfPerson) ? "Hello!" : $"Hello, {nameOfPerson}!";   2nd way John
        }

        public string GetHey()
        {
            return "HEY!";                   // my way
        }
    }
}
