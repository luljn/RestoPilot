namespace RestoPilot.Model.Kitchen;

public class Chef { // Chef de cuisine.
    
    private PictureBox ChefBox { get;  }
    
        public Chef() {
            
            this.ChefBox = new PictureBox();
            this.ChefBox.Image = Image.FromFile("C:\\Users\\User\\Documents\\X2026\\X2 2022-2023\\SEM1 X2\\2 - Programmation Orienté Objet (Java)\\Projet Développement dune application POO-UML-JAVA\\assets\\images\\PLAYER\\idle1.png");
            this.ChefBox.Location = new Point(1100, 200);
            this.ChefBox.Size = new Size(40, 40);
            this.ChefBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        
        public PictureBox GetChefBox() { return this.ChefBox; }
    
}