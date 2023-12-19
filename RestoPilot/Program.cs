using RestoPilot.Controller;

namespace RestoPilot;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        new RestoController().Start();
    }
}