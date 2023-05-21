using QodenBasic.taks3;
using QodenBasic.task1;
using QodenBasic.task2;

class Program
{
    static void Main()
    {
        string task = Console.ReadLine();
        switch (task)
        {
            case "1": Task1Execute.Use();
                break;
            case "2": Task2Execute.Use();
                break;
            case "3": Task3Execute.Use();
                break;
        }
    }
}