// Use two simple lambda expressions.
using System;
using System.Diagnostics.Metrics;
// Declare a delegate that takes an int argument
// and returns an int result.
delegate int Incr(int v);
// Declare a delegate that takes an int argument
// and returns a bool result.

delegate bool IsEven(int v);
class SimpleLambdaDemo
{
    static void Main()
    {
        // Create an Incr delegate instance that refers to
        // a lambda expression that increases its parameter by 2.
        Incr incr = count => count + 2;
        // Now, use the incr lambda expression.
        Console.WriteLine("Use incr lambda expression: ");
        int x = -10;
        while (x <= 0)
        {
            Console.Write(x + " ");
            x = incr(x); // increase x by 2
        }
        Console.WriteLine("\n");
        // Create an IsEven delegate instance that refers to
        // a lambda expression that returns true if its parameter
        // is even and false otherwise.
        IsEven isEven = n => n % 2 == 0;
        // Now, use the isEven lambda expression.
        Console.WriteLine("Use isEven lambda expression: ");
        for (int i = 1; i <= 10; i++)
            if (isEven(i)) Console.WriteLine(i + " is even.");
    }
}//Here is an example that uses a lambda expression to
//determine if a value is within a specified range:
//(low, high, val) => val >= low && val <= high;

//Here is a delegate type that is compatible with this lambda expression:
//delegate bool InRange(int lower, int upper, int v);

//Thus, you could create an InRange delegate instance like this:
//InRange rangeOK = (low, high, val) => val >= low && val <= high;

//After doing so, the lambda expression can be executed as shown here:
//if (rangeOK(1, 5, 3)) Console.WriteLine("3 is within 1 to 5.");

//One other point: Lambda expressions can use outer variables in the same way as
//anonymous methods, and they are captured in the same way