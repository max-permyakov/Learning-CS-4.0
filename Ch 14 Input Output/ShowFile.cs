/* Display a text file.
 To use this program, specify the name of the file that you
 want to see. For example, to see a file called TEST.CS,
 use the following command line.
 ShowFile TEST.CS
*/
using System;
using System.IO;
using System.Net.NetworkInformation;

class ShowFile
{
    static void Main(string[] args)
    {
        int i;
        FileStream fin;
        if (args.Length != 1)
        {
            Console.WriteLine("Usage: ShowFile File");
            return;
        }
        try
        {
            fin = new FileStream(args[0], FileMode.Open);
        }
        catch (IOException exc)
        {
            Console.WriteLine("Cannot Open File");
            Console.WriteLine(exc.Message);
            return; // File can't be opened, so stop the program.
        }
        // Read bytes until EOF is encountered.
        try
        {
            do
            {
                i = fin.ReadByte();
                if (i != -1) Console.Write((char)i);
            } while (i != -1);
        }
        catch (IOException exc)
        {
            Console.WriteLine("Error Reading File");
            Console.WriteLine(exc.Message);
        }
        finally
        {
            fin.Close();
        }
    }
}
//// Display a text file. Compact version.
//using System;

//class ShowFile
//{
//    static void Main(string[] args)
//    {
//        int i;
//        FileStream fin = null;
//        if (args.Length != 1)
//        {
//            Console.WriteLine("Usage: ShowFile File");
//            return;
//        }
//        // Use a single try block to open the file and then
//        // read from it.
//        try
//        {
//            fin = new FileStream(args[0], FileMode.Open);
//            // Read bytes until EOF is encountered.
//            do
//            {
//                i = fin.ReadByte();
//                if (i != -1) Console.Write((char)i);
//            } while (i != -1);
//        }
//        catch (IOException exc)
//        {
//            Console.WriteLine("I/O Error:\n" + exc.Message);
//        }
//        finally
//        {
//            if (fin != null) fin.Close();
//        }
//    }
//}