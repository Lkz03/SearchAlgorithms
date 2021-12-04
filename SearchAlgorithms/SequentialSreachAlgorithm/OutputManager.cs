public class OutputManager
{
 public void SearchOutput(string[] searchedString, int searchedIndex)
 {
  if (searchedIndex == -1)
  {
   Console.WriteLine("Could not find!");
  }
  else
  {
   Console.WriteLine("Index: " + searchedIndex);
   Console.WriteLine("Value: " + searchedString[searchedIndex]);
  }
 }
}
