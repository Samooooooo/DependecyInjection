namespace DependecyInjection3
{
  internal class Lehrling : IMitarbeiter
  {
    private IGrabWerkzeug werkzeug;
    public Lehrling(IGrabWerkzeug werkzeug)
    {
      this.werkzeug = werkzeug;
    }
    public void GrabMalEinloch()
    {
      werkzeug.Graben();
    }
  }
}
