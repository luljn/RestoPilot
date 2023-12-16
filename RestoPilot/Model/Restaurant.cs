namespace RestoPilot.Model;

public class Restaurant {

    private Hall Hall { get; }
    private Kitchen Kitchen { get; }
    public Button BackToPrincipalMenuButton = BuildCustomButton(1360, 450, ButtonText:"Menu Principal");
    public Button BreakButton = BuildCustomButton(1360, 540, ButtonText:"Pause");
    
    public Restaurant() {

        this.Hall = new Hall();
        this.Kitchen = new Kitchen();
    }

    public Hall GetHall() { return this.Hall; }
    
    public Kitchen GetKitchen() { return this.Kitchen; }
    
    public static Button BuildCustomButton(int PositionX = 50, int PositionY = 50, int Width = 550, int Height = 80, string ButtonText = "") {  // To Build Customize button for the menu.
        
        Button button = new Button();
        button.Location = new Point(PositionX, PositionY);
        button.Size = new Size(Width, Height);
        button.Text = ButtonText;
        
        button.Font = new Font(button.Font.FontFamily, 25, button.Font.Style);
        button.Font = new Font("Times New Roman", button.Font.Size, button.Font.Style);
        button.Font = new Font(button.Font, FontStyle.Bold);
        
        button.BackColor = Color.CornflowerBlue;
        button.FlatAppearance.BorderColor = Color.Black;
        button.FlatStyle = FlatStyle.Flat; // Applique un style plat
        button.FlatAppearance.MouseOverBackColor = Color.SlateBlue; // Changer la couleur de fond lors du survol
        
        return button;
    }
}