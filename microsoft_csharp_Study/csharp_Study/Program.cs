using System;

public class Programe
{
    public static void Main()
    {
        Console.WriteLine(new Programe().Add(1, 2));
        new Programe().Test();
        Console.WriteLine("nmmd");

        Kata kata = new();
        kata.DescendingOrders(123456789);
    }
    public int Add(int a, int b)
    {
        return a+ b;
    }
    public void Test()
    {
        Console.WriteLine("Test shezhi");
    }
}