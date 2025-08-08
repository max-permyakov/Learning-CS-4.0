// Use static.
using System;
using System.Threading;
using static System.Runtime.InteropServices.JavaScript.JSType;
class StaticDemo
{
    // A static variable.
    public static int Val = 100;
    // A static method.
    public static int ValDiv2()
    {
        return Val / 2;
    }
}
class SDemo
{
    static void SmDemoout()
    {
        Console.WriteLine("Initial value of StaticDemo.Val is "
        + StaticDemo.Val);
        StaticDemo.Val = 8;
        Console.WriteLine("StaticDemo.Val is " + StaticDemo.Val);
        Console.WriteLine("StaticDemo.ValDiv2(): " +
        StaticDemo.ValDiv2());
    }
}
//As the output shows, a static variable is initialized before any object of its class is created.
//There are several restrictions that apply to static methods:
//• A static method does not have a this reference. This is because a static method does
//not execute relative to any object.
//• A static method can directly call only other static methods of its class. It cannot
//directly call an instance method of its class. The reason is that instance methods
//operate on specific objects, but a static method is not called on an object. Thus, on
//what object would the instance method operate?
//• A similar restriction applies to static data.A static method can directly access only
//other static data defined by its class. It cannot operate on an instance variable of its
//class because there is no object to operate on.
//For example, in the following class, the static method ValDivDenom() is illegal:

//class StaticError
//{
//    public int Denom = 3; // a normal instance variable
//    public static int Val = 1024; // a static variable
//    PART I
//Chapter 8: A Closer Look at Methods and Classes 215
// /* Error! Can't directly access a non-static variable
// from within a static method. */
// static int ValDivDenom()
//    {
//        return Val / Denom; // won't compile!
//    }
//}


//Here, Denom is a normal instance variable that cannot be accessed within a static method.
//However, the use of Val is okay since it is a static variable.
//The same problem occurs when trying to call a non-static method from within a static
//method of the same class. For example:

//using System;
//class AnotherStaticError
//{
//    // A non-static method.
//    void NonStaticMeth()
//    {
//        Console.WriteLine("Inside NonStaticMeth().");
//    }
//    /* Error! Can't directly call a non-static method
//    from within a static method. */
//    static void staticMeth()
//    {
//        NonStaticMeth(); // won't compile
//    }
//}