namespace QodenBasic.task2;

public static class Task2Execute
{
    public static void Use()
    {
        string words = Console.ReadLine();
        var wordStatistics = words.Split(' ')
            .GroupBy(word => word)
            .ToDictionary(group => group.Key, group => group.Count());

        int maxFrequency = wordStatistics.Values.Max();
        int longestWordLength = wordStatistics.Keys.Max(word => word.Length);

        var sortedWordStatistics = wordStatistics.OrderBy(pair => pair.Value);

        foreach (var pair in sortedWordStatistics)
        {
            string word = pair.Key;
            int frequency = pair.Value;
            
            int numDots = (int)Math.Round((double)(frequency * 10) / maxFrequency);
            
            string dots = new string('.', numDots);
            
            Console.WriteLine($"{word.PadLeft(longestWordLength, '_')} {dots}");
        }
    }
}