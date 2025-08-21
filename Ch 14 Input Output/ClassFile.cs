/* Copy a file using File.Copy().
 To use this program, specify the name of the source
 file and the destination file. For example, to copy a
PART I
Chapter 14: Using I/O 405
 file called FIRST.DAT to a file called SECOND.DAT, use
 the following command line:
 CopyFile FIRST.DAT SECOND.DAT
*/
using System;
using System.IO;
class CopyFile2
{
    static void Main(string[] args)
    {
        if (args.Length != 2)
        {
            Console.WriteLine("Usage: CopyFile From To");
            return;
        }
        // Copy the files.
        try
        {
            File.Copy(args[0], args[1]);
        }
        catch (IOException exc)
        {
            Console.WriteLine("Error Copying File\n" + exc.Message);

        }
        {
            if (File.Exists("test.txt"))
                Console.WriteLine("File exists. It was last accessed at " +
                File.GetLastAccessTime("test.txt"));
            else
                Console.WriteLine("Does Not Exist");
        }
    }
  
    
}



//Sample output is shown here:
//File exists. It was last accessed at 11/1/2009 5:30:17 PM