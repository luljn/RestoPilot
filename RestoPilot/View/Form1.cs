using RestoPilot.Controller;

namespace RestoPilot.View;

public partial class Form1 : Form {    // Form used to build the menu of the application.

    private RestoController RestoController = new RestoController();
    public Form1() {
        
        InitializeComponent();
        this.Load += Form1Load;
        PutPictureBoxesOnScreen();
        PutGeneralLabelOnScreen();
    }

    public Button BuildCustomButton(int PositionX = 50, int PositionY = 50, int Width = 550, int Height = 50, string ButtonText = "") {  // To Build Customize button for the menu.
        
        Button button = new Button();
        button.Location = new Point(PositionX, PositionY);
        button.Size = new Size(Width, Height);
        button.Text = ButtonText;
        
        return button;
    }

    public PictureBox BuildCustomPictureBox(Image Image, int PositionX = 50, int PositionY = 50, int Width = 550, int Height = 50) {
        
        PictureBox PictureBox = new PictureBox();
        PictureBox.Location = new Point(PositionX, PositionY);
        PictureBox.Size = new Size(Width, Height);
        PictureBox.Image = Image;
        PictureBox.SizeMode = PictureBoxSizeMode.Zoom;

        return PictureBox;
    }

    public void Form1Load(object sender, EventArgs e) {  // To customize the buttons elements of the menu.
        
        /* Variables for buttons */
        int PositionX = 1150, PositionY = 450;
        int Width = 550, Height = 80;
        int interval = 10;             // interval between each button.
        /* */
        
        List<Button> ButtonList = new List<Button>(); // List of all the buttons of the menu.
        
        Button StartASimulationButton = BuildCustomButton(PositionX, PositionY, Width, Height, "Démarrer une simulation");
        DesignButton(StartASimulationButton);
        
        Button LoadASimulationButton = BuildCustomButton(PositionX, PositionY + Height + interval, Width, Height, "Charger une simulation");
        DesignButton(LoadASimulationButton);
        
        Button QuitButton = BuildCustomButton(PositionX, PositionY + Height*2 + interval*2, Width, Height, "Quitter");
        DesignButton(QuitButton);
        
        ButtonList.Add(StartASimulationButton);
        ButtonList.Add(LoadASimulationButton);
        ButtonList.Add(QuitButton);
        
        foreach (Button item in ButtonList) {
            
            item.BackColor = Color.CornflowerBlue;
            item.FlatAppearance.BorderColor = Color.Black;
            item.FlatStyle = FlatStyle.Flat; // Applique un style plat
            item.FlatAppearance.MouseOverBackColor = Color.SlateBlue; // Changer la couleur de fond lors du survol
            this.Controls.Add(item);
        }

        StartASimulationButton.Click += StartASimulation;
        QuitButton.Click += QuitApp;
    }

    public void DesignButton(Button button) { // To design a button.
        
        // Changer la taille de la police du texte du bouton
        button.Font = new Font(button.Font.FontFamily, 25, button.Font.Style);
        // Changer la police du texte du bouton
        button.Font = new Font("Times New Roman", button.Font.Size, button.Font.Style);
        // Mettre en gras le texte du bouton
        button.Font = new Font(button.Font, FontStyle.Bold);
    }

    public void PutPictureBoxesOnScreen() {
        
        List<PictureBox> PictureBoxList = new List<PictureBox>();   // List of all the PictureBoxes of the menu.
        
        PictureBox MenuBox = BuildCustomPictureBox(Image.FromFile("C:\\Users\\User\\Documents\\X2026\\X3 2023-2024\\SEM1 X3\\4 - Programmation concurrente\\Projet Programmation Système\\Images\\menu.PNG"), 1150, 150, 550, 200);
        PictureBoxList.Add(MenuBox);
        
        PictureBox WelcomeBox = BuildCustomPictureBox(Image.FromFile("C:\\Users\\User\\Documents\\X2026\\X3 2023-2024\\SEM1 X3\\4 - Programmation concurrente\\Projet Programmation Système\\Images\\simul1.png"), 200, 300, 675, 640);
        PictureBoxList.Add(WelcomeBox);
        
        foreach (PictureBox item in PictureBoxList) {
            
            this.Controls.Add(item);
        }
    }
    
    public void PutGeneralLabelOnScreen() {

        Label label = new Label();
        label.Text = "Bienvenue sur RestoPilot";
        label.Font = new Font("Times New Roman", 50, FontStyle.Bold);
        label.AutoSize = true; // Le label s'adapte auto à son contenu.
        label.Left = (this.ClientSize.Width - label.Width) / 2;// Pour centrer le label automatiquement sur la fenêtre.
        this.Controls.Add(label);
    }
    
    public void QuitApp(object sender, EventArgs e) {   // To close the app on the menu (with the button "Quitter").
        
        // RestoController.QuitApp(sender, e);
        this.Close();
    }

    public void StartASimulation(object sender, EventArgs e) {
        
        RestoController.StartASimulation(sender, e);
    }
}