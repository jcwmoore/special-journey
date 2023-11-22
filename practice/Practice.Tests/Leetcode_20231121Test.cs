namespace Practice.Tests;

public class Leetcode_20231121Tests
{
    [Fact]
    public void Test1()
    {
        var input = new List<IList<int>>() {
            new List<int> {1,2,3},
            new List<int> {4,5,6},
            new List<int> {7,8,9},
        };

        var result = new Leetcode_20231121().FindDiagonalOrder(input);
        var expected = new int[] { 1,4,2,7,5,3,8,6,9 };
        Assert.Equal(expected, result);
    }
    [Fact]
    public void Test2()
    {
        var input = new List<IList<int>>() {
            new List<int> {1,2,3,4,5},
            new List<int> {6,7},
            new List<int> {8},
            new List<int> {9,10,11},
            new List<int> {12,13,14,15,16},
        };

        var result = new Leetcode_20231121().FindDiagonalOrder(input);
        var expected = new int[] { 1,6,2,8,7,3,9,4,12,10,5,13,11,14,15,16 };
        Assert.Equal(expected, result);
    }
}