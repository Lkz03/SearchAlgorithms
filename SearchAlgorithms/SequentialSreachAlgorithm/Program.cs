class Program
{
 public static void Main()
 {
  int[] test = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
  var testClass = new Algorithm(test);
  var output = new OutputManager();

  //test the constructor array
  testClass.DisplayArray();

  output.SearchOutput(test, testClass.SearchAndReturnIndex(5));
 }
}