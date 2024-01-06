using RestoPilot.Model;
using RestoPilot.Model.Hall;
using RestoPilot.Model.Kitchen;
using RestoPilot.View;
using Timer = System.Windows.Forms.Timer;

namespace RestoPilot.Controller;

public class SimulationController {
    
    private Form2 Simulation { set; get; }         // The current simulation.
    private Restaurant Restaurant;
    private static Factory Factory = new Factory();                         //   To build all the IMobile elements of the simulation.
    private List<IMobile> HallMobileElements = Factory.BuildHallMobileElements();          // List of all the mobile elements on the current simulation for the Hall.
    private List<IMobile> KitchenMobileElements = Factory.BuildKitchenMobileElements();      //  List of all the mobile elements on the current simulation for the Kitchen.
    private Timer Timer;
    private Client Client;
    private Butler Butler;
    private Chef Chef;
    
    public SimulationController(){}
    
    public void StartASimulation(object sender, EventArgs e) {   // To start a new simulation on the app.

        Simulation = new Form2();
        Simulation.Show();
        
        SimulationLoad(sender, e);
    }
    
    public void SimulationLoad(object sender, EventArgs e) {
        
        this.Restaurant = new Restaurant();
        this.Butler = new Butler();
        this.Client = new Client();
        this.Chef = new Chef();
        // this.Factory = new Factory();
        // this.HallMobileElements = Factory.BuildHallMobileElements();
        // this.KitchenMobileElements = Factory.BuildKitchenMobileElements();
        
        foreach (IMobile element in HallMobileElements) {
            
            Restaurant.GetHall().GetHallBox().Controls.Add(element.GetBox());
            element.Deplacement(sender, e);
        }
        
        foreach (IMobile element in KitchenMobileElements) {
            
            Restaurant.GetKitchen().GetKitchenBox().Controls.Add(element.GetBox());
            element.Deplacement(sender, e);
        }
        
        Factory.PutSomeClientInTheRestaurant(this.Restaurant.GetHall());
        
        // Client.GetBox().Location = new Point(0, 260);
        
        
        
        Restaurant.GetHall().GetHallBox().Controls.Add(Butler.GetButlerBox());
        Restaurant.GetHall().GetHallBox().Controls.Add(Client.GetBox());
        Restaurant.GetKitchen().GetKitchenBox().Controls.Add(Chef.GetChefBox());
        
        Simulation.Controls.Add(Restaurant.GetHall().GetHallBox());
        Simulation.Controls.Add(Restaurant.GetKitchen().GetKitchenBox());
        
        Simulation.Controls.Add(Restaurant.BackToPrincipalMenuButton);
        Simulation.Controls.Add(Restaurant.BreakButton);
        Simulation.Controls.Add(Restaurant.ResumeTheSimulationButton);
        
        this.Timer = new Timer();
        this.Timer.Interval = 16;
        // this.Client.SetSpeed(1);
        // this.Timer.Tick += Client.Deplacement;
        this.Timer.Start();
        
        this.Client.SetSpeed(1);
        this.Client.Deplacement(sender, e);

        Restaurant.BackToPrincipalMenuButton.Click += BackToPrincipalMenu;      // To return on the principal menu (button).
        Restaurant.BreakButton.Click += PutTheSimulationOnPause;               //  To pause the simulation (button). 
        Restaurant.ResumeTheSimulationButton.Click += ResumeTheSimulation;     //  To Resume the simulation (button).
    }
    
    public void BackToPrincipalMenu(object sender, EventArgs e) {  // To return on the principal menu (function).
        
        this.Simulation.Close();
    }

    public void PutTheSimulationOnPause(object sender, EventArgs e) {  // To pause the simulation with the "Pause" button (function).
        
        this.Timer.Stop();
        
        foreach (IMobile element in KitchenMobileElements) {
            
            element.GetTimer().Stop();
        }
        
        foreach (IMobile element in HallMobileElements) {
            
            element.GetTimer().Stop();
        }
    }

    public void ResumeTheSimulation(object sender, EventArgs e) {   // To Resume the simulation (function).
        
        this.Timer.Start();
        
        foreach (IMobile element in KitchenMobileElements) {
            
            element.GetTimer().Start();
        }
        
        foreach (IMobile element in HallMobileElements) {
            
            element.GetTimer().Start();
        }
    }
    
    public Restaurant GetRestaurant() { return this.Restaurant; }
    
    public Form2 GetSimulation() { return this.Simulation; }
    
    public List<IMobile> GetHallMobileElements() { return this.HallMobileElements; }
    
    public List<IMobile> GetKitchenMobileElements() { return this.KitchenMobileElements; }
}