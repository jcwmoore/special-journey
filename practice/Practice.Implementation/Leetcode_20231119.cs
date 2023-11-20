namespace Practice.Implementation;
public class Leetcode_20231119
{
    // Given an integer array nums, your goal is to make all elements in nums equal. To complete one operation, follow these steps:

    // Find the largest value in nums. Let its index be i (0-indexed) and its value be largest. If there are multiple elements with the largest value, pick the smallest i.
    // Find the next largest value in nums strictly smaller than largest. Let its value be nextLargest.
    // Reduce nums[i] to nextLargest.
    // Return the number of operations to make all elements in nums equal.

    public int ReductionOperations(int[] nums) 
    {
        var sorted = nums.OrderBy(n => n).ToList(); // O(n log n)
        int totalOps = 0;
        for(int i = nums.Length-1; sorted[0] != sorted[i]; i--) // O(n)
        {
            if(sorted[i] != sorted[i-1])
            {
                // reduce i and everything after it
                totalOps = totalOps + (nums.Length-i);
            }
        }
        return totalOps;
    }
}