using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static class Tasks
    {
        public static void CombineAndSort(int[] nums1, int m, int[] nums2, int n)
        {
            /*for (int i = 0; i < m; i++)
            {
                nums1[n + i] = nums2[i];
            }
            Array.Sort(nums1);*/
            for (int i = m-- + n-- - 1; i > -1 && n > -1; i--)
            {
                if (m <= 0) nums1[i] = nums2[n--];
                else nums1[i] = nums1[m] > nums2[n] ? nums1[m--] : nums2[n--];
            }
        }
        public static int RemoveElement(int[] nums, int val)
        {
            int x = nums.Length - 1;
            for (int i = 0; i < nums.Length / 2; i++)
            {
                if (nums[i] == val) nums[i] = -1;
                if (nums[x] == val) nums[x--] = -1;
            }
            Array.Sort(nums);
            Array.Reverse(nums);
            return nums.Count(x => x > -1); 
        }
        public static int RemoveDuplicates(int[] nums)
        {
            int j = 0;
            for(int i = 1; i < nums.Length; i++)
            {
                if (nums[j] != nums[i])
                {
                    nums[++j] = nums[i];
                }
            }
            return j + 1;
        }
        public static int RemoveDuplicates2(int[] nums)
        {
            int count = 0;
            int j = 0;
            int max = nums.Max() + 1;
            if (nums.Length == 1) return 1;
            for (int i = 1; i < nums.Length; i++)
            {

                if (nums[j] == nums[i])
                {
                    count++;
                    if (count > 1) nums[i - 1] = max;
                }
                else
                {
                    j = i;
                    count = 0;
                }
            }
            Array.Sort(nums);
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }
            return nums.Count(x => x < max);
        }
        public static int MajorityElement(int[] nums)
        {
            Array.Sort(nums);
            int j = 0, count = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[j] == nums[i]) count++;
                else
                {
                    if (count > nums.Length / 2) return nums[i - 1];
                    j = i;
                    count = 1;
                }
            }
            return nums[j];
        }
        public static void RotateArray(int[] nums, int k)
        {
            int[] nums2 = new int[nums.Length];
            k %= nums.Length;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i + k > nums.Length - 1) nums2[i + k - nums.Length] = nums[i];
                else nums2[i + k] = nums[i];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = nums2[i];
            }
        }
        public static int MaxProfit(int[] prices)
        {
            int sum = 0, t = prices.Max(), min = prices[0];
            for (int i = 0; i < prices.Length - 1; i++)
            {
                if (prices[i] < min)
                {
                    min = prices[i];
                }
                else if (prices[i] - min > sum)
                {
                    sum = prices[i] - min;
                } 
            }
            return sum;
        }
        public static bool CanJump(int[] nums)
        {
            int reach = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > reach) return false;
                reach = Math.Max(i + nums[i], reach);
            }
            return true;
        }
        public static int Jump2(int[] nums)
        {
            int score = 0, maxReach = nums[0], reach = nums[0];
            if(reach == 0) return 0;
            for(int i = 1; i < nums.Length; i++)
            {
                if(i > reach)
                {
                    score++;
                    reach = maxReach;
                }
                if (i + nums[i] > maxReach) maxReach = i + nums[i];
            }
            return ++score;
        }
        public static int H_index(int[] citations)
        {
            Array.Sort(citations);
            int maxH = citations.Length;
            int minH = 0;
            while(maxH != 0)
            {
                if (maxH <= citations[minH]) return maxH;
                if (maxH > citations[minH])
                {
                    minH++;
                    maxH--;
                }
            }
            return maxH;
        }
        public static int[] ProductExceptSelf(int[] nums)
        {
            int[] answer = new int[nums.Length];
            int[] fromFront = new int[nums.Length];
            int[] fromBack = new int[nums.Length];
            fromFront[0] = 1;
            fromBack[nums.Length - 1] = 1;
            for(int i = 1; i < nums.Length; i++)
            {
                fromFront[i] = fromFront[i - 1] * nums[i - 1];
            }
            for(int i = nums.Length - 2; i > -1; i--)
            {
                fromBack[i] = fromBack[i + 1] * nums[i + 1];
            }
            for(int i = 0; i < nums.Length; i++)
            {
                answer[i] = fromBack[i] * fromFront[i];
            }
            return answer;
        }
        public static int CanCompleteCircuit(int[] gas, int[] cost)
        {
            int petrol = 0, exPetrol = 0, start = 0;
            for(int i = 0; i < gas.Length; i++)
            {
                petrol += gas[i] - cost[i];
                if(petrol < 0)
                {
                    start = i + 1;
                    exPetrol += petrol;
                    petrol = 0;
                }
            }
            return petrol + exPetrol >= 0 ? start : -1;
        }
        public static int Candy(int[] ratings)
        {
            int[] candys = new int[ratings.Length];
            if (ratings[0] > ratings[1]) 
                candys[0] = 2;
            else candys[0] = 1;
            for (int i = 1; i < ratings.Length - 1; i++)
            {
                candys[i] = 1;
                if (ratings[i] > ratings[i - 1]) candys[i] = candys[i - 1] + 1;
            }
            candys[ratings.Length - 1] = 1;
            for(int i = ratings.Length - 2; i > -1; i--)
            {
                if (ratings[i] > ratings[i + 1]) candys[i] = candys[i + 1] + 1;
            }
            if (ratings[ratings.Length - 1] > ratings[ratings.Length - 2])
                candys[ratings.Length - 1] = candys[ratings.Length - 2] + 1;
            else candys[ratings.Length - 1] = 1;
            return candys.Sum();
        }
    }
    public class RandomizedSet
    {
        private readonly Dictionary<int, bool> dic;
        private readonly Random rnd = new Random();
        public RandomizedSet()
        {
            dic = new Dictionary<int, bool>();
        }

        public bool Insert(int val)
        {
            if (!dic.ContainsKey(val))
            {
                dic.Add(val, true);
                return true;
            }
            return false;
        }

        public bool Remove(int val)
        {
            if (dic.ContainsKey(val))
            {
                dic.Remove(val);
                return true;
            }
            return false;
        }

        public int GetRandom()
        {
            return dic.ElementAt(rnd.Next(0, dic.Count)).Key;
        }
    }
}
