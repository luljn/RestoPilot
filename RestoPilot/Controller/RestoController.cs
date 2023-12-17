using RestoPilot.Model;
using RestoPilot.View;

namespace RestoPilot.Controller;

public class RestoController {

    private Form1 Menu { set; get; }   // The menu of the application.
    
    public RestoController() {}
    
    [STAThread]
    public void Start() {     // To run the application.
        
        ApplicationConfiguration.Initialize();
        Application.Run(this.Menu = new Form1());
    }
    
    public void QuitApp(object sender, EventArgs e) {   // To close the app on the menu (with the button "Quitter").

        // Menu = new Form1();
        GetMenu().Close();
    }
    
    public void SetMenu(Form1 Menu) { this.Menu = Menu; }
    
    public Form1 GetMenu() { return this.Menu; }
}