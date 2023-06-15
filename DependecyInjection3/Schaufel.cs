using System;

namespace DependecyInjection3
{
  internal class Schaufel : IGrabWerkzeug
  {
    public void Graben()
    { 
      Console.WriteLine("Graben, graben, graben, .... : Mit ein " + this.GetType().Name);
    }
  }
}
