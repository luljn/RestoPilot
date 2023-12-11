using RestoPilot.View;

namespace RestoPilot.Controller;

public class RestoController {

    private Form1 Menu { set; get; }   // The menu of the application.
    private Form2 Simulation { set; get; }  // The current simulation.
    
    public RestoController() {}
    
    [STAThread]
    public void Start() {     // To run the application.
        
        ApplicationConfiguration.Initialize();
        Application.Run(Menu = new Form1());
    }

    public void QuitApp(object sender, EventArgs e) {   // To close the app on the menu (with the button "Quitter").

        Menu = new Form1();
        Menu.Close();
    }

    public void StartASimulation(object sender, EventArgs e) {   // To start a new simulation on the app.

        Simulation = new Form2();
        Simulation.Show();
    }

    public void SetMenu(Form1 Menu) { this.Menu = Menu; }
    
    public Form1 GetMenu() { return this.Menu; }
}