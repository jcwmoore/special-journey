namespace Practice.Tests;

public class Leetcode_20231124Tests
{
    [Fact]
    public void Test1()
    {
        var piles = new int[] { 2,4,1,2,7,8 };
        
        var result = new Leetcode_20231124().MaxCoins(piles);
        var expected = 9;
        Assert.Equal(expected, result);
    }
    [Fact]
    public void Test2()
    {
        
        var piles = new int[] { 2,4,5 };
        
        var result = new Leetcode_20231124().MaxCoins(piles);
        var expected = 4;
        Assert.Equal(expected, result);
    }
    [Fact]
    public void Test3()
    {
        
        var piles = new int[] { 9,8,7,6,5,1,2,3,4 };
        
        var result = new Leetcode_20231124().MaxCoins(piles);
        var expected = 18;
        Assert.Equal(expected, result);
    }
}