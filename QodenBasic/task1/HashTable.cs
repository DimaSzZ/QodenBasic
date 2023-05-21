namespace QodenBasic.task1;

class HashTable
{
    public ListNode[] values;

    public HashTable(int size)
    {
        values = new ListNode[size];
    }

    public void Insert(int newValue)
    {
        int index = newValue % values.Length;

        if (values[index] == null)
        {
            values[index] = new ListNode(newValue);
        }
        else
        {
            values[index].Insert(newValue);
        }
    }
}