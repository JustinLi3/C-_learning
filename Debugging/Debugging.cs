using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
  internal class Debugging
  {  
    public static void Main(string[] args)
    {
      var numbers  = new List<int>{1,2,3,4,5,6};
      var smallest = GetSmallests(numbers, 3);
      foreach (var number in smallest)
        Console.WriteLine(number);
    }
    public static List<int> GetSmallests(List<int> list, int count)
    {  
      if(list == null)
      {
        throw new ArgumentNullException("list"); 
      }
      if (count> list.Count || count<=0)
      {
        throw new ArgumentOutOfRangeException("Count must be between 1 and the size of the list"); // way to throw errors, more understandable for client 
      }
      var smallests = new List<int>();
      var buffer = new List<int>(list); 
      while (smallests.Count < count)
      {
        var min = GetSmallest(buffer);
        smallests.Add(min); 
        buffer.Remove(min);
      }
      return smallests;
    }
    public static int GetSmallest(List<int> numbers)
    {
      return numbers.Min();  
    }
  }
}
