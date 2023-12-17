namespace RestoPilot.Model;

public class Client {

    private PictureBox ClientBox { get;  }

    public Client() {

        this.ClientBox = new PictureBox();
        this.ClientBox.Image = Image.FromFile("C:\\Users\\User\\Documents\\X2026\\X2 2022-2023\\SEM1 X2\\2 - Programmation Orienté Objet (Java)\\Projet Développement dune application POO-UML-JAVA\\assets\\images\\PLAYER\\idle1.png");
        this.ClientBox.Location = new Point(0, 0);
        this.ClientBox.Size = new Size(40, 40);
        this.ClientBox.SizeMode = PictureBoxSizeMode.StretchImage;
    }
    
    public PictureBox GetClientBox() { return this.ClientBox; }
}