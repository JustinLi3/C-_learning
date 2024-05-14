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
      var smallests = new List<int>(); 

      while (smallests.Count < count)
      {
        var min = GetSmallest(list);
        smallests.Add(min); 
        list.Remove(min);
      }
      return smallests;
    }
    public static int GetSmallest(List<int> numbers)
    {
      return numbers.Min();  
    }
  }
}
