using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependecyInjection1
{
  internal class Lehrling
  {
    private Schaufel schaufel;
    public Lehrling()
    {
      schaufel = new Schaufel();
    }
    public void GrabMalEinloch()
    {
      schaufel.Graben();
    }
  }
}
