namespace Practice.Implementation;
public class Leetcode_20231121
{
    //Given a 2D integer array nums, return all elements of nums in diagonal order as shown in the below images.

    public int[] FindDiagonalOrder(IList<IList<int>> nums) 
    {
        int x = 0, y = 0, visited = 0, toVisit = nums.Sum(n => n.Count);
        var result = new List<int>();
        while(visited != toVisit)
        {
            if(nums.Count > y && nums[y].Count > x)
            {
                result.Add(nums[y][x]);
                visited++;
            }
            x++;
            y--;
            if(y<0)
            {
                var oldX = x;
                x = 0;
                y = oldX;
            }
            if(y >= nums.Count)
            {
                var dif = y-(nums.Count-1);
                y = nums.Count-1;
                x = dif;
            }


        }
        return result.ToArray();    
    }
}