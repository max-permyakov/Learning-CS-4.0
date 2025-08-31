#define TRIAL

namespace t { 
// Demonstrate the Conditional attribute.
using System;
using System.Diagnostics;
class Test
{
    [Conditional("TRIAL")]
    void Trial()
    {
        Console.WriteLine("Trial version, not for distribution.");
    }
    [Conditional("RELEASE")]
    void Release()
    {
        Console.WriteLine("Final release version.");
    }
    static void Main()
    {
        Test t = new Test();
        t.Trial(); // called only if TRIAL is defined
        t.Release(); // called only if RELEASE is defined
    }
