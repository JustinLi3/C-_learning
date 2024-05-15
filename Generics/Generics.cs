using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
  public class GenericList<T> //Here T represents a placeholder to what our value can be, string, int, obj, etc
  { 
    public void Add(T value)
    {

    }  
    public T this[int index] // A list of generics would return a datatype of type t and the this keyword hints that this is indexing
    {

    }
  } 
  public class GenericDictionary<TKey, TValue>
  {
    public void Add(TKey key, TValue value)
    {

    }
  }
}
