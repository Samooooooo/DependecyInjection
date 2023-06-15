using System;

namespace DependecyInjection3
{
  internal class Loffel : IGrabWerkzeug
  {
    public void Graben()
    {
      Console.WriteLine("Graben, graben, graben, .... : Mit ein " + this.GetType().Name);
    }
  }
}
