using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods 
{ 
   class Program
  {
    static void Main(string[] args)
    {
      //UsePoints(); 
      //UseParams();
    }  
    static void useParams()
    {
      var calculate = new Calculator();
      Console.WriteLine(calculate.Add(2, 3, 4, 56, 3));
      Console.WriteLine(calculate.Add(1, 2, 3, 4));
      Console.WriteLine(calculate.Add(new int[] { 1, 2, 3, 4, 5 }));
    }
    static void UsePoints()
    {
      try //prevents crashing, looks more friendly i guess 
        {
        var point = new Point(10, 20);
        point.Move(new Point(40, 60));
        Console.WriteLine("Point is at ({0}, {1})", point.x, point.y);
        point.Move(new Point(100, 200));
        Console.WriteLine("Point is at ({0}, {1})", point.x, point.y);
        }
      catch(Exception)
        {
          Console.WriteLine("An unexpected error occured.");
        }

    }
  }
}
