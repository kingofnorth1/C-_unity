using System;

public class Mainss
{
    public static void Main()
    {
        Kata kata = new();
        kata.DescendingOrders(123456789);
        Console.WriteLine(kata.Add(1, 2));
        kata.Test();
        int i = 10, j = 29;
        kata.Swap(ref i, ref j);
        Console.WriteLine($"{i}, {j}");
        kata.Divide(109, 3, out int quotient, out int remainder);
        Console.WriteLine($"{quotient}, {remainder}");
        //kata.WriteSquares();
        kata.GUM(i, out i, ref i);
        Console.WriteLine($"{i}");

        Entity.SetNextSerialNo(1000);
        Entity e1 = new();
        Entity e2 = new();
        Console.WriteLine(e1.GetSerialNo());          // Outputs "1000"
        Console.WriteLine(e2.GetSerialNo());          // Outputs "1001"
        Console.WriteLine(Entity.GetNextSerialNo());  // Outputs "1002"

        Constant constant = new(2.3);
        Dictionary<string, object> maps = new Dictionary<string, object>
        {
            { "numberOne", "hxt" },
            { "numberTwo", "dqk" }
        };
        constant.Evaluate(maps);
        EventExample.ChangeEvent();

        Collection collection = new Collection();
        collection.CollectionBasic();
        _ = collection.RetrieveDocsHomePage();
        
        Widget widget = new Widget();
        widget.Display("Test");
    }
}


