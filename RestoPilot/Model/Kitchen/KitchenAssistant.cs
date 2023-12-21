using Timer = System.Windows.Forms.Timer;

namespace RestoPilot.Model.Kitchen;

public class KitchenAssistant : IMobile { // Commis de cuisine.
    
    private PictureBox KitchenAssistantBox;
    private int Speed = 2;
    private Timer _timer;
    bool _movingRight = true; // Direction de déplacement
    
    public KitchenAssistant() {
        
        this.KitchenAssistantBox = new PictureBox();
        this.KitchenAssistantBox.Image = Image.FromFile("C:\\Users\\User\\Documents\\X2026\\X2 2022-2023\\SEM1 X2\\2 - Programmation Orienté Objet (Java)\\Projet Développement dune application POO-UML-JAVA\\player_sprites\\tile084.png");
        this.KitchenAssistantBox.Location = new Point(0, 0);
        this.KitchenAssistantBox.Size = new Size(40, 40);
        this.KitchenAssistantBox.SizeMode = PictureBoxSizeMode.StretchImage;
    }
    
    public PictureBox GetBox() { return this.KitchenAssistantBox; }
    
    public Timer GetTimer() { return this._timer; }
    
    public int GetSpeed() { return this.Speed; }
    public void SetSpeed(int _Speed) { this.Speed = _Speed; }

    public void Deplacement(object sender, EventArgs e) {
        
        _timer = new Timer();
        _timer.Interval = 16; // Rafraîchir environ toutes les 16 millisecondes (environ 60 FPS)
        _timer.Tick += Timer_Tick;
        _timer.Start();
    }
    
    private void Timer_Tick(object sender, EventArgs e) {
        
        // Mettre à jour la position horizontale de la PictureBox en fonction de la direction de déplacement
        if (_movingRight)
        {
            GetBox().Left += Speed;
            if (GetBox().Right >= 380) // Vérifier si la PictureBox atteint le bord droit de la fenêtre
            {
                _movingRight = false; // Changer la direction de déplacement
            }
        }
        else
        {
            GetBox().Left -= Speed;
            if (GetBox().Left <= 180) // Vérifier si la PictureBox atteint le bord gauche de la fenêtre
            {
                _movingRight = true; // Changer la direction de déplacement
            }
        }
    }
}