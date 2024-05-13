using System; //basic utility classes and primitive types
using System.Collections.Concurrent;
using System.Collections.Generic; //lists, collections, etc
using System.Linq;//data
using System.Text;//text, coding
using System.Threading.Tasks;//multi-threaded applications

namespace HelloWorld //namespace is similar to package in Java
{
  internal class Program //class accessible ONLY within the namespace 
  {
    static void Main(string[] args) //similar to public static void main(String[] args)
    {
      Console.WriteLine("Hello World"); //Just like System.out.print()  
      //To run, do CTRL+F5 
      const float Pi = 3.14f; //immutable kind of like final in Java, f at the end to tell compiler to treat as float, not double
      //Practice with using basic data types
      byte number = 2; //can use var instead, declare variable without specifying explicit type
      int count = 10;
      float totalPrice = 20.95f;
      char character = 'A';
      string firstName = "Justin";
      bool isWorking = false;
      Console.WriteLine(number); 
      Console.WriteLine(count);
      Console.WriteLine(totalPrice);
      Console.WriteLine(character);
      Console.WriteLine(firstName);
      Console.WriteLine(isWorking);
      Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue); //0 and 1 represent arguments that take in values 
      Console.Write("{0} {1}", float.MinValue, float.MaxValue);

      //Type Conversion 
      //Use Convert or .Parse   

      try {
        string str = "true";
        bool b = Convert.ToBoolean(str);
        Console.WriteLine(b);
      }
      catch (Exception)
      {
        Console.WriteLine("The number cannot be converted to a byte");
      }


      }
  }
}
