using System;
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
}