using Timer = System.Windows.Forms.Timer;

namespace RestoPilot.Model.Hall;

public class Waiter : IMobile {       // Serveur.
    
    private PictureBox WaiterBox;
    private int Speed = 1;
    private Timer _timer;
    bool _movingRight = true;
    
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
        int pauseDuration = 15000; // Durée de la pause en millisecondes (2 secondes)
        
        if (!isPaused)
        {
            if (this.GetBox().Top == 460)
            {
                isPaused = true;
                await Task.Delay(pauseDuration);
                isPaused = false;
                // Déplacez la PictureBox vers le haut
                GetBox().Top = 450;
                GetBox().Left = 100;
                await Task.Delay(5000);  // On attend 5 secondes.
                // GetBox().Left += Speed;
                if (_movingRight)
                {
                    GetBox().Left += Speed;
                    if (GetBox().Right >= 1050) // Vérifier si la PictureBox atteint le bord droit de la fenêtre
                    {
                        _movingRight = false; // Changer la direction de déplacement
                    }
                }
                else
                {
                    GetBox().Left -= Speed;
                    if (GetBox().Left <= 140) // Vérifier si la PictureBox atteint le bord gauche de la fenêtre
                    {
                        _movingRight = true; // Changer la direction de déplacement
                    }
                }
            }

            // else if (this.GetBox().Top == 0)
            // {
            //     GetBox().Top -= 0;
            // }
        }
    }
}