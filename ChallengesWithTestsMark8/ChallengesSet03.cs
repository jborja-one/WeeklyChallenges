using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals == null && vals.Length == 0) return false;
            foreach (var v in vals){
                if (!v) return true;
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null) return false;
            int sum = 0;
            foreach (var num in numbers)
            {
                if (num % 2 != 0) sum += num;
            }
            return sum % 2!= 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool hasUpper = false;
            bool hasLower = false;
            bool hasNumber = false;

            foreach(char c in password){
                if(char.IsUpper(c)) hasUpper = true;
                if(char.IsLower(c)) hasLower = true;
                if(char.IsDigit(c)) hasNumber = true;
                if(hasUpper && hasLower && hasNumber) return true;
            }
            return false;
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
            if (divisor == 0) return 0;
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            List<int> odds = new List<int>();
            for (int i = 1; i < 100; i+=2)
            {
                odds.Add(i);
            }
            return odds.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            if (words == null) return;
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
