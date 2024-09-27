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

 public int SearchAndReturnIndex(int lookFor)
 {
  int arrayLength = _notStringArray.Length;

  // Finding block size to be jumped
  int step = (int)Math.Floor(Math.Sqrt(arrayLength));

  // Finding the block where element is
  // present (if it is present)
  int prev = 0;
  while (_notStringArray[Math.Min(step, arrayLength) - 1] < lookFor)
  {
   prev = step;
   step += (int)Math.Floor(Math.Sqrt(arrayLength));
   if (prev >= arrayLength)
   {
    return -1;
   }
  }

  // Doing a linear search for x in block
  // beginning with prev.
  while (_notStringArray[prev] < lookFor)
  {
   prev++;

   // If we reached next block or end of
   // array, element is not present.
   if (prev == Math.Min(step, arrayLength))
   {
    return -1;
   }
  }

  // If element is found
  if (_notStringArray[prev] == lookFor)
  {
   return prev;
  }
  return -1;
 }
}