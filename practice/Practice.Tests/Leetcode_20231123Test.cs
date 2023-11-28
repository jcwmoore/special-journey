namespace Practice.Tests;

public class Leetcode_20231123Tests
{
    [Fact]
    public void Test1()
    {
        var nums = new int[] { 4,6,5,9,3,7 };
        var l = new int[] { 0, 0, 2 };
        var r = new int[] { 2, 3, 5 };

        var result = new Leetcode_20231123().CheckArithmeticSubarrays(nums, l, r).ToArray();
        var expected = new bool[] { true,false,true };
        Assert.Equal(expected, result);
    }
    [Fact]
    public void Test2()
    {
        var nums = new int[] { -12,-9,-3,-12,-6,15,20,-25,-20,-15,-10 };
        var l = new int[] { 0,1,6,4,8,7 };
        var r = new int[] { 4,4,9,7,9,10 };

        var result = new Leetcode_20231123().CheckArithmeticSubarrays(nums, l, r).ToArray();
        var expected = new bool[] { false,true,false,false,true,true };
        Assert.Equal(expected, result);
    }
}