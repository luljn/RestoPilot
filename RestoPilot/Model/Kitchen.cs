namespace RestoPilot.Model;

public class Kitchen {
    
    private PictureBox KitchenBox { get; }
    
    public Kitchen() {
        
        this.KitchenBox = new PictureBox();
        this.KitchenBox.Image = Image.FromFile("C:\\Users\\User\\Documents\\X2026\\X3 2023-2024\\SEM1 X3\\4 - Programmation concurrente\\Projet Programmation Système\\Images\\kitchen.png");
        this.KitchenBox.Location = new Point(150, 525);
        this.KitchenBox.Size = new Size(1200, 520);
        this.KitchenBox.SizeMode = PictureBoxSizeMode.StretchImage;
    }
    
    public PictureBox GetKitchenBox() { return this.KitchenBox; }
}