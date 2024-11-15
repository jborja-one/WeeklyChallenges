using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int result = 0;
            foreach(var num in numbers)
            {
                if(num % 2 == 0)
                {
                    result += num;
                }
                else
                {
                    result -= num;
                }
            }
            return result;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            return new[] { str1.Length, str2.Length, str3.Length, str4.Length}.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return new[] { number1, number2, number3, number4 }.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            if (biz == null) return;

            // Check if the business name is null or empty
            if (string.IsNullOrEmpty(biz.Name))
            {
                biz.Name = "TrueCoders";
            }
            else
            {
                // Normalize the name by trimming any spaces and converting to lower case
                string normalizedName = biz.Name.Trim().ToLower();

                // If the name matches any variant of "true coders" (case insensitive), update it to "TrueCoders"
                if (normalizedName == "true coders")
                {
                    biz.Name = "TrueCoders";
                }
                else
                {
                    biz.Name = "TrueCoders";  // Set to "TrueCoders" if it doesn't match
                }
            }

        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return (sideLength1 + sideLength2 > sideLength3) &&
                   (sideLength1 + sideLength3 > sideLength2) &&
                   (sideLength2 + sideLength3 > sideLength1);
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out _);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCount = objs.Count(obj => obj == null);
            return nullCount > objs.Length / 2;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0.0;
            var evens = numbers.Where(n => n % 2 == 0).ToArray();
            return evens.Length > 0 ? evens.Average() : 0.0;
        }

        public int Factorial(int number)
        {
            if (number < 0) throw new ArgumentOutOfRangeException("Factorial is not defined for negative numbers.");
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
