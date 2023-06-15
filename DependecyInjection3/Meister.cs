using System.Collections.Generic;

namespace DependecyInjection3
{
  internal class Meister
  {
    public List<IMitarbeiter> mitarbeiters;

    private Lehrling lehrling;
    private Chef chef;
    public Meister()
    {
      lehrling = new Lehrling(new Schaufel());
      chef = new Chef (new Loffel());
    }
    public void GibAnweisung()
    {
      foreach (var MitA in mitarbeiters)
      {
        MitA.GrabMalEinloch();
      }
    }
  }
}
