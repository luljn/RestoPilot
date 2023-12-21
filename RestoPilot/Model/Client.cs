using System.Threading.Tasks;
using Timer = System.Windows.Forms.Timer;

namespace RestoPilot.Model;

public class Client : IMobile {

    private PictureBox ClientBox { get;  }
    private Timer _timer;
    private int Speed { get; set; }   // Speed of move.

    public Client() {

        this.ClientBox = new PictureBox();
        this.ClientBox.Image = Image.FromFile("C:\\Users\\User\\Documents\\X2026\\X2 2022-2023\\SEM1 X2\\2 - Programmation Orienté Objet (Java)\\Projet Développement dune application POO-UML-JAVA\\player_sprites\\tile072.png");
        this.ClientBox.Location = new Point(0, 0);
        this.ClientBox.Size = new Size(40, 40);
        this.ClientBox.SizeMode = PictureBoxSizeMode.StretchImage;
    }
    
    public PictureBox GetBox() { return this.ClientBox; }
    public Timer GetTimer()
    {
        return this._timer;
    }

    public int GetSpeed() { return this.Speed; }
    public void SetSpeed(int _Speed) { this.Speed = _Speed; }

    public void Deplacement(object sender, EventArgs e) {
        
        
        _timer = new Timer();
        _timer.Interval = 16; // Rafraîchir environ toutes les 16 millisecondes (environ 60 FPS)
        _timer.Tick += Timer_Tick;
        _timer.Start();
    }
    
    private async void Timer_Tick(object sender, EventArgs e) {
        
        int direction = 1;
        int _direction = -1;
        bool isPaused = false;
        int pauseDuration = 2000; // Durée de la pause en millisecondes (2 secondes)
        
        if (!isPaused) {
            
            // Exécutez le code souhaité lorsque le Timer n'est pas en pause
            // Par exemple, mettez à jour l'interface utilisateur, effectuez des calculs, etc.
            if (this.GetBox().Top == 0 && this.GetBox().Bottom <= 170) {
                
                // Mettez le Timer en pause pendant la durée spécifiée
                isPaused = true;
                await Task.Delay(pauseDuration);
                isPaused = false;
                this.GetBox().Top += Speed * direction;
            }
            
            else if (this.GetBox().Top > 0 && this.GetBox().Bottom <= 170) {
            
                this.GetBox().Top += Speed * direction;
            }
        }
    }
}