using RestoPilot.Model.Hall;
using RestoPilot.Model.Kitchen;

namespace RestoPilot.Model;

public class Factory {
    
    public Factory() {}

    public List<IMobile> BuildHallMobileElements() {   // To build all the mobile elements of the simulation for the hall.

        List<IMobile> MobileElements = new List<IMobile>();

        RoomClerks RoomClerks = new RoomClerks();
        RoomClerks.GetBox().Location = new Point(580, 340);

        HeadWaiter HeadWaiter1 = new HeadWaiter();
        HeadWaiter HeadWaiter2 = new HeadWaiter();
        HeadWaiter1.GetBox().Location = new Point(100, 0);
        HeadWaiter2.GetBox().Location = new Point(650, 300);
        
        Waiter Waiter1 = new Waiter();
        Waiter Waiter2 = new Waiter();
        Waiter1.GetBox().Location = new Point(140, 460);
        Waiter2.GetBox().Location = new Point(1130, 200);
        
        MobileElements.Add(RoomClerks);
        MobileElements.Add(HeadWaiter1);
        MobileElements.Add(HeadWaiter2);
        MobileElements.Add(Waiter1);
        // MobileElements.Add(Waiter2);

        return MobileElements;
    }
    
    public List<IMobile> BuildKitchenMobileElements() {   // To build all the mobile elements of the simulation for the kitchen.

        List<IMobile> MobileElements = new List<IMobile>();

        Diver Diver = new Diver();
        Diver.GetBox().Location = new Point(450, 350);

        HeadOfPart HeadOfPart1 = new HeadOfPart();
        HeadOfPart HeadOfPart2 = new HeadOfPart();
        HeadOfPart1.GetBox().Location = new Point(660, 350);
        HeadOfPart2.GetBox().Location = new Point(810, 350);

        KitchenAssistant KitchenAssistant1 = new KitchenAssistant();
        KitchenAssistant KitchenAssistant2 = new KitchenAssistant();
        KitchenAssistant1.GetBox().Location = new Point(200, 180);
        KitchenAssistant2.GetBox().Location = new Point(200, 230);
        KitchenAssistant1.SetSpeed(3);
        
        MobileElements.Add(Diver);
        MobileElements.Add(HeadOfPart1);
        MobileElements.Add(HeadOfPart2);
        MobileElements.Add(KitchenAssistant1);
        MobileElements.Add(KitchenAssistant2);

        return MobileElements;
    }

    public void PutSomeClientInTheRestaurant(Hall.Hall Hall) {

        List<Client> Clients = new List<Client>();
        
        Client Client1 = new Client();
        Client Client2 = new Client();
        Client Client3 = new Client();
        Client Client4 = new Client();
        Client Client5 = new Client();
        Client Client6 = new Client();
        Client Client7 = new Client();
        Client Client8 = new Client();

        Client1.GetBox().Location = new Point(540, 10);
        Client2.GetBox().Location = new Point(540, 130);
        Client3.GetBox().Location = new Point(725, 340);
        Client4.GetBox().Location = new Point(775, 400);
        Client5.GetBox().Location = new Point(913, 25);
        Client6.GetBox().Location = new Point(913, 145);
        Client7.GetBox().Location = new Point(330, 400);
        Client8.GetBox().Location = new Point(380, 340);
        
        Clients.Add(Client1);
        Clients.Add(Client2);
        Clients.Add(Client3);
        Clients.Add(Client4);
        Clients.Add(Client5);
        Clients.Add(Client6);
        Clients.Add(Client7);
        Clients.Add(Client8);
        
        foreach (Client Client in Clients) {
            
            Hall.GetHallBox().Controls.Add(Client.GetBox());
        }
    }
}