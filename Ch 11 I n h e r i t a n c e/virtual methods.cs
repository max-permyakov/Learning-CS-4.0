/* In a multilevel hierarchy, the first override of a virtual
 method that is found while moving up the hierarchy is the
 one executed. */
using System;
class Base
{
    // Create virtual method in the base class.
    public virtual void Who()
    {
        Console.WriteLine("Who() in Base");

    }
}
class Derived1 : Base
{
    // Override Who() in a derived class.
    public override void Who()
    {
        Console.WriteLine("Who() in Derived1");
    }
}
class Derived2 : Derived1
{
    // This class also does not override Who().
}
class Derived3 : Derived2
{
    // This class does not override Who().
}
class NoOverrideDemo2
{
    static void Main()
    {
        Derived3 dOb = new Derived3();
        Base baseRef; // a base class reference
        baseRef = dOb;
        baseRef.Who(); // calls Derived1's Who()
    }
}