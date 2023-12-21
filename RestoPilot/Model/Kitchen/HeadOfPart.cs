using Timer = System.Windows.Forms.Timer;

namespace RestoPilot.Model.Kitchen;

public class HeadOfPart : IMobile { // Chef de partie.
    
    private PictureBox HeadOfPartBox;
    private int Speed = 2;
    public Timer _timer;
    
    public HeadOfPart() {
        
        this.HeadOfPartBox = new PictureBox();
        this.HeadOfPartBox.Image = Image.FromFile("C:\\Users\\User\\Documents\\X2026\\X2 2022-2023\\SEM1 X2\\2 - Programmation Orienté Objet (Java)\\Projet Développement dune application POO-UML-JAVA\\player_sprites\\tile083.png");
        this.HeadOfPartBox.Location = new Point(0, 0);
        this.HeadOfPartBox.Size = new Size(40, 40);
        this.HeadOfPartBox.SizeMode = PictureBoxSizeMode.StretchImage;
    }
    
    public PictureBox GetBox() { return this.HeadOfPartBox; }
    
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
        
        // Déplacez la PictureBox vers le haut
        GetBox().Top -= Speed;

        // Vérifiez si la PictureBox atteint le bord supérieur du formulaire
        if (GetBox().Top + GetBox().Height <= 330) {
            
            // Réinitialisez la position de la PictureBox en bas du formulaire
            GetBox().Top = 350;
            // GetBox().Top += Speed;
        }
    }
}