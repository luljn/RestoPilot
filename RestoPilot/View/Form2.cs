using RestoPilot.Controller;
using Timer = System.Windows.Forms.Timer;

namespace RestoPilot.View;

public partial class Form2 : Form {    // Form used to run a simulation in the application.

    private RestoController RestoController;
    private SimulationController SimulationController;
    private Timer Timer;
    
    public Form2() {
        
        InitializeComponent();
    }
}