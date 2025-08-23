// Demonstrate the Counter namespace.
using Counter;
class NSDemo
{
    static void Main()
    {
        // Notice how CountDown is qualified by Counter.
        CountDown cd1 = new CountDown(10);
        int i;
        do
        {
            i = cd1.Count();
            Console.Write(i + " ");
        
        } while (i > 0);
        Console.WriteLine();
        // Again, notice how CountDown is qualified by Counter.
        CountDown cd2 = new CountDown(20);
        do
        {
            i = cd2.Count();
            Console.Write(i + " ");
        } while (i > 0);
        Console.WriteLine();
        cd2.Reset(4);
        do
        {
            i = cd2.Count();
            Console.Write(i + " ");
        } while (i > 0);
        Console.WriteLine();
    }
}