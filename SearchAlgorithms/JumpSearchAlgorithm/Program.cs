class Program
{
 public static void Main()
 {
  int[] test = new int[] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
  var testClass = new Algorithm(test);
  var output = new OutputManager();

  //test the constructor array
  //testClass.DisplayArray();

  output.SearchOutput(test, testClass.SearchAndReturnIndex(655555));
 }
}