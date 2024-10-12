using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            int sum = 0;

            foreach(var e in vals) {
                sum++;
            }

            if(sum % 2 == 0) {
                return true;
            }

            return false;
        }

        public bool IsNumberEven(int number)
        {
            if(number % 2 == 0) {
                return true;
            }
            return false;
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0) return 0;
            return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            var letterCount = 0;

            if(str1.Length > str2.Length) {
              return letterCount = str2.Length;
            }

            return str1.Length;
        }

        public int Sum(int[] numbers)
        {
            int sum = 0;

            if (numbers == null) return 0;

            for(int i = 0; i < numbers.Length; i++) {
                sum += numbers[i];
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;

            if (numbers == null) return 0;
            foreach(int num in numbers) {
                if(num % 2 == 0) {
                    sum += num;
                }
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null) return false;
            if(numbers.Sum() % 2 != 0) {
                return true;
            }
            return false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 1) return 0;

            int count = 0;

            for (int i = 1; i < number; i += 2)
            {
                count++;
            }

            return count;

        }
    }
}
