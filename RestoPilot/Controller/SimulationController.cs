using RestoPilot.Model;
using RestoPilot.View;
using Timer = System.Windows.Forms.Timer;

namespace RestoPilot.Controller;

public class SimulationController {
    
    private Form2 Simulation { set; get; }  // The current simulation.
    private Restaurant Restaurant;
    private Timer Timer;
    private Client Client;
    
    public SimulationController(){}
    
    public void StartASimulation(object sender, EventArgs e) {   // To start a new simulation on the app.

        Simulation = new Form2();
        this.Restaurant = new Restaurant();
        
        Simulation.Show();
        
        Simulation.Controls.Add(Restaurant.GetHall().GetHallBox());
        Simulation.Controls.Add(Restaurant.GetKitchen().GetKitchenBox());
        
        Simulation.Controls.Add(Restaurant.BackToPrincipalMenuButton);
        Simulation.Controls.Add(Restaurant.BreakButton);
        
        SimulationLoad(sender, e);
    }
    
    public void SimulationLoad(object sender, EventArgs e) {

        this.Client = new Client();
        Simulation.Controls.Add(Client.GetClientBox());
        this.Timer = new Timer();
        this.Timer.Interval = 16;
        this.Timer.Tick += TimerTick;
        this.Timer.Start();
    }

    public void TimerTick(object sender, EventArgs e) {

        int speed = 12;         // move speed.
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
}