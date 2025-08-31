// A simple generic class with two type parameters: T and V.
using System;
class TwoGen<T, V>
{
    T ob1;
    V ob2;
    // Notice that this constructor has parameters of type T and V.
    public TwoGen(T o1, V o2)
    {
        ob1 = o1;
        ob2 = o2;
    }
    // Show types of T and V.
    public void showTypes()
    {
        Console.WriteLine("Type of T is " + typeof(T));
        Console.WriteLine("Type of V is " + typeof(V));
    }
    public T getob1()
    {
        return ob1;
    }
    public V GetObj2()
    {
        return ob2;
    }
}
// Demonstrate two generic type parameters.
class SimpGen
{
    static void Main()
    {
        TwoGen<int, string> tgObj =
        new TwoGen<int, string>(119, "Alpha Beta Gamma");
        // Show the types.
        tgObj.showTypes();
        // Obtain and show values.
        int v = tgObj.getob1();
        Console.WriteLine("value: " + v);
       
    string str = tgObj.GetObj2();
        Console.WriteLine("value: " + str);
    }
}
//The output from this program is shown here:
//Type of T is System.Int32
//Type of V is System.String
//value: 119
//value: Alpha Beta Gamma