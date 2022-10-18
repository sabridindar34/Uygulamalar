using System;
//using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        //string[] isimler = new string[] { "Ali", "Ahmet", "Mehmet" };
        //Console.WriteLine(isimler[0]);
        //Console.WriteLine(isimler[1]);
        //Console.WriteLine(isimler[2]);

        //isimler = new string[4];
        //isimler[3] = "Uzay";
        //Console.WriteLine(isimler[3]);
        //Console.WriteLine(isimler[0]);

        List<string> isimler2 = new List<string>() { "Ali", "Ahmet", "Mehmet" };
        isimler2[2] = "Uzay";
        isimler2.Add("Alper");

        foreach (var isim in isimler2)
        {
            Console.WriteLine(isim);
        }
    }
}