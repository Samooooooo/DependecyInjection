namespace DependecyInjection2
{
  internal class Lehrling
  {
    private Schaufel schaufel;
    public Lehrling(Schaufel schaufel)
    {
      this.schaufel = schaufel;
    }
    public void GrabMalEinloch()
    {
      schaufel.Graben();
    }
  }
}
