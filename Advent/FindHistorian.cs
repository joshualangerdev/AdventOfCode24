namespace Advent;

public class FindHistorian
{
    private readonly List<int> _leftList;
    private readonly List<int> _rightList;
    
    public FindHistorian(List<int> leftList, List<int> rightList)
    {
        _leftList = leftList;
        _rightList = rightList;
    }

    public void SortLists()
    {
        _leftList.Sort();
        _rightList.Sort();
    }

    public void GetDistance()
    {
        var distanceList = new List<int>();
        foreach (var val in _rightList.Select((val, index) => new { val, index }))
        {
            var distance = GetDistanceBetweenValue(val.val, _leftList[val.index]);
            distanceList.Add(distance);
        }
        
        var totalDistance = distanceList.Sum();
        
        Console.WriteLine(totalDistance);
    }

    private int GetDistanceBetweenValue(int rightList, int leftList)
    {
        return Math.Abs(rightList - leftList);
    }

    public void GetSimilarity()
    {
        var similarityList = new List<int>();
        foreach (var val in _leftList)
        {
            var countList = _rightList.FindAll(i => i.Equals(val));
            var similarity = val * countList.Count;
            similarityList.Add(similarity);
        }
        
        var totalSimilarity = similarityList.Sum();
        
        Console.WriteLine(totalSimilarity);
    }
    
    
}