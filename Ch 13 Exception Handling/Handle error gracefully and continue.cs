// Handle error gracefully and continue.
using System;
class ExcDemo3
{
    static void Main()
    {
        int[] numer = { 4, 8, 16, 32, 64, 128 };
        int[] denom = { 2, 0, 4, 4, 0, 8 };
        for (int i = 0; i < numer.Length; i++)
        {
            try
            {
                Console.WriteLine(numer[i] + " / " +
                denom[i] + " is " +
                numer[i] / denom[i]);
            }
            catch (DivideByZeroException)
            {
                // Catch the exception.
                Console.WriteLine("Can't divide by Zero!");
            }
        }
    }
}
//The output from the program is shown here:
//4 / 2 is 2
//Can't divide by Zero!
//16 / 4 is 4
//32 / 4 is 8
//Can't divide by Zero!
//128 / 8 is 16