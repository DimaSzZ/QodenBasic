namespace QodenBasic.task1;

public static class Task1Execute
{
    public static void Use()
    {
        int N = int.Parse(Console.ReadLine());
        int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        var hashtable = new HashTable(N);

        foreach (int value in input)
        {
            hashtable.Insert(value);
        }

        for (int i = 0; i < hashtable.values.Length; i++)
        {
            Console.Write($"{i}:");
            ListNode node = hashtable.values[i];
            while (node != null)
            {
                Console.Write($" {node._value}");
                node = node._next;
            }
            Console.WriteLine();
        }
    }
}