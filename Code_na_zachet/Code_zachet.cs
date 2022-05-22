using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class Mainclass
{
    public static void Main(string[] args)
    {
        int n;


        Console.WriteLine("введите n");
        n = Convert.ToInt32(Console.ReadLine());
        int F = 1;
        int i = 1;
        for (; i <= n; i++, F *= i) ;
        Console.WriteLine("число F " + F);
    }
}