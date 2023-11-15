using LeetCode;
using System.Diagnostics;
using System.Globalization;
#region Merge Sorted Array
/*int[] nums1 = { 1, 2, 3, 0, 0, 0 };
int[] nums2 = { 2, 5, 6 };
/*
int[] nums1 = { 1 };
int[] nums2 = { };

int[] nums1 = { 0 };
int[] nums2 = { 1 };

int[] nums1 = { 4, 0, 0, 0, 0, 0, 0 };
int[] nums2 = { 1, 2, 3, 4, 5, 6};

Tasks.CombineAndSort(nums1, 3, nums2, 3);
foreach (int i in nums1)
{
    Console.WriteLine(i);
}*/
#endregion
#region RemoveElement
/*int[] nums = { 3, 2, 2, 3 };
int val = 3;
Console.WriteLine(Tasks.RemoveElement(nums, val)); */
#endregion
#region Remove Duplicates from Sorted Array
/*
int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
Console.WriteLine(Tasks.RemoveDuplicates(nums)); */
#endregion
#region Remove Duplicates from Sorted Array II
/*
int[] nums = { 1, 1, 1 };
Console.WriteLine(Tasks.RemoveDuplicates2(nums)); */
#endregion
#region Majority Element
/*
int[] nums = { 3, 3, 4 };
Console.WriteLine(Tasks.MajorityElement(nums));*/
#endregion
#region Rotate Arraty
/*
int[] nums = { -1, -100, 3, 99 };
Tasks.RotateArray(nums, 2);
foreach(int n in nums)
{
    Console.WriteLine(n);
}*/
#endregion
#region Best Time to Buy and Sell Stock
/*
int[] prices = { 7, 1, 5, 3, 6, 4 };
Console.WriteLine(Tasks.MaxProfit(prices));*/
#endregion
#region Jump Game
/*
int[] nums1 = { 1,2 };
int[] nums2 = { 3, 2, 1, 0, 4 };
Console.WriteLine(Tasks.CanJump(nums1));
Console.WriteLine(Tasks.CanJump(nums2));*/
#endregion
#region Jump Game II
/*int[] nums1 = { 1 };
Console.WriteLine(Tasks.Jump2(nums1));*/
#endregion
#region H-index
/*int[] citations = { 1 };
Console.WriteLine(Tasks.H_index(citations));*/
#endregion
#region Insert Delete GetRandom O(1)
/*RandomizedSet randomizedSet = new RandomizedSet();
randomizedSet.Insert(1); // Inserts 1 to the set. Returns true as 1 was inserted successfully.
randomizedSet.Remove(2); // Returns false as 2 does not exist in the set.
randomizedSet.Insert(2); // Inserts 2 to the set, returns true. Set now contains [1,2].
randomizedSet.GetRandom(); // getRandom() should return either 1 or 2 randomly.
randomizedSet.Remove(1); // Removes 1 from the set, returns true. Set now contains [2].
randomizedSet.Insert(2); // 2 was already in the set, so return false.
randomizedSet.GetRandom();*/
#endregion
#region Product of Array Except Self
/*int[] nums1 = { 1, 2, 3, 4 };
var ans = Tasks.ProductExceptSelf(nums1);
foreach (var x in ans)
{
    Console.WriteLine(x);
}*/
#endregion
#region Gas Station
/*int[] gas = { 1,2,3,4,5 };
int[] cost = { 3,4,5,1,2 };
Console.WriteLine(Tasks.CanCompleteCircuit(gas, cost));*/
#endregion
#region Candy - not ended
/*int[] kids = { 29, 51, 87, 87, 72, 12 };
Console.WriteLine(Tasks.Candy(kids));*/
#endregion

//Easy difficulty tasks
EasyDifficulty Problems = new EasyDifficulty();
#region TwoSum
/*int[] nums = { 2, 7, 11, 15 };
int[] result1 = Problems.TwoSum(nums, 9);
int[] result =  Problems.FasterTwoSum(nums, 9);*/
#endregion
#region IsPalindrome
/*int x = 10;
Console.WriteLine(Problems.IsPalindrome(x));
Console.WriteLine(Problems.NoStringIsPalindrome(x));*/
#endregion
#region RomanToIntiger
/*string s = "MCMXCIV";
Console.WriteLine(Problems.RomanToInt(s));*/
#endregion
#region Longest Common Prefix
/*string[] strs = { "ab", "a" };
Console.WriteLine(Problems.LongestCommonPrefix(strs));*/
#endregion
#region Valid Parentheses
/*string s = "]";
Console.WriteLine(Problems.IsValid(s));*/
#endregion
#region Find the Index of the First Occurrence in a String
/*string haystack = "sad";
string needle = "sad";
Console.WriteLine(Problems.StrStr(haystack, needle));*/
#endregion
#region Search Insert Position
/*int[] nums = { 1, 3, 5, 6 };
int target = 7;
Console.WriteLine(Problems.SearchInsertDiff(nums, target));*/
#endregion
#region Length of Last Word
/*string s = "Hello World";
Console.WriteLine(Problems.LengthOfLastWord(s));*/
#endregion
#region Plus One
/*int[] digits = { 9, 9, 9 };
foreach (int i in Problems.PlusOne(digits))
{
    Console.WriteLine(i);
}*/
#endregion
#region Add Binary
/*string first = "0";
string second = "0";
Console.WriteLine(Problems.AddBinary(first, second));*/
#endregion
#region Sqrt(x)
int x = 8;
Console.WriteLine(Problems.MySqrt(x));
#endregion

