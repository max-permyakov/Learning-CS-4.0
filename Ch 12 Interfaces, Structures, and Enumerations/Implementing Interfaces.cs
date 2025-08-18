public interface ISeries
{
    int GetNext(); // return next number in series
    void Reset(); // restart
    void SetStart(int x); // set starting value
}// Implement ISeries.
class ByTwos : ISeries
{
    int start;
    int val;
    public ByTwos()
    {
        start = 0;
        val = 0;
    }
    public int GetNext()
    {
        val += 2;
        return val;
    }
    public void Reset()
    {
        val = start;
    }
    public void SetStart(int x)
    {
        start = x;
        val = start;
    }
}
// Demonstrate the ISeries interface.
class SeriesDemo
{
    static void Main()
    {
        ByTwos ob = new ByTwos();
        for (int i = 0; i < 5; i++)
            Console.WriteLine("Next value is " +
            ob.GetNext());
        Console.WriteLine("\nResetting");
        ob.Reset();
        for (int i = 0; i < 5; i++)
            Console.WriteLine("Next value is " +
            ob.GetNext());
            Console.WriteLine("\nStarting at 100");
            ob.SetStart(100);
        for (int i = 0; i < 5; i++)
            Console.WriteLine("Next value is " +
            ob.GetNext());
    }
}