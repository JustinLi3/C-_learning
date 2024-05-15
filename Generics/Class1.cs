using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
  internal class Class1
  { 
    public static void main(string[] args)
    {
      var numbers = new GenericList<int>();
      numbers.Add(10);
      var books = new GenericList<String>();
      books.Add("Hello");
      var dict1 = new GenericDictionary<int, String>();
      dict1.Add(10, "Hello"); 


    }
  }
}
