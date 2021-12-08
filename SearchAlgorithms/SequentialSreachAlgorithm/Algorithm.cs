public class Algorithm
{
 private int[] _stringArray;

 public Algorithm(int[] parStringArray)
 {
  _stringArray = parStringArray;
 }

 public void DisplayArray()
 {
  foreach (int str in _stringArray)
  {
   Console.WriteLine(str);
  }
 }

 public int SearchAndReturnIndex(int lookFor)
 {
  for (int i = 0; i < _stringArray.Length; i++)
   if (_stringArray[i] == lookFor)
   {
    return i;
   }
  return -1;
 }
}
