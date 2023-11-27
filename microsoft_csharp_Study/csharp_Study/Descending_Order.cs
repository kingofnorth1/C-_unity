using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

public class Kata
{
    public int DescendingOrder(int num)
    {
        Char[] arr = num.ToString().ToCharArray();
        //String str = num.ToString();
        for (int i = 0; i < arr.Length-1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] < arr[j])
                {
                    char temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        String str = new String(arr);
        Console.Write(str);
        int number = Convert.ToInt32(str);
        Console.Write("    " + Convert.ToInt32(str));
        return number;
    }
    public int DescendingOrders(int num)
    {
        char[] arr = num.ToString().ToCharArray();
        Array.Sort(arr);
        Array.Reverse(arr);
        Console.WriteLine(Convert.ToInt32(new String(arr)));
        return Convert.ToInt32(new String(arr));
    }
    public int Add(int a, int b)
    {
        return a + b;
    }
    public void Test()
    {
        Console.WriteLine("Test shezhi");
    }
    public void Swap(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }
    public void Divide(int x, int y, out int quotient, out int remainder)
    {
        quotient = x / y;
        remainder = x % y;
    }
    public void GUM(int a, out int b, ref int c)
    {
        b = a;
        c = a + b;
        ArrayList i = new ArrayList() { 1,2,3};
        ArrayList j = i;
        j.Add(5);
        ArrayList k = i;
        foreach(int x in k)
        {
            Console.Write($"{x}");
        }
        Console.WriteLine();
    }
}
