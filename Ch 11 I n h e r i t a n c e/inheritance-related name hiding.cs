// An example of inheritance-related name hiding.
using System;
class A
{
    public int i = 0;
}
// Create a derived class.
class B : A
{
    new int i; // this i hides the i in A
    public B(int b)
    {
        i = b; // i in B
    }
    public void Show()
    {
        Console.WriteLine("i in derived class: " + i);
    }
}
class NameHiding
{
    static void Main()
    {
        B ob = new B(2);
        ob.Show();
    }
}