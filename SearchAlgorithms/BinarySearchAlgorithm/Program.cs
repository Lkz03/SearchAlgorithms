class Program
{
 public static void Main()
 {
  int[] test = new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610 };
  var testClass = new Algorithm(test);
  var output = new OutputManager();

  //test the constructor array
  testClass.DisplayArray();

  output.SearchOutput(test, testClass.SearchAndReturnIndex(0,test.Length,55));
 }
}