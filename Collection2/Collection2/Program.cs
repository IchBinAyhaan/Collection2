using System;

public class Program
{
    public static string ReverseString(string str)
    {
        Stack<char> stack = new Stack<char>();
        foreach (char c in str)
        {
            stack.Push(c);
        }
        string reverseStr = "";
        while (stack.Count > 0)
        {
            reverseStr += stack.Pop();
        }
        return reverseStr;
    }
    public static void Main(string[] args)
    {
        string str = "Ayhan Qasimli";
        Console.WriteLine("Reversed string: " + ReverseString(str));
    }
}