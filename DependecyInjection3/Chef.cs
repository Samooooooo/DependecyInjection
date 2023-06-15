using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependecyInjection3
{
  internal class Chef : IMitarbeiter
  {
    private IGrabWerkzeug werkzeug;
    public Chef(IGrabWerkzeug werkzeug)
    {
      this.werkzeug = werkzeug;
      Meister.mitarbeiters.Add(this);
    }
    public void GrabMalEinloch()
    {
      werkzeug.Graben();
    }
  }
}
