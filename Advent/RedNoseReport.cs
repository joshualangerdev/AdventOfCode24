namespace Advent;

public class RedNoseReport
{
    private int _safeCount = 0;
    
    public RedNoseReport()
    {
    }

    public void RecordParser(string path)
    {
        var data = File.ReadAllLines(path);

        foreach (var line in data)
        {
            var array = SplitIntoIntArray(line);
            var deltas = CalculateDeltas(array);
            if (IsSafe(deltas))
            {
                _safeCount++;
            }
            else
            {
                if (!array.Select((t, i) => (int[])array.Take(i).Concat(array.Skip(i + 1)).ToArray())
                        .Any(modArray => IsSafe(CalculateDeltas(modArray)))) continue;
                _safeCount++;
            }
        }
        
        Helpers.DisplayMessage($"{_safeCount} safe records found.");
    }

    private bool IsSafe(int[] deltas)
    {
        return deltas.All(d => d is <= -1 and >= -3) 
               || deltas.All(d => d is >= +1 and <= +3);
    }

    private int[] CalculateDeltas(int[] array)
    {
        var deltas = new List<int>();
        
        for (var i = 1; i < array.Length; i++)
            deltas.Add(array[i] - array[i - 1]);
        
        return [.. deltas];
    }
    
    private int[] SplitIntoIntArray(string line) => 
        line.Split(' ')
            .Select(x => int.Parse(x.Trim()))
            .ToArray();
}