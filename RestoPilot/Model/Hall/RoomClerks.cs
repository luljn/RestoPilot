using Timer = System.Windows.Forms.Timer;

namespace RestoPilot.Model.Hall;

public class RoomClerks : IMobile { // Commis de cuisine.
    
    private PictureBox RoomClerksBox;
    private int Speed;
    private Timer _timer = new Timer();
    
    public RoomClerks() {
        
        this.RoomClerksBox = new PictureBox();
        this.RoomClerksBox.Image = Image.FromFile("C:\\Users\\User\\Documents\\X2026\\X2 2022-2023\\SEM1 X2\\2 - Programmation Orienté Objet (Java)\\Projet Développement dune application POO-UML-JAVA\\player_sprites\\tile076.png");
        this.RoomClerksBox.Location = new Point(0, 0);
        this.RoomClerksBox.Size = new Size(40, 40);
        this.RoomClerksBox.SizeMode = PictureBoxSizeMode.StretchImage;
    }
    
    public PictureBox GetBox() { return this.RoomClerksBox; }
    public Timer GetTimer()
    {
        return this._timer;
    }

    public int GetSpeed() { return this.Speed; }
    public void SetSpeed(int _Speed) { this.Speed = _Speed; }

    public void Deplacement(object sender, EventArgs e) {
        
    }
}