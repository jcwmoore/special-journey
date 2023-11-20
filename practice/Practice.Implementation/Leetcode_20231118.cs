namespace Practice.Implementation;
public class Leetcode_20231118
{
    public int MaxFrequency(int[] nums, int k) {
        var counts = nums.GroupBy(k => k).Select(n => new {value = n.Key, ct = n.Count()}).ToList();
        //var groupedCounts = counts.GroupBy(k => k.ct).ToList();
        var sortedCounts = counts.OrderByDescending(k => k.value).ToList();
        var currentMax = counts.Max(c=>c.ct);
        
        for (int i = 0; i < sortedCounts.Count; i++)
        {
            int remainingInc = k;
            int j = i+1;   
            int localMax = sortedCounts[i].ct;
            while(remainingInc > 0 && j < sortedCounts.Count)
            {
                int costToMoveUp = sortedCounts[i].value - sortedCounts[j].value;
                if(costToMoveUp > remainingInc)
                {
                    // nothing can move up
                    break;
                }
                if(costToMoveUp * sortedCounts[j].ct <= remainingInc)
                {
                    // everything can move up
                    localMax = localMax + sortedCounts[j].ct;
                    remainingInc = remainingInc - costToMoveUp * sortedCounts[j].ct;
                }
                else
                {
                    // some of the next can move up
                    int canMoves = sortedCounts[j].ct/costToMoveUp;
                    localMax = localMax + canMoves;
                    break;
                }
                j++;
            }       
            if(localMax > currentMax)
            {
                currentMax = localMax;
            }  
        }

        return currentMax;
    }
}