namespace QodenBasic.taks3;

public class Task3Execute
{
    public static void Use()
    {
        string expression = Console.ReadLine();
        int result = Calculate(expression);
        Console.WriteLine(result);
    }
    static int Calculate(string expression)
    {
        Stack<int> stack = new Stack<int>();

        foreach (string token in expression.Split())
        {
            if (int.TryParse(token, out int number))
            {
                stack.Push(number);
            }
            else
            {
                int operand2 = stack.Pop();
                int operand1 = stack.Pop();

                switch (token)
                {
                    case "+":
                        stack.Push(operand1 + operand2);
                        break;
                    case "-":
                        stack.Push(operand1 - operand2);
                        break;
                    case "*":
                        stack.Push(operand1 * operand2);
                        break;
                    case "/":
                        stack.Push(operand1 / operand2);
                        break;
                    default:
                        throw new ArgumentException("Invalid token: " + token);
                }
            }
        }
        return stack.Pop();
    }
}