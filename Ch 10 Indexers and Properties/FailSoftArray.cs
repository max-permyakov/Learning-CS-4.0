using System;
class FailSoftArray
{
    int[] a; // reference to underlying array
    int len; // length of array
    bool ErrFlag; // now private
                  // Construct array given its size.
    public FailSoftArray(int size)
    {
        a = new int[size];
        len = size;
    }
    // Read-only Length property.
    public int Length
    {
        get
        {
            return len;
        }
    }
    // Read-only Error property.
    public bool Error
    {
        get
        {
            return ErrFlag;
        }
    }
    // This is the indexer for FailSoftArray.
    public int this[int index]
    {
        // This is the get accessor.
        get
        {
            if (ok(index))
            {
                ErrFlag = false;
                return a[index];
            }
            else
            {
                ErrFlag = true;
                return 0;
            }
        }
       
 // This is the set accessor.
 set
        {
            if (ok(index))
            {
                a[index] = value;
                ErrFlag = false;
            }
            else ErrFlag = true;
        }
    }
    // Return true if index is within bounds.
    private bool ok(int index)
    {
        if (index >= 0 & index < Length) return true;
        return false;
    }
}
// Demonstrate the improved fail-soft array.
class FinalFSDemo
{
    static void Main()
    {
        FailSoftArray fs = new FailSoftArray(5);
        // Use Error property.
        for (int i = 0; i < fs.Length + 1; i++)
        {
            fs[i] = i * 10;
            if (fs.Error)
                Console.WriteLine("Error with index " + i);
        }
    }
}