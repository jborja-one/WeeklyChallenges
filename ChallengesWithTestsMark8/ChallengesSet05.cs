using System;
using System.Collections.Generic;
using System.Linq;namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return ((startNumber / n) + 1) * n;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {            if (numbers == null || numbers.Length < 2)
            {
                return 0;
            }

            int sum = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }

            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {            if (words == null || words.Length == 0)            {                return string.Empty;            }                                    var filteredWords = words.Where(w => !string.IsNullOrWhiteSpace(w)).Select(w => w.Trim());            if (!filteredWords.Any())            {                return string.Empty;            }            return string.Join(" ", filteredWords) + ".";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {            if (elements == null || elements.Count == 0)
            {
                return new double[] { };
            }

            return elements.Where((number, index) => (index + 1) % 4 == 0).ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {            if (nums == null || nums.Length < 2)
            {
                return false;
            }

            var seenNumbers = new HashSet<int>();
            foreach (var num in nums)
            {
                if (seenNumbers.Contains(targetNumber - num))
                {
                    return true;
                }

                seenNumbers.Add(num);
            }

            return false;
        }
    }
}
