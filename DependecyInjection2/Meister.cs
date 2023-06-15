namespace DependecyInjection2
{
  internal class Meister
  {
    private Lehrling lehrling;
    public Meister()
    {
      lehrling = new Lehrling(new Schaufel());
    }
    public void GibAnweisung()
    {
      lehrling.GrabMalEinloch();
    }
  }
}
