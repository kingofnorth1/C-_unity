using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class EventExample
{
    static int s_changeCount;
    static void ListChanged(object sender, EventArgs e)
    {
        s_changeCount++;
    }
    public static void ChangeEvent()
    {
        var names = new MyList<string>();
        names.Changed += new EventHandler(ListChanged);
        names.Add("Liz");
        names.Add("Martha");
        names.Add("Beth");
        Console.WriteLine($"事件捕获： {s_changeCount}");
    }
}