namespace Practice.Tests;
public class Leetcode_20231118Tests
{

    
    [Fact]
    public void Test1()
    {
        int[] input = new[] { 1,2,4 };
        int k = 5;
        var result = new Leetcode_20231118().MaxFrequency(input, k);
        Assert.Equal(3, result);
    }
    [Fact]
    public void Test2()
    {
        int[] input = new[] { 1,2,4 };
        int k = 5;
        var result = new Leetcode_20231118().MaxFrequency(input, k);
        Assert.Equal(3, result);
    }
    [Fact]
    public void Test3()
    {
        int[] input = new[] { 3,6,9 };
        int k = 2;
        var result = new Leetcode_20231118().MaxFrequency(input, k);
        Assert.Equal(1, result);
    }
}
