using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

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
        #region IsPalindrome
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
        #endregion
        #region RomanToInteger
        public int RomanToInt(string s)
        {
            Dictionary<char, int> RomanValues = new Dictionary<char, int>();
            RomanValues.Add('M', 1000);
            RomanValues.Add('D', 500);
            RomanValues.Add('C', 100);
            RomanValues.Add('L', 50);
            RomanValues.Add('X', 10);
            RomanValues.Add('V', 5);
            RomanValues.Add('I', 1);
            char[] chars = s.ToCharArray();
            int answer = 0;
            bool skipLast = false;
            for(int i = chars.Length - 1; i > 0; i--)
            {
                if (RomanValues[chars[i]] > RomanValues[chars[i - 1]])
                {
                    if (chars[i] == 'M' || chars[i] == 'D') answer += RomanValues[chars[i]] - 100;
                    if (chars[i] == 'C' || chars[i] == 'L') answer += RomanValues[chars[i]] - 10;
                    if (chars[i] == 'X' || chars[i] == 'V') answer += RomanValues[chars[i]] - 1;
                    if (i-- == 1) skipLast = true;
                }
                else answer += RomanValues[chars[i]];
            }
            if(skipLast) return answer;
            return answer += RomanValues[chars[0]];
        }

        #endregion
        #region Longest Common Prefix
        public string LongestCommonPrefix(string[] strs)
        {
            Array.Sort(strs);
            for (int i = 0; i < strs[0].Length; i++)
            {
                if (!strs[0][i].Equals(strs[strs.Length - 1][i]))
                    return strs[0].Substring(0, i);
            }
            return strs[0];
        }
        #endregion
        #region Valid Parentheses
        public bool IsValid(string s)
        {
            Stack<char> chars = new Stack<char>();
            char[] parenthese = s.ToCharArray();
            for(int i = 0; i < parenthese.Length; i++)
            {
                if (parenthese[i] == '(' ||
                    parenthese[i] == '[' ||
                    parenthese[i] == '{') chars.Push(parenthese[i]);
                else
                {
                    char result;
                    chars.TryPeek(out result);
                    if (parenthese[i] == ')' && result == '(') chars.Pop();
                    else if (parenthese[i] == ']' && result == '[') chars.Pop();
                    else if (parenthese[i] == '}' && result == '{') chars.Pop();
                    else return false;
                }
            }
            if (chars.Count == 0) return true;
            else return false;
        }
        #endregion
        #region Find the Index of the First Occurrence in a String
        public int StrStr(string haystack, string needle)
        {
            if (needle.Length > haystack.Length) return -1;
            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[0])
                    if (Check(haystack.Substring(i), needle)) return i;
            }
            return -1;

            bool Check(string haystack, string needle)
            {
                int j = 0;
                if (needle.Length > haystack.Length) return false;
                for (int i = 0; i < haystack.Length & j < needle.Length; i++)
                {
                    if (haystack[i] != needle[j]) return false;
                    j++;
                }
                return true;
            }
        }
        
        public int StrStrTuple(string haystack, string needle)
        {
            if (needle.Length > haystack.Length) return -1;
            for(int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[0])
                {
                    var result = Check(haystack.Substring(i), needle);
                    if (result.Item1) return i;
                    else i = i + result.Item2;
                }
            }
            return -1;

            (bool, int) Check(string haystack, string needle)
            {
                int j = 0, first = 0;
                if (needle.Length > haystack.Length) return (false, 0);
                for (int i = 0; i < haystack.Length & j < needle.Length; i++)
                {
                    if (haystack[i] != needle[j]) return (false, 0);
                    j++;
                    if (haystack[i] == needle[0] && first == 0) first = i;
                }
                return (true, 1);
            }
        }
        
        #endregion
    }
}
