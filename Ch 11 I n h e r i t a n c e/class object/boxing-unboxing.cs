// A simple boxing/unboxing example.
using System;
class BoxingDemo
{
    static void Main()
    {
        int x;
        object obj;
        x = 10;
        obj = x; // box x into an object
        int y = (int)obj; // unbox obj into an int
        Console.WriteLine(y);
    }
}