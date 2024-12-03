using System;

namespace Advent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Helpers.DisplayMessage("Welcome to the Advent Program!");
            HistorianHysteria();
            Helpers.DisplayMessage(" ");
            RedReports(false);
            Helpers.DisplayMessage("Run completed");
        }

        private static void HistorianHysteria(bool debug = false)
        {
            Helpers.DisplayMessage("Advent of Code Day 1");
            if (debug) Helpers.DebugHistorianHysteriaLists(out var leftListDebug, out var rightListDebug);
            InitializeDayOne("Day1InputLeft.txt", "Day1InputRight.txt", out var leftList, out var rightList);
            var findHistorian = new FindHistorian(leftList, rightList);
            findHistorian.SortLists();
            findHistorian.GetDistance();
            findHistorian.GetSimilarity();
        }

        private static void InitializeDayOne(string leftFilePath, string rightFilePath, out List<int> leftList, out List<int> rightList)
        {
            leftList = new List<int>();
            rightList = new List<int>();
            using StreamReader srl = new StreamReader(leftFilePath);
            var l = string.Empty;
            while ((l = srl.ReadLine()) != null)
                leftList.Add(int.Parse(l));
            
            using StreamReader srr = new StreamReader(rightFilePath);
            var r = string.Empty;
            while ((r = srr.ReadLine()) != null)
                rightList.Add(int.Parse(r));
        }

        private static void RedReports(bool debug = false)
        {
            Helpers.DisplayMessage("Advent of Code Day 2");
            if (debug) Helpers.DebugRedReport();
            var reporter = new RedNoseReport();
            reporter.RecordParser("Day2Input.txt");
        }
    }
}