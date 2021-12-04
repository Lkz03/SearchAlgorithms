class Program
{
 public static void Main()
 {
  string[] test = new string[] { "hello", "asdasdasdwdw", "asdasdasdas", "gfhtrfhrthtrh", "dfgregergreg", "hjtjtyjytj", "bye", "dfgdfgdfgdf" };
  var testClass = new Algorithm(test);
  var output = new OutputManager();

  //test the constructor array
  testClass.DisplayArray();

  output.SearchOutput(test, testClass.SearchAndReturnIndex("bye"));
 }
}