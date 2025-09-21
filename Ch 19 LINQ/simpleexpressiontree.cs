// A simple expression tree.
using System;
using System.Linq;
using System.Linq.Expressions;
class SimpleExpTree
{
    static void Main()
    {
        // Represent a lambda expression as data.
        Expression<Func<int, int, bool>>
        IsFactorExp = (n, d) => (d != 0) ? (n % d) == 0 : false;
        // Compile the expression data into executable code.
        Func<int, int, bool> IsFactor = IsFactorExp.Compile();
        // Execute the expression.
        if (IsFactor(10, 5))
            Console.WriteLine("5 is a factor of 10.");
        if (!IsFactor(10, 7))
           
 Console.WriteLine("7 is not a factor of 10.");
        Console.WriteLine();
    }
}