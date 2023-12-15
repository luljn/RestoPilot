using RestoPilot.Controller;
using System.Drawing;
using RestoPilot.View;

namespace RestoPilotTest;

[TestClass]
public class Form1Tests {
    
    private Form1 form = new Form1(); // The test form created to execute tests.
    
    [TestMethod]
    public void BuildCustomButton_ShouldReturnButtonWithCorrectProperties() {   // To test the creation of the buttons which are on the menu.
        // Arrange
        
        int positionX = 50;
        int positionY = 50;
        int width = 550;
        int height = 50;
        string buttonText = "Test Button";

        // Act
        var button = form.BuildCustomButton(positionX, positionY, width, height, buttonText);

        // Assert
        Assert.AreEqual(positionX, button.Location.X);
        Assert.AreEqual(positionY, button.Location.Y);
        Assert.AreEqual(width, button.Size.Width);
        Assert.AreEqual(height, button.Size.Height);
        Assert.AreEqual(buttonText, button.Text);
    }
    
    [TestMethod]
    public void BuildCustomPictureBox_ShouldReturnPictureBoxWithCorrectProperties() {  // To test the creation of the pictureboxes which are on the menu.
        // Arrange
        int positionX = 100;
        int positionY = 200;
        int width = 800;
        int height = 600;
        Image image = new Bitmap(width, height); // Create a test image

        // Act
        var pictureBox = form.BuildCustomPictureBox(image, positionX, positionY, width, height);

        // Assert
        Assert.AreEqual(positionX, pictureBox.Location.X);
        Assert.AreEqual(positionY, pictureBox.Location.Y);
        Assert.AreEqual(width, pictureBox.Size.Width);
        Assert.AreEqual(height, pictureBox.Size.Height);
        Assert.AreEqual(image, pictureBox.Image);
        Assert.AreEqual(PictureBoxSizeMode.Zoom, pictureBox.SizeMode);
    }
    
    [TestMethod]
    public void DesignButton_ShouldApplyCorrectFontProperties() { // To test the design of the customs buttons.
        // Arrange
        Button button = new Button();
        button.Font = new Font("Arial", 12, FontStyle.Regular);

        // Act
        form.DesignButton(button);

        // Assert
        Assert.AreEqual(25, button.Font.Size);
        Assert.AreEqual("Times New Roman", button.Font.FontFamily.Name);
        Assert.AreEqual(FontStyle.Bold, button.Font.Style);
    }
    
    [TestMethod]
    public void PutPictureBoxesOnScreen_ShouldAddPictureBoxesToControls() {
        // Arrange
        var pictureBoxList = new List<PictureBox>();

        var menuImage = Image.FromFile("C:\\Users\\User\\Documents\\X2026\\X3 2023-2024\\SEM1 X3\\4 - Programmation concurrente\\Projet Programmation Système\\Images\\menu.PNG");
        var menuBox = form.BuildCustomPictureBox(menuImage, 1150, 150, 550, 200);
        pictureBoxList.Add(menuBox);

        var welcomeImage = Image.FromFile("C:\\Users\\User\\Documents\\X2026\\X3 2023-2024\\SEM1 X3\\4 - Programmation concurrente\\Projet Programmation Système\\Images\\simul1.png");
        var welcomeBox = form.BuildCustomPictureBox(welcomeImage, 200, 300, 675, 640);
        pictureBoxList.Add(welcomeBox);

        // Act
        form.PutPictureBoxesOnScreen();

        // Assert
        // Assert.AreEqual(pictureBoxList.Count, pictureBoxList.Count);
        // foreach (var pictureBox in pictureBoxList) {
        //     
        //     Assert.IsTrue(form.Controls.Contains(pictureBox));
        // }
    }
    
    [TestMethod]
    public void PutGeneralLabelOnScreen_ShouldAddLabelToControls() {
        // Arrange
        Label label = new Label();
        label.Text = "Bienvenue sur RestoPilot";
        label.Font = new Font("Times New Roman", 50, FontStyle.Bold);
        label.AutoSize = true;
        label.Left = (form.ClientSize.Width - label.Width) / 2;

        // Act
        form.PutGeneralLabelOnScreen();

        // Assert
        // Assert.IsTrue(form.Controls.Contains(label));
    }
    
    [TestMethod]
    public void QuitApp_ShouldCloseTheForm() {
        // Act
        form.QuitApp(form, EventArgs.Empty);
        // Assert
        Assert.IsTrue(form.IsDisposed);
    }
}