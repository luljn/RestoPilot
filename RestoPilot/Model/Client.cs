namespace RestoPilot.Model;

public class Client : IMobile {

    private PictureBox ClientBox { get;  }
    private int Speed { get; set; }   // Speed of move.

    public Client() {

        this.ClientBox = new PictureBox();
        this.ClientBox.Image = Image.FromFile("C:\\Users\\User\\Documents\\X2026\\X2 2022-2023\\SEM1 X2\\2 - Programmation Orienté Objet (Java)\\Projet Développement dune application POO-UML-JAVA\\assets\\images\\PLAYER\\idle1.png");
        this.ClientBox.Location = new Point(0, 0);
        this.ClientBox.Size = new Size(40, 40);
        this.ClientBox.SizeMode = PictureBoxSizeMode.StretchImage;
    }
    
    public PictureBox GetClientBox() { return this.ClientBox; }
    
    public int GetSpeed() { return this.Speed; }
    public void SetSpeed(int _Speed) { this.Speed = _Speed; }

    public void Deplacement(object sender, EventArgs e) {
        
        // Speed = 2;         // move speed.
        int direction = 1;
        int _direction = -1;
        
        if (this.GetClientBox().Top >= 0 && this.GetClientBox().Bottom <= 1040) {
            
            this.GetClientBox().Top += Speed * direction;
        }
        
        else if (this.GetClientBox().Top == 1000 && this.GetClientBox().Bottom == 1040) {
        
            while (this.GetClientBox().Top != 0) {
                
                this.GetClientBox().Top += Speed * _direction;
            }
        }
    }
}