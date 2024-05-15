using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
  interface IPrey
  {
    void Flee(); // declare but not implement as it is the job of the inheriting class that would like to use this interface
  }

  interface IPredator
  {
    void Hunt(); // declare but not implement as it is the job of the inheriting class that would like to use this interface
  }

  class Rabbit : IPrey // this is how to use the interface
  {
    public void Flee()
    {
      Console.WriteLine("The Rabbit Runs Away");
    }
  }

  class Hawk : IPredator
  {
    public void Hunt()
    {
      Console.WriteLine("The Hawk is Hunting");
    }
  }

  class Fish : IPrey, IPredator
  {
    public void Flee()
    {
      Console.WriteLine("The Fish Swims Away");
    }

    public void Hunt()
    {
      Console.WriteLine("The Fish is Hunting");
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Rabbit rabbit = new Rabbit();
      rabbit.Flee(); // This should print "The Rabbit Runs Away"

      Hawk hawk = new Hawk();
      hawk.Hunt(); // This should print "The Hawk is Hunting"

      Fish fish = new Fish();
      fish.Flee(); // This should print "The Fish Swims Away"
      fish.Hunt(); // This should print "The Fish is Hunting" 
      Console.ReadKey();
    }
  }
}