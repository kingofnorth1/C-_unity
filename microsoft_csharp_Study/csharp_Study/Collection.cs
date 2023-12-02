using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

public class Collection
{
    public void CollectionBasic()
    {
        int[] a = new int[3];
        for (int i=0; i<a.Length; i++)
        {
            a[i] = i * i;
        }
        //for (int i=0;i<a.Length ; i++)
        //{
        //    Console.WriteLine($"数组基础应用: {a[i]}");
        //}
        foreach(int item in a)
        {
            Console.WriteLine($"数组基础应用: {item}");
        }
        var weatherData = DateTime.Now;
        Console.WriteLine($"The low and high temperature on {weatherData.Date:MM-dd-yyyy}");
        Console.WriteLine("lambda表达式："+(() => 3 * 4));
    }
    public async Task<int> RetrieveDocsHomePage()
    {
        var client = new HttpClient();
        Console.WriteLine($"异步async与同步await 发起http请求");
        byte[] content = await client.GetByteArrayAsync("https://www.baidu.com/");

        Console.WriteLine($"{nameof(RetrieveDocsHomePage)}: Finished downloading.");
        return content.Length;
    }
}

public class HelpAttribute : Attribute
{
    string _url;
    string _topic;

    public HelpAttribute(string url) => _url = url;

    public string Url => _url;

    public string Topic
    {
        get => _topic;
        set => _topic = value;
    }
}

[Help("https://learn.microsoft.com/dotnet/csharp/tour-of-csharp/features")]
public class Widget
{
    [Help("https://learn.microsoft.com/dotnet/csharp/tour-of-csharp/features",
    Topic = "Display")]
    public void Display(string text) { }
}
