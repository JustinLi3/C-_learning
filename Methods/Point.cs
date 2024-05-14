using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
  public class Point
  {
    public int x, y; // by default these are set as private
    public Point(int x, int y)
    {
      this.x = x;
      this.y = y;
    }
    public void Move(int x, int y)
    {
      this.x = x;
      this.y = y;
    }
    public void Move(Point newLocation)
    {
      if (newLocation == null)
      {
        throw new ArgumentNullException("Please input values for the new location");
      }
      Move(newLocation.x, newLocation.y);

    }
  }
}
