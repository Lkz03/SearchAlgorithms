public class Algorithm
{
 private string[] _stringArray;

 public Algorithm(string[] parStringArray)
 {
  _stringArray = parStringArray;
 }

 public void DisplayArray()
 {
  foreach (string str in _stringArray)
  {
   Console.WriteLine(str);
  }
 }

 public int SearchAndReturnIndex(string lookFor)
 {
  for (int i = 0; i < _stringArray.Length; i++)
   if (_stringArray[i] == lookFor)
   {
    return i;
   }
  return -1;
 }
}
