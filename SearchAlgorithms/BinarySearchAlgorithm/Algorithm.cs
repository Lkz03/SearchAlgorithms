public class Algorithm
{
 private int[] _notStringArray;

 public Algorithm(int[] parStringArray)
 {
  _notStringArray = parStringArray;
 }

 public void DisplayArray()
 {
  foreach (var str in _notStringArray)
  {
   Console.WriteLine(str);
  }
 }

 public int SearchAndReturnIndex(int firstElement, int lastElement, int lookFor)
 {
  if (lastElement >= firstElement)
  {
   int middleOfArray = firstElement + (lastElement - firstElement) / 2;

   // If the element is present at the
   // middle itself
   if (_notStringArray[middleOfArray] == lookFor)
    return middleOfArray;

   // If element is smaller than mid, then
   // it can only be present in left subarray
   if (_notStringArray[middleOfArray] > lookFor)
    return SearchAndReturnIndex(firstElement, middleOfArray - 1, lookFor);
   // Else the element can only be present
   // in right subarray
   return SearchAndReturnIndex(middleOfArray + 1, lastElement, lookFor);
  }

  // We reach here when element is not present
  // in array
  return -1;
 }
}