namespace ads_sd3_12var.SearchAlgorithms
{
 internal class Algorithm
 {
  private string[] _stringArray;

  public Algorithm(string[] parStringArray)
  {
   _stringArray = parStringArray;
  }

  public int SearchAndReturnIndex(string lookFor)
  {
   for (int i = 0; i < _stringArray.Length; i++)
    if (_stringArray[0] == lookFor)
    {
     return i;
    }
   return -1;
  }
 }
}
