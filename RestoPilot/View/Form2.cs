using RestoPilot.Controller;
using Timer = System.Windows.Forms.Timer;

namespace RestoPilot.View;

public partial class Form2 : Form {    // Form used to run a simulation in the application.

    private RestoController RestoController = new RestoController();
    private SimulationController SimulationController = new SimulationController();
    private Timer Timer = new Timer();
    
    public Form2() {
        
        InitializeComponent();
        // RestoController = new RestoController();
        // SimulationController = new SimulationController();
        // Timer = new Timer();
    }
    
    public RestoController GetRestoController() { return  this.RestoController; }
    
    public SimulationController GetSimulationController() { return  this.SimulationController; }
    
    public Timer GetTimer() { return this.Timer; }
}