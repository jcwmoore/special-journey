namespace Practice.Tests;

public class Leetcode_20231120Tests
{
    [Fact]
    public void Test1()
    {
        int[] travel = new[] { 2,4,3 };
        string[] garbage = new[] { "G", "P", "GP", "GG" };

        var result = new Leetcode_20231120().GarbageCollection(garbage, travel);

        Assert.Equal(21, result);
    }
}