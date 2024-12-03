namespace Advent;

public static class Helpers
{
    public static void DisplayMessage(string message)
    {
        Console.WriteLine(message);
    }

    public static void ReadFile(string filepath, out string? data)
    {
        data = null;
        using StreamReader reader = new StreamReader(filepath);
        while (reader.ReadLine() is { } line)
            data += line;
    }

    public static void DebugHistorianHysteriaLists(out List<int> leftList, out List<int> rightList)
    {
        leftList = new List<int>();
        rightList = new List<int>();
        leftList.Add(3);
        leftList.Add(4);
        leftList.Add(2);
        leftList.Add(1);
        leftList.Add(3);
        leftList.Add(3);
        rightList.Add(4);
        rightList.Add(3);
        rightList.Add(5);
        rightList.Add(3);
        rightList.Add(9);
        rightList.Add(3);
    }

    public static void DebugRedReport()
    {
        var reporter = new RedNoseReport();
        reporter.RecordParser("DebugInputDay2.txt");
    }
}