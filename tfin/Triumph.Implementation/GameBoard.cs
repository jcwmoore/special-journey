namespace Sudoku.Implementation;
public class GameBoard
{
    public int[] State { get; private set; }

    public GameBoard(params int[] state)
    {
        this.State = state;
    }

    public List<GameBoard> NextMoves()
    {
        List<GameBoard> results = new List<GameBoard>();

        int targetIndex = 0;
        for (int i = 0; i < this.State.Length; i++)
        {
            if(this.State[i] == 0)
            {
                targetIndex = i;
                break;
            }
        }

        var rOptions = RowOptions(targetIndex);
        var cOptions = ColumnOptions(targetIndex);
        var lOptions = LocalOptions(targetIndex);
        var options = rOptions.Intersect(cOptions).Intersect(lOptions).ToList();
        
        foreach(var option in options)
        {
            var optionalState = new List<int>(this.State);
            optionalState[targetIndex] = option;
            results.Add(new GameBoard(optionalState.ToArray()));
        }

        return results;
    }

    public override bool Equals(object? obj)
    {
        if(obj != null && obj is GameBoard)
        {
            var board = obj as GameBoard;
            return Enumerable.SequenceEqual(this.State, board.State);
        }
        return false;
    }

    private int[] RowOptions(int index)
    {
        var results = new HashSet<int> { 1,2,3,4,5,6,7,8,9 };

        var row = index / 9;
        var rowValues = this.State.Skip(9*row).Take(9).ToArray();
        foreach(var value in rowValues)
        {
            if(value !=0)
            {
                results.Remove(value);
            }
        }
        return results.ToArray();
    }  

    

    private int[] LocalOptions(int index)
    {
        var results = new HashSet<int> { 1,2,3,4,5,6,7,8,9 };

        var row = index / 9;
        var column = index % 9;

        while(row%3 != 0)
        {
            row = row-1;
        }
        while(column%3 != 0)
        {
            column = column-1;
        }        
        
        var position = row*9 + column;
        int localCt = 0;
        int localRows = 0;
        for(int i = position; i < this.State.Length && localRows < 3;)
        {
            if(this.State[i] !=0)
            {
                results.Remove(this.State[i]);
            }

            if(localCt == 2)
            {
                localCt = 0;
                i += 7;
                localRows +=1;
            }
            else
            {
                localCt++;
                i += 1;
            }
        }
        return results.ToArray();
    }

    private int[] ColumnOptions(int index)
    {
        var results = new HashSet<int> { 1,2,3,4,5,6,7,8,9 };

        var column = index % 9;
        for(int i = column; i < this.State.Length; i = i+9)
        {
            if(this.State[i] !=0)
            {
                results.Remove(this.State[i]);
            }
        }
        return results.ToArray();
    }  
}

public static class Game
{
    public static GameBoard Solve(GameBoard board)
    {
        if(board == null)
        {
            throw new ArgumentNullException();
        }
        if(board.State.All(s => s != 0))
        {
            return board;
        }
        var options = board.NextMoves();
        foreach(var option in options)
        {
            var solution = Solve(option);
            if(solution != null && solution.State.All(s => s != 0))
            {
                return solution;
            }
        }
        return null;
    }
}
