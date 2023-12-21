using Timer = System.Windows.Forms.Timer;

namespace RestoPilot.Model.Hall;

public class Waiter : IMobile {       // Serveur.
    
    private PictureBox WaiterBox;
    private int Speed = 1;
    private Timer _timer;
    
    public Waiter() {
        
        this.WaiterBox = new PictureBox();
        this.WaiterBox.Image = Image.FromFile("C:\\Users\\User\\Documents\\X2026\\X2 2022-2023\\SEM1 X2\\2 - Programmation Orienté Objet (Java)\\Projet Développement dune application POO-UML-JAVA\\player_sprites\\tile078.png");
        this.WaiterBox.Location = new Point(0, 0);
        this.WaiterBox.Size = new Size(40, 40);
        this.WaiterBox.SizeMode = PictureBoxSizeMode.StretchImage;
    }
    
    public PictureBox GetBox() { return this.WaiterBox; }
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
        
        bool isPaused = false;
        int pauseDuration = 5000; // Durée de la pause en millisecondes (2 secondes)
        
        if (!isPaused)
        {
            if (this.GetBox().Top == 460)
            {
                isPaused = true;
                await Task.Delay(pauseDuration);
                isPaused = false;
                // Déplacez la PictureBox vers le haut
                GetBox().Top -= Speed;
            }

            // else if (this.GetBox().Top == 0)
            // {
            //     GetBox().Top -= 0;
            // }
        }
    }
}