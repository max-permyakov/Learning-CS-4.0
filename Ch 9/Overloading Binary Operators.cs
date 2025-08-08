using System;

// A three-dimensional coordinate class.
class ThreeD
{
    int x, y, z; // 3-D coordinates

    public ThreeD() { x = y = z = 0; }
    public ThreeD(int i, int j, int k) { x = i; y = j; z = k; }

    // Overload true.
    public static bool operator true(ThreeD op)
    {
        return (op.x != 0) || (op.y != 0) || (op.z != 0);
    }

    // Overload false.
    public static bool operator false(ThreeD op)
    {
        return (op.x == 0) && (op.y == 0) && (op.z == 0);
    }

    // Overload logical AND (&)
    public static ThreeD operator &(ThreeD op1, ThreeD op2)
    {
        return new ThreeD(op1.x & op2.x, op1.y & op2.y, op1.z & op2.z);
    }

    // Overload logical OR (|)
    public static ThreeD operator |(ThreeD op1, ThreeD op2)
    {
        return new ThreeD(op1.x | op2.x, op1.y | op2.y, op1.z | op2.z);
    }

    // Overload unary --.
    public static ThreeD operator --(ThreeD op)
    {
        return new ThreeD(op.x - 1, op.y - 1, op.z - 1);
    }

    // Show X, Y, Z coordinates.
    public void Show()
    {
        Console.WriteLine(x + ", " + y + ", " + z);
    }
}

class TrueFalseDemo
{
    static void Main()
    {
        ThreeD a = new ThreeD(5, 6, 7);
        ThreeD b = new ThreeD(10, 10, 10);
        ThreeD c = new ThreeD(0, 0, 0);

        Console.Write("Here is a: ");
        a.Show();

        Console.Write("Here is b: ");
        b.Show();

        Console.Write("Here is c: ");
        c.Show();

        Console.WriteLine();

        if (a) Console.WriteLine("a is true.");
        else Console.WriteLine("a is false.");

        if (b) Console.WriteLine("b is true.");
        else Console.WriteLine("b is false.");

        if (c) Console.WriteLine("c is true.");
        else Console.WriteLine("c is false.");

        Console.WriteLine();
        Console.WriteLine("Control a loop using a ThreeD object.");

        do
        {
            b.Show();
            b--;
        } while (b);
    }
}
//Here is a: 5, 6, 7
//Here is b: 10, 10, 10
//Here is c: 0, 0, 0

//a is true.
//b is true.
//c is false.

//Control a loop using a ThreeD object.
//10, 10, 10
//9, 9, 9
//8, 8, 8
//7, 7, 7
//6, 6, 6
//5, 5, 5
//4, 4, 4
//3, 3, 3
//2, 2, 2
//1, 1, 1