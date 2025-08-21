// A simple example of recursion.
using System;
using System.Threading;
class Factorial
{
    
 // This is a recursive method.
 public int FactR(int n)
    {
        int result;
        if (n == 1) return 1;
        result = FactR(n - 1) * n;
        return result;
    }
    // This is an iterative equivalent.
    public int FactI(int n)
    {
        int t, result;
        result = 1;
        for (t = 1; t <= n; t++) result *= t;
        return result;
    }
}
class check
{
    static void checkout()
    {
        Factorial f = new Factorial();
        Console.WriteLine("Factorials using recursive method.");
        Console.WriteLine("Factorial of 3 is " + f.FactR(3));
        Console.WriteLine("Factorial of 4 is " + f.FactR(4));
        Console.WriteLine("Factorial of 5 is " + f.FactR(5));
        Console.WriteLine();
        Console.WriteLine("Factorials using iterative method.");
        Console.WriteLine("Factorial of 3 is " + f.FactI(3));
        Console.WriteLine("Factorial of 4 is " + f.FactI(4));
        Console.WriteLine("Factorial of 5 is " + f.FactI(5));
    }
}

//// Display a string in reverse by using recursion.
//using System;
//class RevStr
//{
//    // Display a string backward.
//    public void DisplayRev(string str)
//    {
//        if (str.Length > 0)
//            DisplayRev(str.Substring(1, str.Length - 1));
//        else
//            return;
//        Console.Write(str[0]);
//    }
//}
//class RevStrDemo
//{
//    static void Main()
//    {
//        string s = "this is a test";
//        RevStr rsOb = new RevStr();
//        Console.WriteLine("Original string: " + s);
//        Console.Write("Reversed string: ");
//        rsOb.DisplayRev(s);
//        Console.WriteLine();
//    }
//}