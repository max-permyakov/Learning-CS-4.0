// Using base to overcome name hiding.
using System;
class A1
{
    public int i = 0;
}
// Create a derived class.
class B1 : A1
{
    new int i; // this i hides the i in A
    public B1(int a, int b)
    {
        base.i = a; // this uncovers the i in A
        i = b; // i in B
    }
    public void Show()
    {
        // This displays the i in A.
        Console.WriteLine("i in base class: " + base.i);
        // This displays the i in B.
        Console.WriteLine("i in derived class: " + i);
    }
}
class UncoverName
{
    static void Main()
    {
        B1 ob = new B1(1, 2);
        ob.Show();
    }
}