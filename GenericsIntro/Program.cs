using System;

using GenericsIntro;

class Program
{
    private static void Main(string[] args)
    {
        MyList<string> isimler = new MyList<string>();
        isimler.Add("Uzay");
        Console.WriteLine(isimler.Length);
        isimler.Add("Dünya");
        Console.WriteLine(isimler.Length);

        foreach (var isim in isimler.Items)
        {
            Console.WriteLine(isim);
        }
          
    }
}
