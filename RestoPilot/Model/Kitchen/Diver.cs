using Timer = System.Windows.Forms.Timer;

namespace RestoPilot.Model.Kitchen;

public class Diver : IMobile {     // Plongeur.

    private PictureBox DiverBox;
    private int Speed = 2;
    private Timer _timer;
    bool _movingRight = true; // Direction de déplacement
    
    public Diver() {
        
        this.DiverBox = new PictureBox();
        this.DiverBox.Image = Image.FromFile("C:\\Users\\User\\Documents\\X2026\\X2 2022-2023\\SEM1 X2\\2 - Programmation Orienté Objet (Java)\\Projet Développement dune application POO-UML-JAVA\\player_sprites\\tile074.png");
        this.DiverBox.Location = new Point(0, 0);
        this.DiverBox.Size = new Size(40, 40);
        this.DiverBox.SizeMode = PictureBoxSizeMode.StretchImage;
    }
    
    public PictureBox GetBox() { return this.DiverBox; }
    
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
            if (GetBox().Right >= 500) // Vérifier si la PictureBox atteint le bord droit de la fenêtre
            {
                _movingRight = false; // Changer la direction de déplacement
            }
        }
        else
        {
            GetBox().Left -= Speed;
            if (GetBox().Left <= 400) // Vérifier si la PictureBox atteint le bord gauche de la fenêtre
            {
                _movingRight = true; // Changer la direction de déplacement
            }
        }
    }
}