namespace QodenBasic.task1;

class ListNode {
    
    public int _value;
    
    public ListNode _next;

    public ListNode(int value)
    { 
        _value = value;
        _next = null;
    }

    public void Insert(int newValue)
    {
        if (_next == null)
        {
            _next = new ListNode(newValue);
        }
        else
        {
            _next.Insert(newValue);
        }
    }
}