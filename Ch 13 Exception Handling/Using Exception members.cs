// Using Exception members.
using System;
using System.Diagnostics.Metrics;
class ExcTest {
 public static void GenException() {
 int[] nums = new int[4];
 Console.WriteLine("Before exception is generated.");
 // Generate an index out-of-bounds exception.
 for(int i=0; i < 10; i++) {
 nums[i] = i;
 Console.WriteLine("nums[{0}]: {1}", i, nums[i]);
 }
 Console.WriteLine("this won't be displayed");
 }
}
class UseExcept {
 static void Main() {
 try {
 ExcTest.GenException();
 }
 catch (IndexOutOfRangeException exc) {
Console.WriteLine("Standard message is: ");
 Console.WriteLine(exc); // calls ToString()
 Console.WriteLine("Stack trace: " + exc.StackTrace);
 Console.WriteLine("Message: " + exc.Message);
 Console.WriteLine("TargetSite: " + exc.TargetSite);
 }
 Console.WriteLine("After catch block.");
 }
}
//The output from this program is shown here:
//Before exception is generated.
//nums[0]: 0
//nums[1]: 1
//nums[2]: 2
//nums[3]: 3
//Standard message is:
//System.IndexOutOfRangeException: Index was outside the bounds of the array.
// at ExcTest.GenException()
// at UseExcept.Main()
//Stack trace: at ExcTest.GenException()
// at UseExcept.Main()
//Message: Index was outside the bounds of the array.
//TargetSite: Void GenException()
//After catch block..