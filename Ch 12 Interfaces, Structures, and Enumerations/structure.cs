// Demonstrate a structure.
using System;
using System.Diagnostics;
using System.Net.Sockets;
// Define a structure.
struct Book
{
    public string Author;
    public string Title;
    public int Copyright;
    public Book(string a, string t, int c)
    {
        Author = a;
        Title = t;
        Copyright = c;
    }
}
// Demonstrate Book structure.
class StructDemo
{
    static void Main()
    {
        Book book1 = new Book("Herb Schildt",
        "C# 4.0: The Complete Reference",
        2010); // explicit constructor
        Book book2 = new Book(); // default constructor
        Book book3; // no constructor
        Console.WriteLine(book1.Title + " by " + book1.Author +
        ", (c) " + book1.Copyright);
        Console.WriteLine();
         if(book2.Title == null)
 Console.WriteLine("book2.Title is null.");
        // Now, give book2 some info.
        book2.Title = "Brave New World";
        book2.Author = "Aldous Huxley";
        book2.Copyright = 1932;
        Console.Write("book2 now contains: ");
        Console.WriteLine(book2.Title + " by " + book2.Author +
        ", (c) " + book2.Copyright);
        Console.WriteLine();
        // Console.WriteLine(book3.Title); // error, must initialize first
        book3.Title = "Red Storm Rising";
        Console.WriteLine(book3.Title); // now OK
    }
}
//The output from this program is shown here:
//C# 4.0: The Complete Reference by Herb Schildt, (c) 2010
//book2.Title is null.
//book2 now contains: Brave New World by Aldous Huxley, (c) 1932
//Red Storm Rising



//another implementing of structure

// Structures are good when grouping small amounts of data.

// Define a packet structure.
struct PacketHeader
{
    public uint PackNum; // packet number
    public ushort PackLen; // length of packet
}
// Use PacketHeader to create an e-commerce transaction record.
class Transaction
{
    static uint transacNum = 0;
    PacketHeader ph; // incorporate PacketHeader into Transaction
    string accountNum;
    double amount;

 public Transaction(string acc, double val)
    {
        // create packet header
        ph.PackNum = transacNum++;
        ph.PackLen = 512; // arbitrary length
        accountNum = acc;
        amount = val;
    }
    // Simulate a transaction.
    public void sendTransaction()
    {
        Console.WriteLine("Packet #: " + ph.PackNum +
        ", Length: " + ph.PackLen +
        ",\n Account #: " + accountNum +
        ", Amount: {0:C}\n", amount);
    }
}
// Demonstrate Packet.
class PacketDemo
{
    static void Main()
    {
        Transaction t = new Transaction("31243", -100.12);
        Transaction t2 = new Transaction("AB4655", 345.25);
        Transaction t3 = new Transaction("8475-09", 9800.00);
        t.sendTransaction();
        t2.sendTransaction();
        t3.sendTransaction();
    }
}
//The output from the program is shown here:
//Packet #: 0, Length: 512,
// Account #: 31243, Amount: ($100.12)
//Packet #: 1, Length: 512,
// Account #: AB4655, Amount: $345.25
//Packet #: 2, Length: 512,
// Account #: 8475-09, Amount: $9,800.00