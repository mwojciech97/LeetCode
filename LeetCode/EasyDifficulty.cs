using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class EasyDifficulty
    {
        #region TwoSum
        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target && j != i)
                    {
                        result[0] = i;
                        result[1] = j;
                    }
                }
            }
            return result;
        }
        public int[] FasterTwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            Dictionary<int,int> keyValuePairs = new Dictionary<int,int>();
            keyValuePairs.Add(nums[0], 0);
            for(int i = 1; i < nums.Length; i++)
            {
                if (keyValuePairs.ContainsKey(target - nums[i]))
                {
                    result[0] = i;
                    result[1] = keyValuePairs[target - nums[i]];
                    break;
                }
                if (!keyValuePairs.ContainsKey(nums[i]))
                    keyValuePairs.Add(nums[i], i);
                
                
            }
            return result;
        }
        #endregion
        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            bool isPalindrome = true;
            string number = x.ToString();
            char[] chars = number.ToCharArray();
            int j = chars.Length - 1;
            for(int i = 0; i < chars.Length / 2 & j > -1; i++)
            {
                if (chars[i].Equals(chars[j]))
                {
                    j--;
                }
                else
                {
                    isPalindrome = false;
                    break;
                }
            }
            return isPalindrome;
        }
        public bool NoStringIsPalindrome(int x)
        {
            if (x < 0) return false;
            int palindrome = 0, number = x;
            while(palindrome < number && x > 0)
            {
                palindrome = palindrome * 10 + x % 10;
                x = x / 10;
            }
            if(palindrome == number) return true;
            return false;
        }
    }
}
