// Use the NullReferenceException.
using Learning_C__4._0;
using System;
using System.Net.NetworkInformation;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;
class X
{
    int x;
    public X(int a)
    {
        x = a;
    }
    public int Add(X o)
    {
        return x + o.x;
    }
}
// Demonstrate NullReferenceException.
class NREDemo
{
    static void Main()
    {
        X p = new X(10);
        X q = null; // q is explicitly assigned null
        int val;
        try {
 val = p.Add(q); // this will lead to an exception
    } catch (NullReferenceException) {
 Console.WriteLine("NullReferenceException!");
 Console.WriteLine("fixing...\n");
 // Now, fix it.
 q = new X(9);
    val = p.Add(q);
 }
Console.WriteLine("val is {0}", val);
 }
}
//The output from the program is shown here:
//NullReferenceException!
//fixing...
//val is 19