using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{ 
  public class Person
  {
    public string Name;  
    public Person(string name)
    {
      Name = name;
    }

    public void Introduce()
    {
      Console.WriteLine("Hi, my name is " + Name);
    } 
    public void IntroduceTo(Person person)
    {
      Console.WriteLine("Hello " + person.Name + ", my name is " +  Name);
    }
  }
  internal class Program
  {
    static void Main(string[] args)
    {
      Person Jin = new Person("Jin"); //Or you could use var Jin to save time of writing class name 
      Person Justin = new Person("Justin");
      Jin.Introduce();
      Jin.IntroduceTo(Justin);
    }
  }
}
