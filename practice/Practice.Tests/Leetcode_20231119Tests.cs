namespace Practice.Tests;
public class Leetcode_20231119Tests
{
    [Fact]
    public void Test1()
    {
        int[] input = new[] { 5,1,3 };
        var result = new Leetcode_20231119().ReductionOperations(input);
        Assert.Equal(3, result);
    }
    
    [Fact]
    public void Test2()
    {
        int[] input = new[] { 1,1,1 };
        var result = new Leetcode_20231119().ReductionOperations(input);
        Assert.Equal(0, result);
    }

    [Fact]
    public void Test3()
    {
        int[] input = new[] { 1,1,2,2,3 };
        var result = new Leetcode_20231119().ReductionOperations(input);
        Assert.Equal(4, result);
    }
}
