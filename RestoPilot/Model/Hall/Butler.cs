namespace RestoPilot.Model.Hall;

public class Butler { // Maitre d'hotel.

    private PictureBox ButlerBox { get;  }

    public Butler() {
        
        this.ButlerBox = new PictureBox();
        this.ButlerBox.Image = Image.FromFile("C:\\Users\\User\\Documents\\X2026\\X2 2022-2023\\SEM1 X2\\2 - Programmation Orienté Objet (Java)\\Projet Développement dune application POO-UML-JAVA\\player_sprites\\tile073.png");
        this.ButlerBox.Location = new Point(60, 0);
        this.ButlerBox.Size = new Size(40, 40);
        this.ButlerBox.SizeMode = PictureBoxSizeMode.StretchImage;
    }
    
    public PictureBox GetButlerBox() { return this.ButlerBox; }
}