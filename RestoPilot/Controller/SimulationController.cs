using RestoPilot.Model;
using RestoPilot.View;
using Timer = System.Windows.Forms.Timer;

namespace RestoPilot.Controller;

public class SimulationController {
    
    private Form2 Simulation { set; get; }  // The current simulation.
    private Restaurant Restaurant;
    private List<IMobile> MobileElements;   // List of all the mobile elements on the current simulation.
    private Timer Timer;
    private Client Client;
    private Butler Butler;
    private Chef Chef;
    
    public SimulationController(){}
    
    public void StartASimulation(object sender, EventArgs e) {   // To start a new simulation on the app.

        Simulation = new Form2();
        this.Restaurant = new Restaurant();
        this.Chef = new Chef();
        
        Simulation.Show();
        
        // Simulation.Controls.Add(Restaurant.GetHall().GetHallBox());
        // Simulation.Controls.Add(Chef.GetChefBox());
        
        Restaurant.GetKitchen().GetKitchenBox().Controls.Add(Chef.GetChefBox());
        // Restaurant.GetHall().GetHallBox().Controls.Add(Chef.GetChefBox());
        
        Simulation.Controls.Add(Restaurant.GetHall().GetHallBox());
        Simulation.Controls.Add(Restaurant.GetKitchen().GetKitchenBox());
        
        Simulation.Controls.Add(Restaurant.BackToPrincipalMenuButton);
        Simulation.Controls.Add(Restaurant.BreakButton);
        
        SimulationLoad(sender, e);
    }
    
    public void SimulationLoad(object sender, EventArgs e) {

        this.Client = new Client();
        this.Butler = new Butler();
        Simulation.Controls.Add(Client.GetClientBox());
        Simulation.Controls.Add(Butler.GetButlerBox());
        
        this.Timer = new Timer();
        this.Timer.Interval = 16;
        this.Timer.Tick += Client.Deplacement;
        this.Timer.Start();

        Restaurant.BackToPrincipalMenuButton.Click += BackToPrincipalMenu;  // To return on the principal menu (button).
    }

    public void TimerTick(object sender, EventArgs e) {

        int speed = 2;         // move speed.
        int direction = 1;
        int _direction = -1;
        
        if (this.Client.GetClientBox().Top >= 0 && this.Client.GetClientBox().Bottom <= 1040) {
            
            this.Client.GetClientBox().Top += speed * direction;
        }
        
        else if (this.Client.GetClientBox().Top == 1000 && this.Client.GetClientBox().Bottom == 1040) {
        
            while (this.Client.GetClientBox().Top != 0) {
                
                this.Client.GetClientBox().Top += speed * _direction;
            }
        }
    }
    
    public void BackToPrincipalMenu(object sender, EventArgs e) {  // To return on the principal menu (function).
        
        this.Simulation.Close();
    }
    
    public Restaurant GetRestaurant() { return this.Restaurant; }
}